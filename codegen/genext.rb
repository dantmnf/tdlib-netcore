require_relative 'common'


DefaultValue = {
  "int" => "0",
  "long" => "0",
  "double" => "0.0",
  "bool" => "false",
}
DefaultValue.default = "null"

def emit_function(io, type)
  return unless type.type == :function
  if type.comment && !type.comment.empty?
    io.puts "/// <summary>"
    io.puts "/// " + type.comment.encode(xml: :text)
    io.puts "/// </summary>"
  end
  type.props.each do |prop|
    unless prop.comment.empty?
      io.puts "/// <param name=#{prop.name.to_s.encode(xml: :attr)}>" + prop.comment.encode(xml: :text) + "</param>"
    end
  end

  props = type.props.map do |prop|
    proptype = prop.type.to_s
    propname = prop.name
    if propname == type.name
      propname = "#{propname}_"
    end
    [check_csharp_keyword(proptype), check_csharp_keyword(propname)]
  end

  arglist = props.map do |type, name|
    "#{type} #{name} = #{DefaultValue[type]}"
  end
  arglist.unshift "this Client client"

  io.puts "public static async Task<#{check_csharp_keyword type.tl_class}> #{check_csharp_keyword type.name}(#{arglist.join(", ")})"
  io.puts "{"
  io.push

  if props.empty?
    io.puts "var obj = new #{check_csharp_keyword type.name}();"
  else
    io.puts "var obj = new #{check_csharp_keyword type.name}"
    io.puts "{"
    io.push
    props.each do |type, name|
      io.puts "#{name} = #{name},"
    end
    io.pop
    io.puts "};"
  end

  io.puts "return await client.InvokeAsync(obj);"

  io.pop
  io.puts "}"
  io.puts ""
end

def emit(out=STDOUT)
  io = IndentedOutput.new(out)
  io.puts "using System;"
  io.puts "using System.Threading.Tasks;"
  io.puts "using TDLib;"
  io.puts "using TDLib.Api.Types;"
  io.puts ""
  io.puts "//////////////////////////////////////"
  io.puts "//// GENERATED FILE! DO NOT EDIT! ////"
  io.puts "//////////////////////////////////////"
  io.puts ""
  io.puts "namespace TDLib.ClientExtensions"
  io.puts "{"
  io.push
  io.puts "public static partial class ClientExtensions"
  io.puts "{"
  io.push
  TDLibTLTypeInfo::Functions.each_value do |type|
    emit_function(io, type)
  end
  io.pop
  io.puts "}"
  io.pop
  io.puts "}"
end

emit
