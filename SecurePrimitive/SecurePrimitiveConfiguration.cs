using SecurePrimitive.Encryptors;
using System.Collections.Generic;

namespace SecurePrimitive
{
    public static class SecurePrimitiveConfiguration
    {
        internal static IEncryptor GeneratorEncryptor()
        {
            return new BitOffsetEncryptor();
        }
    }
}