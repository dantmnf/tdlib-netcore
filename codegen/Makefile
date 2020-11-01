# NMAKE-compatible

TD_ROOT=../td

ALL: ../TDLibCore/Generated/TypesDefinition.cs \
     ../TDLibCore/Generated/ClientExtension.cs \
     ../TDLibCore.NativeClient/Generated/CxxBridge.cs \
     ../TDLibCore.NativeClient.Bridge/tlobject.cxx \
	 ../TDLibCore.NativeClient.Bridge/offsets.h \
     ../TDLibCore/Generated/Constructor.cs \
     ../TDLibCore.JsonClient/Generated/ObjectReader.cs \
     ../TDLibCore.JsonClient/Generated/ObjectWriter.cs \
	 ../tdlib_version.props

COMMON=$(TD_ROOT)/td/generate/scheme/td_api.tl common.rb parser.rb

../TDLibCore/Generated/TypesDefinition.cs: $(COMMON) gentypes.rb
	ruby gentypes.rb $(TD_ROOT)/td/generate/scheme/td_api.tl ../TDLibCore/Generated/TypesDefinition.cs

../TDLibCore/Generated/ClientExtension.cs: $(COMMON) genext.rb
	ruby genext.rb $(TD_ROOT)/td/generate/scheme/td_api.tl ../TDLibCore/Generated/ClientExtension.cs

../TDLibCore/Generated/Constructor.cs: $(COMMON) genctor.rb
	ruby genctor.rb $(TD_ROOT)/td/generate/scheme/td_api.tl ../TDLibCore/Generated/Constructor.cs

../TDLibCore.NativeClient/Generated/CxxBridge.cs: $(COMMON) gencxxbridge.rb
	ruby gencxxbridge.rb $(TD_ROOT)/td/generate/scheme/td_api.tl ../TDLibCore.NativeClient/Generated/CxxBridge.cs

../TDLibCore.NativeClient.Bridge/offsets.h: $(COMMON) gencxxoffsets.rb
	ruby gencxxoffsets.rb $(TD_ROOT)/td/generate/scheme/td_api.tl ../TDLibCore.NativeClient.Bridge/offsets.h ../TDLibCore.NativeClient/Generated/_MemberOffsetIndex.cs

../TDLibCore.NativeClient.Bridge/tlobject.cxx: $(COMMON) gencxxobjects.rb
	ruby gencxxobjects.rb $(TD_ROOT)/td/generate/scheme/td_api.tl ../TDLibCore.NativeClient.Bridge/tlobject.cxx

../TDLibCore.JsonClient/Generated/ObjectReader.cs: $(COMMON) genreader.rb
	ruby genreader.rb $(TD_ROOT)/td/generate/scheme/td_api.tl ../TDLibCore.JsonClient/Generated/ObjectReader.cs

../TDLibCore.JsonClient/Generated/ObjectWriter.cs: $(COMMON) genwriter.rb
	ruby genwriter.rb $(TD_ROOT)/td/generate/scheme/td_api.tl ../TDLibCore.JsonClient/Generated/ObjectWriter.cs

../tdlib_version.props: genversion.rb ../td/CMakeLists.txt $(TD_ROOT)/td/generate/scheme/td_api.tl
	ruby genversion.rb $(TD_ROOT) ../tdlib_version.props
