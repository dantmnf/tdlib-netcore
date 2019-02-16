require 'zlib'
require_relative 'common'

def hashof(name)
  sprintf("0x%08Xu", Zlib.crc32(name.to_s))
end

def readerof(type)
  case
  when type == "string"
    "reader.ReadStringAsUTF16String()"
  when type == "bool"
    "reader.ReadBool()"
  when type == "int"
    "reader.ReadInt()"
  when type == "long"
    "reader.ReadLong()"
  when type == "double"
    "reader.ReadDouble()"
  when type == "bool"
    "(bool)reader.ReadValue()"
  when type == "byte[]"
    "reader.ReadBase64String()"
  when type.is_a?(Class) && type == TDLibTLTypeInfo::Int64
    "reader.ReadIntegerString()"
  when type.is_a?(Class) && type <= TDLibTLTypeInfo::Vector
    st, level = type.nestinfo
    case level
    when 1
      st == 'byte[]' ? "reader.ReadBytesArray()" : "reader.ReadArray<#{st.to_s}>()"
    when 2
      "reader.ReadNestedArray<#{st.to_s}>()"
    else
      raise NotImplementedError
    end
  else
    "(#{type})reader.ReadValue()"
  end
end

def emit_type(io, type)
  hashes = type.props.map{|x|hashof(x.name)}
  uniqhashes = hashes.uniq
  if hashes.length != uniqhashes.length
    STDERR.puts "WARNING: hash collision found in type #{type.name}"
  end
  io.puts %Q{[TLTypeHash(#{hashof(type.realname)})]}
  if type.props.empty?
    io.puts "public partial class #{check_csharp_keyword type.name} { }"
    return
  end
  io.puts "public partial class #{check_csharp_keyword type.name}"
  io.puts "{"
  io.push
  io.puts "internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)"
  io.puts "{"
  io.block do
    io.puts "if (base.TdJsonReadItem(ref reader, hash)) return true;"
    io.puts "switch (hash)"
    io.puts "{"
    io.block do
      type.props.each do |prop|
        proptype = check_csharp_keyword prop.type.to_s
        propname = prop.name
        csname = propname
        if csname == type.name
          csname = "#{csname}_"
        end
        csname = check_csharp_keyword csname
        io.puts "case #{hashof(propname)}:"
        io.block do
          io.puts "this.#{csname} = " + readerof(prop.type) + ";"
          io.puts "return true;"
        end
      end

    end
    io.puts "}"
    io.puts "return false;"

  end
  io.puts "}"
  io.pop
  io.puts "}"
  io.puts ""
end

def emit(out=STDOUT)
  io = IndentedOutput.new(out)
  io.puts "using System;"
  io.puts "using Newtonsoft.Json;"
  io.puts ""
  io.puts "//////////////////////////////////////"
  io.puts "//// GENERATED FILE! DO NOT EDIT! ////"
  io.puts "//////////////////////////////////////"
  io.puts ""
  io.puts "namespace TDLib.Api.Types"
  io.puts "{"
  io.push
  
  TDLibTLTypeInfo::Types.each_value do |type|
    emit_type(io, type)
  end

  TDLibTLTypeInfo::Functions.each_value do |type|
    emit_type(io, type)
  end
  io.pop
  io.puts "}"
end

emit

