require_relative 'common'

def emit_type(io, type)
  if type.comment && !type.comment.empty?
    io.puts "/// <summary>"
    io.puts "/// " + type.comment.encode(xml: :text)
    io.puts "/// </summary>"
    
    io.puts "/// <remarks>"
    io.puts "/// TL source:"
    io.puts "/// " + type.source.encode(xml: :text)
    io.puts "/// </remarks>"
  end
  # io.puts %Q{[TLType("#{type.realname}")]}
  if type.type == :function
    io.puts "public partial class #{check_csharp_keyword type.name} : Function<#{check_csharp_keyword type.tl_class}>"
  else
    io.puts "public partial class #{check_csharp_keyword type.name} : #{check_csharp_keyword type.tl_class}"
  end
  io.puts "{"
  io.push
  # io.puts "internal override string TLType => " + type.realname.to_s.inspect + ";"
  # io.puts ""
  type.props.each do |prop|
    unless prop.comment.empty?
      io.puts "/// <summary>"
      io.puts "/// " + prop.comment.encode(xml: :text)
      io.puts "/// </summary>"
    end

    proptype = prop.type.to_s
    propname = prop.capname
    if propname == type.name
      propname = "#{propname}_"
    end
    io.puts "public #{check_csharp_keyword proptype} #{check_csharp_keyword propname} { get; set; }"
    io.puts ""
  end
  io.pop
  io.puts "}"
  io.puts ""
end

def emit(out=STDOUT)
  io = IndentedOutput.new(out)
  io.puts "using System;"
  # io.puts "using Newtonsoft.Json;"
  io.puts ""
  io.puts "//////////////////////////////////////"
  io.puts "//// GENERATED FILE! DO NOT EDIT! ////"
  io.puts "//////////////////////////////////////"
  io.puts ""
  io.puts "namespace TDLib.Api.Types"
  io.puts "{"
  io.push

  TDLibTLTypeInfo::Classes.each_value do |cls|
    if cls.comment && !cls.comment.empty?
      io.puts "/// <summary>"
      io.puts "/// " + cls.comment.encode(xml: :text)
      io.puts "/// </summary>"
    end
    io.puts "public abstract class #{check_csharp_keyword cls.name} : TLObject { }"
    io.puts ""
  end

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

