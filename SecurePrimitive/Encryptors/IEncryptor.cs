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