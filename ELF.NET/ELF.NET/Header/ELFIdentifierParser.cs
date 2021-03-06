﻿/* The MIT License (MIT)

Copyright (c) 2016 Tom Needham

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELF.NET.FSharp.ELF_Types;
using static ELF.NET.Header.EnumELFIdentifierBytes;

namespace ELF.NET.Header
{
    public class ELFIdentifierParser
    {
        private ELF32_char[] identifier;
        private char[] magic = new char[]{(char)0x7f, 'E', 'L', 'F'};

        public ELFIdentifierParser(ELF32_char[] identifier)
        {
            this.identifier = identifier;
        }

        public bool CheckMagic()
        {
            return identifier[(int)EI_MAG0].value.Equals((byte) magic[(int) EI_MAG0]) &&
                   identifier[(int)EI_MAG1].value.Equals((byte) magic[(int)EI_MAG1]) &&
                   identifier[(int)EI_MAG2].value.Equals((byte) magic[(int)EI_MAG2]) &&
                   identifier[(int)EI_MAG3].value.Equals((byte) magic[(int)EI_MAG3]);
        }

        public EnumELFFileClass GetFileClass()
        {
            ushort Class = identifier[(int) EI_CLASS].value;
            return (EnumELFFileClass) Class;
        }

        public EnumELFDataEncoding GetDataEncoding()
        {
            ushort encoding = identifier[(int) EI_DATA].value;
            return (EnumELFDataEncoding) encoding;
        }

        public EnumELFVersion GetFileVersion()
        {
            ushort version = identifier[(int) EI_VERSION].value;
            return (EnumELFVersion) version;
        }

        public int GetIdentifierSize()
        {
            return identifier.Length;
        }
    }
}
