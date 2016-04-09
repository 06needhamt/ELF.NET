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

namespace ELF.NET.Sections
{
    public enum EnumSpecialSectionIndexes
    {
        [Description("Undefined Section")]
        SHN_UNDEF = 0,
        [Description("Low process section")]
        SHN_LOPROC = 0xFF00,
        [Description("High process section")]
        SHN_HIPROC = 0xFF1F,
        [Description("Low Operating System Section")]
        SHN_LOOS = 0xFF20,
        [Description("High Operating System Section")]
        SHN_HIOS = 0xFF3F,
        [Description("Absolute Values Section")]
        SHN_ABS = 0xFFF1,
        [Description("Common Symbols Section")]
        SHN_COMMON = 0xFFF2,
        [Description("Section Header Escape Value")]
        SHN_XINDEX = 0xFFFF,
    }
}