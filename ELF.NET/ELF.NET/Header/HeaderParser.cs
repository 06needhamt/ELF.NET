/* The MIT License (MIT)

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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELF_Types;


namespace ELF.NET.Header
{
    public class HeaderParser
    {
        private byte[] buffer;
        private ELF32_header head;
        private FileStream stream;
        public HeaderParser(string[] args)
        {
            buffer = new byte[8];
            head = new ELF32_header();
            stream = File.OpenRead(args[0]);   
        }

        public ELF32_header ParseHeader()
        {
            head.e_ident = new ELF32_char[16];
            for (int i = 0; i < head.e_ident.Length; i++)
                head.e_ident[i].value = CreateByte(stream, buffer);

            head.e_type.value = CreateUShort(stream, buffer);
            head.e_machine.value = CreateUShort(stream, buffer);
            head.e_version.value = CreateUInt(stream, buffer);
            head.e_entry.address = CreateUInt(stream, buffer);
            head.e_phoff.offset = CreateUInt(stream, buffer);
            head.e_shoff.offset = CreateUInt(stream, buffer);
            head.e_flags.value = CreateUInt(stream, buffer);
            head.e_ehsize.value = CreateUShort(stream, buffer);
            head.e_phentsize.value = CreateUShort(stream, buffer);
            head.e_phnum.value = CreateUShort(stream, buffer);
            head.e_shentsize.value = CreateUShort(stream, buffer);
            head.e_shnum.value = CreateUShort(stream, buffer);
            head.e_shstrndxs.value = CreateUShort(stream, buffer);
            stream.Close();
            stream.Dispose();
            return head;
        }

        private ushort CreateUShort(FileStream stream, byte[] buffer)
        {
            Advance(stream, buffer, sizeof(ushort));
            if (!BitConverter.IsLittleEndian)
                Array.Reverse(buffer);
            return BitConverter.ToUInt16(buffer, 0);
        }

        private uint CreateUInt(FileStream stream, byte[] buffer)
        {
            Advance(stream, buffer, sizeof(uint));
            if (!BitConverter.IsLittleEndian)
                Array.Reverse(buffer);
            return BitConverter.ToUInt32(buffer, 0);
        }

        private byte CreateByte(FileStream stream, byte[] buffer)
        {
            Advance(stream,buffer,sizeof(byte));
            if (!BitConverter.IsLittleEndian)
                Array.Reverse(buffer);
            return buffer[0];
        }
        private void Advance(FileStream stream, byte[] buffer, int amount)
        {
            stream.Read(buffer, 0, amount);
        }

        public static void PrintHeader(ELF32_header head)
        {
            for (int i = 0; i < head.e_ident.Length; i++)
                Console.WriteLine("Identifier Byte " + i + " : " + head.e_ident[i].value);
            Console.WriteLine("e_type: " + head.e_type.value);
            Console.WriteLine("e_machine: " + head.e_machine.value);
            Console.WriteLine("e_version: " + head.e_version.value);
            Console.WriteLine("e_addr: " + head.e_entry.address);
            Console.WriteLine("e_phoff: " + head.e_phoff.offset);
            Console.WriteLine("e_shoff: " + head.e_shoff.offset);
            Console.WriteLine("e_flags: " + head.e_flags.value);
            Console.WriteLine("e_ehsize: " + head.e_ehsize.value);
            Console.WriteLine("e_phentsize: " + head.e_phentsize.value);
            Console.WriteLine("e_phnum: " + head.e_phnum.value);
            Console.WriteLine("e_shentsize: " + head.e_shentsize.value);
            Console.WriteLine("e_shnum: " + head.e_shnum.value);
            Console.WriteLine("e_shstrndks: " + head.e_shstrndxs.value);
            Console.WriteLine("Header successfully read");
        }
    }
}
