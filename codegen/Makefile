# NMAKE-compatible

ALL: ../TDLib/Generated/TypesDefinition.cs \
     ../TDLib/Generated/ClientExtension.cs \
     ../TDLib.CxxClient/Generated/CxxBridge.cs \
     ../TDLib.CxxClient.Native/tlobject.cxx \
     ../TDLib/Generated/Constructor.cs \
     ../TDLib.JsonClient/Generated/ObjectReader.cs \
     ../TDLib.JsonClient/Generated/ObjectWriter.cs

COMMON: td_api.tl common.rb parser.rb

../TDLib/Generated/TypesDefinition.cs: COMMON gentypes.rb
	ruby gentypes.rb ../TDLib/Generated/TypesDefinition.cs

../TDLib/Generated/ClientExtension.cs: COMMON genext.rb
	ruby genext.rb ../TDLib/Generated/ClientExtension.cs

../TDLib/Generated/Constructor.cs: COMMON genctor.rb
	ruby genctor.rb ../TDLib/Generated/Constructor.cs

../TDLib.CxxClient/Generated/CxxBridge.cs: COMMON gencxxbridge.rb
	ruby gencxxbridge.rb ../TDLib.CxxClient/Generated/CxxBridge.cs

../TDLib.CxxClient.Native/tlobject.cxx: COMMON gencxxobjects.rb
	ruby gencxxobjects.rb ../TDLib.CxxClient.Native/tlobject.cxx

../TDLib.JsonClient/Generated/ObjectReader.cs: COMMON genreader.rb
	ruby genreader.rb ../TDLib.JsonClient/Generated/ObjectReader.cs

../TDLib.JsonClient/Generated/ObjectWriter.cs: COMMON genwriter.rb
	ruby genwriter.rb ../TDLib.JsonClient/Generated/ObjectWriter.cs ../TDLib.JsonClient/Generated/pool.dat
