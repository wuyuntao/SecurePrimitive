using SecureNumeric.Encryptors;
using System.Collections.Generic;

namespace SecureNumeric
{
	public static class SecureNumericConfiguration
	{
		internal static Encryptor GeneratorEncryptor()
		{
			return new BitOffsetEncryptor();
		}
	}
}