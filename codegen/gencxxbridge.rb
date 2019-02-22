require_relative 'common'

def pinvoketype(type)
  case
  when type == "string"
    "CxxString"
  when type == "bool"
    "CxxBool"
  when type == "int"
    "CxxInt32"
  when type == "long"
    "CxxInt64"
  when type == "double"
    "CxxFloat64"
  when type == "byte[]"
    "CxxBytes"
  when type.is_a?(Class) && type == TDLibTLTypeInfo::Int64
    "CxxInt64"
  when type == TDLibTLTypeInfo::Vector["int"]
    "CxxVectorInt32"
  when type == TDLibTLTypeInfo::Vector["long"]
    "CxxVectorInt64"
  when type == TDLibTLTypeInfo::Vector[TDLibTLTypeInfo::Int64]
    "CxxVectorInt64"
  when type == TDLibTLTypeInfo::Vector["byte[]"]
    "CxxVectorBytes"
  when type == TDLibTLTypeInfo::Vector["string"]
    "CxxVectorString"
  when type.is_a?(Class) && type <= TDLibTLTypeInfo::Vector
    st, level = type.nestinfo
    case level
    when 1
      "CxxVectorObject<#{st.to_s}>"
    when 2
      "CxxVectorVectorObject<#{st.to_s}>"
    else
      raise NotImplementedError
    end
  else
    "CxxTLObject<#{type}>"
  end
end

def emit_type(io, type)
  io.puts "[TLTypeID(#{type.type_id})]"
  io.puts "public unsafe partial class #{check_csharp_keyword type.name}"
  io.puts "{"
  io.block do

    supsec = "[SuppressUnmanagedCodeSecurity]"
    dllimport = '[DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]'
    io.puts supsec
    io.puts dllimport
    io.puts "private static extern IntPtr td_bridge_newobj_#{type.realname}();"
    type.props.each do |prop|
      io.puts supsec
      io.puts dllimport
      wraptype = pinvoketype(prop.type)
      pitype = wraptype.include?('<') ? 'IntPtr' : wraptype
      io.puts "private static extern #{pitype} td_bridge_obj_#{type.realname}_#{prop.name}(IntPtr obj);"
    end

    io.puts "internal override IntPtr TdCreateCxxObject()"
    io.puts "{"
    io.block do
      io.puts "var obj = td_bridge_newobj_#{type.realname}();"
      type.props.each do |prop|
        propname = prop.capname
        if propname == type.name
          propname = "#{propname}_"
        end
        csname = check_csharp_keyword propname
        wraptype = pinvoketype(prop.type)
        if wraptype.include?('<')
          io.puts "new #{wraptype}(td_bridge_obj_#{type.realname}_#{prop.name}(obj)).Set(this.#{csname});"
        else
          io.puts "td_bridge_obj_#{type.realname}_#{prop.name}(obj).Set(this.#{csname});"
        end
      end
      io.puts "return obj;"
    end
    io.puts "}"

    
    io.puts "internal override void TdFetchCxxObject(IntPtr obj)"
    io.puts "{"
    io.block do
      type.props.each do |prop|
        propname = prop.capname
        if propname == type.name
          propname = "#{propname}_"
        end
        csname = check_csharp_keyword propname
        wraptype = pinvoketype(prop.type)
        if wraptype.include?('<')
          io.puts "this.#{csname} = new #{wraptype}(td_bridge_obj_#{type.realname}_#{prop.name}(obj)).Fetch();"
        else
          io.puts "this.#{csname} = td_bridge_obj_#{type.realname}_#{prop.name}(obj).Fetch();"
        end
        
      end
    end
    io.puts "}"
  end
  io.puts "}"
  io.puts ""
end

def emit(out=STDOUT)
  io = IndentedOutput.new(out)
  io.puts "using System;"
  io.puts "using System.Security;"
  io.puts "using System.Runtime.InteropServices;"
  io.puts "using TDLib.Api.Types.CxxInterop;"
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

