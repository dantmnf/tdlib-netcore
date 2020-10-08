require 'zlib'
class TDLibTLTypeInfo
  TLClass = Struct.new(:name, :comment) do
    def to_s
      name.to_s
    end
    
    def converter
      "typeof(TLObjectConverter)"
    end

  end
  Type = Struct.new(:name, :realname, :props, :type, :tl_class, :source, :comment) do
    def to_s
      name.to_s
    end

    def converter
      "typeof(TLObjectConverter)"
    end

    def type_id
      val = Zlib.crc32(source.scan(/[#\?\[\]=]|[A-Za-z0-9:_]+/).join(' '))
      val -= 0x100000000 if val >= 0x80000000
      val
    end
  end
  Property = Struct.new(:name, :capname, :type, :comment) do
    def to_s
      name.to_s
    end
  end


  class Int64
    def self.to_s
      "long"
    end
    def self.converter
      "typeof(Int64Converter)"
    end
  end


  class Vector
    class << self
      attr_accessor :subtype, :item_converter
      @@subtypes = {}
      def to_s
        st, dim = nestinfo
        "#{st}#{"[]"*dim}"
      end

      def nestinfo
        dim = 1
        st = subtype
        while st.is_a?(Class) && st <= Vector
          dim += 1
          st = st.subtype
        end
        [st, dim]
      end

      def [](subtype)
        return @@subtypes[subtype] if @@subtypes[subtype]
        st = Class.new(Vector)
        st.subtype = subtype
        if subtype.is_a?(Class) && subtype <= Vector
          st.item_converter = subtype.item_converter
        else
          st.item_converter = subtype.converter if subtype.respond_to?(:converter) && subtype.converter
        end
        @@subtypes[subtype] = st
        st
      end

      def json_prop
        if item_converter
          return ["ItemConverterType = #{item_converter}"]
        end
        []
      end

      # def respond_to_missing?(name, inc)
      #   subtype.respond_to?(name, inc)
      # end

      # def method_missing(*args)
      #   subtype.__send__(*args)
      # end
    end
  end


  BuiltinTypes = {
    double: "double",
    string: "string",
    int32: "int",
    int53: "long",
    int64: Int64,
    bytes: "byte[]",
    vector: Vector,
    boolFalse: FalseClass,
    boolTrue: TrueClass,
    Bool: "bool"
  }.freeze

  Types = {}
  Functions = {}
  Classes = {}

  class LazyResolver
    def initialize(name)
      @name = name
    end

    def resolve
      AllDefinitions[@name] || Classes[@name] || @name
    end

    def to_s
      @name.to_s
    end

    def self.resolve(name)
      if name.is_a? LazyResolver
        return name.resolve
      elsif name.is_a? Symbol
        return AllDefinitions[name] || Classes[name] || name
      end
      return name
    end
  end

  class << self

    def load(tlfile=nil)
      tlfile =  File.join(File.realpath(File.dirname(__FILE__)), 'td_api.tl') unless tlfile
      comments = []
      File.open(tlfile, 'r') do |f|
        current = :type
        f.each_line do |line|
          line.strip!

          if line.start_with?('//')
            comments << line
            next
          end

          next if line.empty?
          if line == '---functions---'
            current = :function
            next
          end
          if line == '---types---'
            current = :type
            next
          end
          parse_line(line, current, comments)
          comments.clear
        end
      end

      Types.freeze
      Functions.freeze
      const_set(:AllDefinitions, Types.merge(Functions).freeze)

      AllDefinitions.each_value do |type|
        props = type.props
        props.each do |prop|
          ptype = prop.type
          if ptype.is_a? Symbol
            rbtype = AllDefinitions[ptype] || Classes[ptype]
            unless rbtype
              raise TypeError, "unknown TL type reference #{ptype} on #{type.inspect}"
            end
            prop.type = rbtype
          end
          prop.freeze
        end
      end

    end

    private

    def parse_typename(name)
      type, subtype = name.split("<", 2)
      type = type.intern
      rbtype = BuiltinTypes[type] || Types[type] || Classes[type] || LazyResolver.new(type)
      if subtype
        subtype.chop!
        if subtype[-1] == ">"
          subtype = parse_typename(subtype)
        else
          subtype = subtype.intern
          if subtype == :PageBlock
            nil
          end
          subtype = BuiltinTypes[subtype] || Types[subtype] || Classes[subtype] || LazyResolver.new(subtype)
        end
        rbtype = rbtype[subtype]
      end
      rbtype
    end


    TL_RE = /^((?:`[+-]`)|[a-zA-Z][a-zA-Z0-9]*)\s+(.*)\s*=\s*(\S(?:.*\S)?)\s*;$/
    def parse_line(line, current, comments)
      md = TL_RE.match(line)
      return unless md
      typename = md[1].intern
      return BuiltinTypes[typename] if BuiltinTypes.key?(typename)
      info = Type.new
      info.name = typename.to_s.sub(/\A[a-z]/, &:upcase)
      info.realname = typename
      info.type = current
      info.source = line
      info.tl_class = md[3].intern

      stripped_comment = comments.map {|s| s.sub(%r(\A//), '').strip }.join(' ')
      comment_components = stripped_comment.scan(/@[^@]+/).each(&:strip!).map do |x|
        result = x.split(' ',2)
        result[0] = result[0][1..-1].intern
        result
      end

      if info.name != info.tl_class.to_s && info.type != :function
        unless Classes[info.tl_class]
          # STDERR.puts("Creating TL class #{info.tl_class}")
          tlc = TLClass.new
          tlc.name = info.tl_class
          Classes[info.tl_class] = tlc
        end
      else
        info.tl_class = "TLObject" if info.type != :function
      end

      if (index = comment_components.index{|x| x[0] == :class})
        comment_components.delete_at(index)
        class_desc = comment_components[index]
        if class_desc
          if class_desc[0] == :description
            comment_components.delete_at(index)
            Classes[info.tl_class].comment = class_desc[1] 
          end
        end
      end


      info.comment = comment_components.find{|x|x[0] == :description}&.fetch(1)
    
      props = md[2].split(' ')
      props.map! do |x|
        result = x.split(':')
        propname = result[0].intern
        capname = result[0].split('_').each(&:capitalize!).join
        proptype = parse_typename(result[1])
        comment = comment_components.find{|x|x[0] == propname}&.fetch(1)
        Property.new(propname, capname, proptype, comment)
      end
      info.props = props.freeze


      (current == :function ? Functions : Types)[typename] = info

      info
    # rescue
    #   raise TypeError, "error parsing TL: #{line.inspect}"
    end

  end


end
