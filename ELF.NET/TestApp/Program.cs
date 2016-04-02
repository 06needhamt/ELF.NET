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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ELF_Types;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] buffer = new byte[8];
            ELF32_header head = new ELF32_header();
            FileStream stream = File.OpenRead(args[0]);
            head.e_ident = new ELF32_char[16];
            for (int i = 0; i < head.e_ident.Length; i++)
                head.e_ident[i].value = (byte)stream.ReadByte();
            
            head.e_type.value = CreateUShort(stream,buffer);
            head.e_machine.value = CreateUShort(stream, buffer);
            PrintHeader(head);
            Console.ReadKey();
        }

        private static void PrintHeader(ELF32_header head)
        {
            for (int i = 0; i < head.e_ident.Length; i++)
                Console.WriteLine("Identifier Byte " + i + " : " + head.e_ident[i].value);
            Console.WriteLine("e_type: " + head.e_type.value);
            Console.WriteLine("e_machine: " + head.e_machine.value);
        }

        private static ushort CreateUShort(FileStream stream, byte[] buffer)
        {
            Advance(stream, buffer, 2);
            if (!BitConverter.IsLittleEndian)
                Array.Reverse(buffer);
            return BitConverter.ToUInt16(buffer, 0);
        }

        private static void Advance(FileStream stream, byte[] buffer, int amount)
        {
            stream.Read(buffer, 0, amount);
        }
    }
}
