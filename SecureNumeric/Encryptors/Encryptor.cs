using System;

namespace SecureNumeric.Encryptors
{
	abstract class Encryptor
	{
		#region Byte

		public abstract byte Encrypt(byte value);
		public abstract sbyte Encrypt(sbyte value);

		public abstract byte Decrypt(byte value);
		public abstract sbyte Decrypt(sbyte value);

		#endregion

		#region Int16

		public abstract ushort Encrypt(ushort value);
		public abstract short Encrypt(short value);

		public abstract ushort Decrypt(ushort value);
		public abstract short Decrypt(short value);

		#endregion

		#region Int32

		public abstract uint Encrypt(uint value);
		public abstract int Encrypt(int value);

		public abstract uint Decrypt(uint value);
		public abstract int Decrypt(int value);

		#endregion

		#region Int64

		public abstract ulong Encrypt(ulong value);
		public abstract long Encrypt(long value);

		public abstract ulong Decrypt(ulong value);
		public abstract long Decrypt(long value);

		#endregion
	}
}