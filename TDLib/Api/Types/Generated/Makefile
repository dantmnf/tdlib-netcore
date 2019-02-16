# NMAKE-compatible

ALL: TypesDefinition.cs ClientExtension.cs ObjectReader.cs ObjectWriter.cs pool.dat

TypesDefinition.cs: COMMON gentypes.rb
	ruby gentypes.rb > TypesDefinition.cs

ClientExtension.cs: COMMON genext.rb
	ruby genext.rb > ClientExtension.cs

ObjectWriter.cs: COMMON genwriter.rb
	ruby genwriter.rb > ObjectWriter.cs

ObjectReader.cs: COMMON genreader.rb
	ruby genreader.rb > ObjectReader.cs

pool.dat: ObjectWriter.cs

COMMON: td_api.tl common.rb parser.rb
