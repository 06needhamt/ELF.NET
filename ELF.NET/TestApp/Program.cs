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
using ELF.NET;
using ELF.NET.Header;
using ELF.NET.FSharp.ELF_Types;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Invalid command line args");
                Console.ReadKey();
                return;
            }
            ELFHeaderParser hp = new ELFHeaderParser(args);
            ELF32_header header = hp.ParseHeader();
            ELFHeaderParser.PrintHeader(header);
            ELFIdentifierParser identparser = new ELFIdentifierParser(header.e_ident);
            if (identparser.CheckMagic())
            {
                Console.WriteLine(args[0] + " is a valid ELF file");
            }
            else
            {
                Console.WriteLine(args[0] + " is not a valid ELF file");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("ELF File Class: " + identparser.GetFileClass().ToString() + " : " + identparser.GetFileClass().DescriptionAttribute());
            Console.WriteLine("ELF Data Encoding " + identparser.GetDataEncoding().ToString() + ": " + identparser.GetDataEncoding().DescriptionAttribute());
            Console.WriteLine("ELF Version " + identparser.GetFileVersion().ToString() + " : " + identparser.GetFileVersion().DescriptionAttribute());
            Console.WriteLine("ELF File Type " + hp.ParseFileType().ToString() + " : " + hp.ParseFileType().DescriptionAttribute());
            Console.WriteLine("ELF Machine Type " + hp.ParseMachineType().ToString() + " : " + hp.ParseMachineType().DescriptionAttribute());
            Console.WriteLine("ELF Identifier Size " + identparser.GetIdentifierSize().ToString());
            Console.ReadKey();
        }


    }
}
