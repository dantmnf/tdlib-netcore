require_relative 'common'
require 'zlib'

class StringPool
  PoolItemInfo = Struct.new(:offset, :length)
  def initialize(align = 0)
    @buf = StringIO.new
    @hash = {}
    @align = align
  end
  def add(str)
    return @hash[str] if @hash.key?(str)
    offset = @buf.length
    length = str.length
    @buf.write(str)
    if @align != 0 && @buf.length % @align != 0
      @buf.write(' '*(-(@buf.length % -@align)))
    end
    info = PoolItemInfo.new(offset, length)
    @hash[str] = info
    info
  end

  def pool
    @buf.string
  end
end

def emit_type(io, pool, type)
  io.puts "public partial class #{check_csharp_keyword type.name}"
  io.puts "{"
  io.block do
    io.puts "internal override void TdJsonWrite(TdJsonWriter writer)"
    io.puts "{"
    io.block do
      str = %Q[{"@type":"#{type.realname}"]
      poolitem = pool.add(str)
      io.puts "writer.WriteSpan(StringPool.Slice(#{poolitem.offset}, #{poolitem.length})); // #{str}"

      type.props.each do |prop|

        propname = prop.name
        if propname == type.name
          propname = "#{propname}_"
        end
        csname = check_csharp_keyword propname
        str = %Q{,"#{prop.name}":}
        poolitem = pool.add(str)

        case 
        when prop.type == "byte[]"
          io.puts "if (this.#{csname} != null)"
          io.puts "{"
          io.block do
            io.puts "writer.WriteSpan(StringPool.Slice(#{poolitem.offset}, #{poolitem.length})); // #{str}"
            io.puts "writer.WriteBytesValue(this.#{csname});"
          end
          io.puts "}"
        when prop.type.is_a?(String) # other primitive type
          io.puts "writer.WriteSpan(StringPool.Slice(#{poolitem.offset}, #{poolitem.length})); // #{str}"
          io.puts "writer.WriteValue(this.#{csname});"
        when prop.type == TDLibTLTypeInfo::Int64
          io.puts "writer.WriteSpan(StringPool.Slice(#{poolitem.offset}, #{poolitem.length})); // #{str}"
          io.puts "writer.WriteInt64String(this.#{csname});"
        when prop.type == TDLibTLTypeInfo::Vector[TDLibTLTypeInfo::Int64]
          io.puts "if (this.#{csname} != null)"
          io.puts "{"
          io.block do
            io.puts "writer.WriteSpan(StringPool.Slice(#{poolitem.offset}, #{poolitem.length})); // #{str}"
            io.puts "writer.WriteInt64Array(this.#{csname});"
          end
          io.puts "}"
        when prop.type.is_a?(Class) && prop.type <= TDLibTLTypeInfo::Vector
          io.puts "if (this.#{csname} != null)"
          io.puts "{"
          io.block do
            io.puts "writer.WriteSpan(StringPool.Slice(#{poolitem.offset}, #{poolitem.length})); // #{str}"
            io.puts "writer.WriteArray(this.#{csname});"
          end
          io.puts "}"
        else
          io.puts "if (this.#{csname} != null)"
          io.puts "{"
          io.block do
            io.puts "writer.WriteSpan(StringPool.Slice(#{poolitem.offset}, #{poolitem.length})); // #{str}"
            io.puts "writer.WriteValue(this.#{csname});"
          end
          io.puts "}"
        end
      end
      io.puts "TdJsonWriteExtra(writer);"
      io.puts "writer.WriteEndObject();"

    end
    io.puts "}"
  end
  io.puts "}"
  io.puts ""
end

def emit(out=STDOUT)
  io = IndentedOutput.new(out)
  io.puts "using System;"
  io.puts ""
  io.puts "//////////////////////////////////////"
  io.puts "//// GENERATED FILE! DO NOT EDIT! ////"
  io.puts "//////////////////////////////////////"
  io.puts ""
  io.puts "namespace TDLib.Api.Types"
  io.puts "{"
  io.push

  pool = StringPool.new(8)



  io.puts "public partial class TLObject"
  io.puts "{"
  io.block do
    io.puts "internal void TdJsonWriteExtra(TdJsonWriter writer)"
    io.puts "{"
    io.block do
      extraitem = pool.add(%Q{,"@extra":})
      io.puts "if (this.Extra != null)"
      io.puts "{"
      io.block do
        io.puts "writer.WriteSpan(StringPool.Slice(#{extraitem.offset}, #{extraitem.length})); // ,\"@extra\":"
        io.puts "writer.WriteValue(this.Extra);"
      end
      io.puts "}"
    end
    io.puts "}"
  end
  io.puts "}"

  TDLibTLTypeInfo::Types.each_value do |type|
    emit_type(io, pool, type)
  end

  TDLibTLTypeInfo::Functions.each_value do |type|
    emit_type(io, pool, type)
  end

  crc = Zlib::crc32(pool.pool)

  io.puts "internal partial class StringPool"
  io.puts "{"
  io.block do
    io.puts "private const uint _poolcrc = #{'0x%08Xu' % crc};"
  end
  io.puts "}"
  io.puts ""

  io.pop
  io.puts "}"

  IO.write("pool.dat", pool.pool)
end

emit

