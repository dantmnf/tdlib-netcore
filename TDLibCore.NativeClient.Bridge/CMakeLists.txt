cmake_minimum_required(VERSION 3.1)
project(TDLibCore.NativeClient.Native CXX)

if(DEFINED USE_TD_SOURCE_TREE)
	add_subdirectory(${USE_TD_SOURCE_TREE} ${TD_BUILD_BINARY_DIR})
else()
	find_package(Td REQUIRED)
endif()

if(WIN32)
	add_executable(checkdllhell checkdllhell.cxx)
	target_link_libraries(checkdllhell TDLibCore.NativeClient.Native)
endif()

set(CMAKE_POSITION_INDEPENDENT_CODE ON)
add_library(TDLibCore.NativeClient.Native SHARED client.cxx baseobject.cxx tlobject.cxx vector.cxx string.cxx log.cxx offsets.cpp)
target_link_libraries(TDLibCore.NativeClient.Native PRIVATE Td::TdStatic)
set_property(TARGET TDLibCore.NativeClient.Native PROPERTY CXX_STANDARD 17)
