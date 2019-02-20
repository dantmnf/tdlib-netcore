require_relative 'common'

def emit_type(io, type)

  realname = type.realname
  io.puts "EXPORT #{realname} *td_bridge_newobj_#{realname}() { return new #{realname}(); }"
  type.props.each do |prop|
    io.puts "EXPORT auto td_bridge_obj_#{realname}_#{prop.name}(#{realname} *obj) { return &obj->#{prop.name}_; }"
  end
  io.puts ""
end

def emit(out=STDOUT)
  io = IndentedOutput.new(out)
  io.puts '#include "tdcxxbridge.h"'
  io.puts ""
  io.puts "//////////////////////////////////////"
  io.puts "//// GENERATED FILE! DO NOT EDIT! ////"
  io.puts "//////////////////////////////////////"
  io.puts ""
  io.puts "using namespace td::td_api;"
  io.puts ""


  TDLibTLTypeInfo::Types.each_value do |type|
    emit_type(io, type)
  end

  TDLibTLTypeInfo::Functions.each_value do |type|
    emit_type(io, type)
  end
end

emit

