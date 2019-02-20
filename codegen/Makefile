# NMAKE-compatible

ALL: ../TDLib/Api/Types/Generated/TypesDefinition.cs ../TDLib/Api/Types/Generated/ClientExtension.cs ../TDLib/Api/Types/Generated/CxxBridge.cs ../TDLib.Native/tlobject.cxx

COMMON: td_api.tl common.rb parser.rb

../TDLib/Api/Types/Generated/TypesDefinition.cs: COMMON gentypes.rb
	ruby gentypes.rb > ../TDLib/Api/Types/Generated/TypesDefinition.cs

../TDLib/Api/Types/Generated/ClientExtension.cs: COMMON genext.rb
	ruby genext.rb > ../TDLib/Api/Types/Generated/ClientExtension.cs

../TDLib/Api/Types/Generated/CxxBridge.cs: COMMON gencxxbridge.rb
	ruby gencxxbridge.rb > ../TDLib/Api/Types/Generated/CxxBridge.cs

../TDLib.Native/tlobject.cxx: COMMON gencxxobjects.rb
	ruby gencxxobjects.rb > ../TDLib.Native/tlobject.cxx
