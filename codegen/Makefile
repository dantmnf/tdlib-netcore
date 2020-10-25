# NMAKE-compatible

TD_ROOT=../td

ALL: ../TDLib/Generated/TypesDefinition.cs \
     ../TDLib/Generated/ClientExtension.cs \
     ../TDLib.NativeClient/Generated/CxxBridge.cs \
     ../TDLib.NativeClient.Bridge/tlobject.cxx \
	 ../TDLib.NativeClient.Bridge/offsets.h \
     ../TDLib/Generated/Constructor.cs \
     ../TDLib.JsonClient/Generated/ObjectReader.cs \
     ../TDLib.JsonClient/Generated/ObjectWriter.cs \
	 ../tdlib_version.props

COMMON=$(TD_ROOT)/td/generate/scheme/td_api.tl common.rb parser.rb

../TDLib/Generated/TypesDefinition.cs: $(COMMON) gentypes.rb
	ruby gentypes.rb $(TD_ROOT)/td/generate/scheme/td_api.tl ../TDLib/Generated/TypesDefinition.cs

../TDLib/Generated/ClientExtension.cs: $(COMMON) genext.rb
	ruby genext.rb $(TD_ROOT)/td/generate/scheme/td_api.tl ../TDLib/Generated/ClientExtension.cs

../TDLib/Generated/Constructor.cs: $(COMMON) genctor.rb
	ruby genctor.rb $(TD_ROOT)/td/generate/scheme/td_api.tl ../TDLib/Generated/Constructor.cs

../TDLib.NativeClient/Generated/CxxBridge.cs: $(COMMON) gencxxbridge.rb
	ruby gencxxbridge.rb $(TD_ROOT)/td/generate/scheme/td_api.tl ../TDLib.NativeClient/Generated/CxxBridge.cs

../TDLib.NativeClient.Bridge/offsets.h: $(COMMON) gencxxoffsets.rb
	ruby gencxxoffsets.rb $(TD_ROOT)/td/generate/scheme/td_api.tl ../TDLib.NativeClient.Bridge/offsets.h ../TDLib.NativeClient/Generated/_MemberOffsetIndex.cs

../TDLib.NativeClient.Bridge/tlobject.cxx: $(COMMON) gencxxobjects.rb
	ruby gencxxobjects.rb $(TD_ROOT)/td/generate/scheme/td_api.tl ../TDLib.NativeClient.Bridge/tlobject.cxx

../TDLib.JsonClient/Generated/ObjectReader.cs: $(COMMON) genreader.rb
	ruby genreader.rb $(TD_ROOT)/td/generate/scheme/td_api.tl ../TDLib.JsonClient/Generated/ObjectReader.cs

../TDLib.JsonClient/Generated/ObjectWriter.cs: $(COMMON) genwriter.rb
	ruby genwriter.rb $(TD_ROOT)/td/generate/scheme/td_api.tl ../TDLib.JsonClient/Generated/ObjectWriter.cs

../tdlib_version.props: genversion.rb ../td/CMakeLists.txt $(TD_ROOT)/td/generate/scheme/td_api.tl
	ruby genversion.rb $(TD_ROOT) ../tdlib_version.props
