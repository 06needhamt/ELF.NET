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
    type ELF32_header = 
        struct
            [<FieldOffset(0)>]
            val mutable  e_ident: ELF32_char[]
            [<FieldOffset(16)>]
            val mutable  e_type: ELF32_half
            [<FieldOffset(18)>]
            val mutable  e_machine: ELF32_half
            [<FieldOffset(20)>]
            val mutable  e_version: ELF32_word
            [<FieldOffset(24)>]
            val mutable  e_entry: ELF32_addr
            [<FieldOffset(28)>]
            val mutable  e_phoff: ELF32_off
            [<FieldOffset(32)>]
            val mutable  e_shoff: ELF32_off
            [<FieldOffset(36)>]
            val mutable  e_flags: ELF32_word
            [<FieldOffset(40)>]
            val mutable  e_ehsize: ELF32_half
            [<FieldOffset(42)>]
            val mutable  e_phentsize: ELF32_half
            [<FieldOffset(44)>]
            val mutable  e_phnum: ELF32_half
            [<FieldOffset(46)>]
            val mutable  e_shentsize: ELF32_half
            [<FieldOffset(48)>]
            val mutable  e_shnum: ELF32_half
            [<FieldOffset(50)>]
            val mutable  e_shstrndxs: ELF32_half

        end