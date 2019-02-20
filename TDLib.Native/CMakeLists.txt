cmake_minimum_required(VERSION 3.1)
project(TDLib.Native CXX)

find_package(Td REQUIRED)

add_executable(checkdllhell checkdllhell.cxx)
target_link_libraries(checkdllhell tdbridge)


add_library(tdbridge SHARED client.cxx baseobject.cxx tlobject.cxx vector.cxx string.cxx log.cxx)
target_link_libraries(tdbridge PRIVATE Td::TdStatic)
set_property(TARGET tdbridge PROPERTY CXX_STANDARD 17)
