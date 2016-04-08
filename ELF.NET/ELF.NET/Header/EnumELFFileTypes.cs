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

using ELF.NET.Attributes;

namespace ELF.NET.Header
{
    public enum EnumELFFileTypes
    {
        [Description("Unknown File Type")]
        ET_NONE = 0,
        [Description("Relocatable ELF File")]
        ET_REL = 1,
        [Description("Executable ELF file")]
        EL_EXEC = 2,
        [Description("Shared Object File")]
        ET_DYN = 3,
        [Description("Core File")]
        ET_CORE = 4,
        [Description("Reserved")]
        ET_LOPROC = 0xFF00,
        [Description("Reserved")]
        ET_HIPROC = 0xFFFF,
    }
}