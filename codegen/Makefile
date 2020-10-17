# NMAKE-compatible

ALL: ../TDLib/Generated/TypesDefinition.cs \
     ../TDLib/Generated/ClientExtension.cs \
     ../TDLib.NativeClient/Generated/CxxBridge.cs \
     ../TDLib.NativeClient.Bridge/tlobject.cxx \
     ../TDLib/Generated/Constructor.cs \
     ../TDLib.JsonClient/Generated/ObjectReader.cs \
     ../TDLib.JsonClient/Generated/ObjectWriter.cs

COMMON=../td/td/generate/scheme/td_api.tl common.rb parser.rb

../TDLib/Generated/TypesDefinition.cs: $(COMMON) gentypes.rb
	ruby gentypes.rb ../td/td/generate/scheme/td_api.tl ../TDLib/Generated/TypesDefinition.cs

../TDLib/Generated/ClientExtension.cs: $(COMMON) genext.rb
	ruby genext.rb ../td/td/generate/scheme/td_api.tl ../TDLib/Generated/ClientExtension.cs

../TDLib/Generated/Constructor.cs: $(COMMON) genctor.rb
	ruby genctor.rb ../td/td/generate/scheme/td_api.tl ../TDLib/Generated/Constructor.cs

../TDLib.NativeClient/Generated/CxxBridge.cs: $(COMMON) gencxxbridge.rb
	ruby gencxxbridge.rb ../td/td/generate/scheme/td_api.tl ../TDLib.NativeClient/Generated/CxxBridge.cs

../TDLib.NativeClient.Bridge/tlobject.cxx: $(COMMON) gencxxobjects.rb
	ruby gencxxobjects.rb ../td/td/generate/scheme/td_api.tl ../TDLib.NativeClient.Bridge/tlobject.cxx

../TDLib.JsonClient/Generated/ObjectReader.cs: $(COMMON) genreader.rb
	ruby genreader.rb ../td/td/generate/scheme/td_api.tl ../TDLib.JsonClient/Generated/ObjectReader.cs

../TDLib.JsonClient/Generated/ObjectWriter.cs: $(COMMON) genwriter.rb
	ruby genwriter.rb ../td/td/generate/scheme/td_api.tl ../TDLib.JsonClient/Generated/ObjectWriter.cs
