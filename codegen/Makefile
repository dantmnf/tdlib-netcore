# NMAKE-compatible

ALL: ../TDLib/Api/Generated/TypesDefinition.cs ../TDLib/Api/Generated/ClientExtension.cs ../TDLib/Api/Generated/CxxBridge.cs ../TDLib.Native/tlobject.cxx ../TDLib/Api/Generated/Constructor.cs

COMMON: td_api.tl common.rb parser.rb

../TDLib/Api/Generated/TypesDefinition.cs: COMMON gentypes.rb
	ruby gentypes.rb > ../TDLib/Api/Generated/TypesDefinition.cs

../TDLib/Api/Generated/ClientExtension.cs: COMMON genext.rb
	ruby genext.rb > ../TDLib/Api/Generated/ClientExtension.cs

../TDLib/Api/Generated/CxxBridge.cs: COMMON gencxxbridge.rb
	ruby gencxxbridge.rb > ../TDLib/Api/Generated/CxxBridge.cs

../TDLib.Native/tlobject.cxx: COMMON gencxxobjects.rb
	ruby gencxxobjects.rb > ../TDLib.Native/tlobject.cxx

../TDLib/Api/Generated/Constructor.cs: COMMON genctor.rb
	ruby genctor.rb > ../TDLib/Api/Generated/Constructor.cs
