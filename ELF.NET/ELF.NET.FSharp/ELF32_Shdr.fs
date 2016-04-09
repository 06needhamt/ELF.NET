(*
The MIT License (MIT)

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
SOFTWARE.
*)

namespace ELF.NET.FSharp.ELF_Types
open System.Runtime.InteropServices;
open ELF.NET.FSharp.ELF_Types;

    [<StructLayout(LayoutKind.Explicit)>]
    type ELF32_shdr =
        struct
            [<FieldOffset(0)>]
            val mutable  sh_name: ELF32_word
            [<FieldOffset(4)>]
            val mutable  sh_type: ELF32_word
            [<FieldOffset(8)>]
            val mutable  sh_flags: ELF32_word
            [<FieldOffset(12)>]
            val mutable  sh_addr: ELF32_addr
            [<FieldOffset(14)>]
            val mutable  sh_offset: ELF32_off
            [<FieldOffset(18)>]
            val mutable  sh_size: ELF32_word
            [<FieldOffset(22)>]
            val mutable  sh_link: ELF32_word
            [<FieldOffset(26)>]
            val mutable  sh_info: ELF32_word
            [<FieldOffset(30)>]
            val mutable  sh_addralign: ELF32_word
            [<FieldOffset(34)>]
            val mutable  sh_entsize: ELF32_word
        end

