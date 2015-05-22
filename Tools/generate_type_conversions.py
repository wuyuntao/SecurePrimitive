# -*- coding: UTF-8 -*-

from os import path

SPTYPE_MAPPINGS = (
	('SPSByte', 'sbyte'),
	('SPByte', 'byte'),
	('SPInt16', 'short'),
	('SPUInt16', 'ushort'),
	('SPInt32', 'int'),
	('SPUInt32', 'uint'),
	('SPInt64', 'long'),
	('SPUInt64', 'ulong'),
)

TYPE_CONVERSION_DIR = path.join(path.dirname(path.realpath(__file__)), '../SecurePrimitive/Types/Conversions/')

TYPE_CONVERSION_HEADER = '''// This file is auto generatored. Don't modify it.
using System;

namespace SecurePrimitive
{
	public partial struct %s
	{'''

TYPE_CONVERSION_FOOTER = '''	}
}
'''

IMPLICIT_TYPE_CONVERSION = '''
		#region %(from_sptype)s <-> %(to_cstype)s
		
		public static implicit operator %(from_sptype)s(%(to_cstype)s value)
		{
			return new %(from_sptype)s( value );
		}

		public static implicit operator %(to_cstype)s(%(from_sptype)s value)
		{
			return value.Value;
		}

		#endregion
'''

EXPLICIT_TYPE_CONVERSION = '''
		#region %(from_sptype)s <-> %(to_sptype)s
		
		public static explicit operator %(from_sptype)s(%(to_sptype)s value)
		{
			return new %(from_sptype)s( (%(from_cstype)s)value.Value );
		}

		public static explicit operator %(to_sptype)s(%(from_sptype)s value)
		{
			return new %(to_sptype)s( (%(to_cstype)s)value.Value );
		}

		#endregion

		#region %(from_sptype)s <-> %(to_cstype)s
		
		public static explicit operator %(from_sptype)s(%(to_cstype)s value)
		{
			return new %(from_sptype)s( (%(from_cstype)s)value );
		}

		public static explicit operator %(to_cstype)s(%(from_sptype)s value)
		{
			return (%(to_cstype)s)value.Value;
		}

		#endregion
'''

def find_cstype(sptype):
	for spty, csty in SPTYPE_MAPPINGS:
		 if spty == sptype:
		 	return csty

	raise Exception('Invalid sptype')

def generate_sptype_conversion(from_sptype):
	code = ''

	for to_sptype, to_cstype in SPTYPE_MAPPINGS:
		code_values = {
			'from_sptype': from_sptype,
			'from_cstype': find_cstype(from_sptype),
			'to_sptype': to_sptype,
			'to_cstype': to_cstype,
		}

		if from_sptype == to_sptype:
			code += IMPLICIT_TYPE_CONVERSION % code_values
		else:
			code += EXPLICIT_TYPE_CONVERSION % code_values
	
	return code

def generate_sptype_extra_helpers(from_sptype):
	filename = '%s.Conversion.cs' % from_sptype
	filepath = path.join(TYPE_CONVERSION_DIR, filename)

	code = TYPE_CONVERSION_HEADER % from_sptype
	code += generate_sptype_conversion(from_sptype)
	code += TYPE_CONVERSION_FOOTER

	f = open(filepath, 'w')
	f.write(code)
	f.close()

def main():
	for sptype, cptype in SPTYPE_MAPPINGS:
		generate_sptype_extra_helpers( sptype )

if __name__ == '__main__':
	main()