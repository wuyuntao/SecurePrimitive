/*
 * The MIT License (MIT)
 * 
 * Copyright (c) 2015 Wu Yuntao
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
*/

using System;

namespace SecurePrimitive.Encryptors
{
    class BitOffsetEncryptor : IEncryptor
    {
        private static readonly Random random = new Random();

        private byte offset;

        #region Byte

        public byte Encrypt(byte value)
        {
            offset = GetRandomBitOffset(8);

            var higher = (byte)(value << offset);
            var lower = (byte)(value >> (8 - offset));

            return (byte)(higher | lower);
        }

        public sbyte Encrypt(sbyte value)
        {
            return (sbyte)Encrypt((byte)value);
        }

        public byte Decrypt(byte value)
        {
            var higher = (byte)(value >> offset);
            var lower = (byte)(value << (8 - offset));

            return (byte)(higher | lower);
        }

        public sbyte Decrypt(sbyte value)
        {
            return (sbyte)Decrypt((byte)value);
        }

        #endregion

        #region Int16

        public ushort Encrypt(ushort value)
        {
            offset = GetRandomBitOffset(16);

            var higher = (ushort)(value << offset);
            var lower = (ushort)(value >> (16 - offset));

            return (ushort)(higher | lower);
        }

        public short Encrypt(short value)
        {
            return (short)Encrypt((ushort)value);
        }

        public ushort Decrypt(ushort value)
        {
            var higher = (ushort)(value >> offset);
            var lower = (ushort)(value << (16 - offset));

            return (ushort)(higher | lower);
        }

        public short Decrypt(short value)
        {
            return (short)Decrypt((ushort)value);
        }

        #endregion

        #region Int32

        public uint Encrypt(uint value)
        {
            offset = GetRandomBitOffset(32);

            var higher = (uint)(value << offset);
            var lower = (uint)(value >> (32 - offset));

            return (uint)(higher | lower);
        }

        public int Encrypt(int value)
        {
            return (int)Encrypt((uint)value);
        }

        public uint Decrypt(uint value)
        {
            var higher = (uint)(value >> offset);
            var lower = (uint)(value << (32 - offset));

            return (uint)(higher | lower);
        }

        public int Decrypt(int value)
        {
            return (int)Decrypt((uint)value);
        }

        #endregion

        #region Int64

        public ulong Encrypt(ulong value)
        {
            offset = GetRandomBitOffset(64);

            var higher = (ulong)(value << offset);
            var lower = (ulong)(value >> (64 - offset));

            return (ulong)(higher | lower);
        }

        public long Encrypt(long value)
        {
            return (long)Encrypt((ulong)value);
        }

        public ulong Decrypt(ulong value)
        {
            var higher = (ulong)(value >> offset);
            var lower = (ulong)(value << (64 - offset));

            return (ulong)(higher | lower);
        }

        public long Decrypt(long value)
        {
            return (long)Decrypt((ulong)value);
        }

        #endregion

        #region Helper

        private byte GetRandomBitOffset(byte maxValue)
        {
            return (byte)random.Next(1, maxValue);		// Zero is not allowed to be offset value
        }

        #endregion
    }
}