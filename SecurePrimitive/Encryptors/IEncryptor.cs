using System;

namespace SecurePrimitive.Encryptors
{
    interface IEncryptor
    {
        #region Byte

        byte Encrypt(byte value);
        sbyte Encrypt(sbyte value);

        byte Decrypt(byte value);
        sbyte Decrypt(sbyte value);

        #endregion

        #region Int16

        ushort Encrypt(ushort value);
        short Encrypt(short value);

        ushort Decrypt(ushort value);
        short Decrypt(short value);

        #endregion

        #region Int32

        uint Encrypt(uint value);
        int Encrypt(int value);

        uint Decrypt(uint value);
        int Decrypt(int value);

        #endregion

        #region Int64

        ulong Encrypt(ulong value);
        long Encrypt(long value);

        ulong Decrypt(ulong value);
        long Decrypt(long value);

        #endregion
    }
}