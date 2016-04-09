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
    public enum EnumMachineType
    {
        [Description("No machine")]
        EM_NONE = 0,
        [Description("AT&T WE 32100")]
        EM_M32 = 1,
        [Description(" SPARC")]
        EM_SPARC = 2,
        [Description("Intel 80386")]
        EM_386 = 3,
        [Description("Motorola 68000")]
        EM_68K = 4,
        [Description("Motorola 88000")]
        EM_88K = 5,
        [Description(" Intel MCU")]
        EM_IAMCU = 6,
        [Description("Intel 80860")]
        EM_860 = 7,
        [Description("MIPS I Architecture")]
        EM_MIPS = 8,
        [Description("IBM System/370 Processor")]
        EM_S370 = 9,
        [Description("MIPS RS3000 Little-endian")]
        EM_MIPS_RS3LE = 10,
        [Description("Hewlett-Packard PA-RISC")]
        EM_PARISC = 15,
        [Description("Fujitsu VPP500")]
        EM_VPP500 = 17,
        [Description("Enhanced instruction set SPARC")]
        EM_SPARC32PUS = 18,
        [Description("Intel 80960")]
        EM_960 = 19,
        [Description("PowerPC")]
        EM_PPC = 20,
        [Description("	64-bit PowerPC")]
        EM_PPC64 = 21,
        [Description(" IBM System/390 Processor")]
        EM_S390 = 22,
        [Description("IBM SPU/SPC")]
        EM_SPU = 23,
        [Description(" NEC V800")]
        EM_V800 = 36,
        [Description(" Fujitsu FR20")]
        EM_FR20 = 37,
        [Description(" TRW RH-32")]
        EM_RH32 = 38,
        [Description("Motorola RCE")]
        EM_RCE = 39,
        [Description("ARM 32-bit architecture (AARCH32)")]
        EM_ARM = 40,
        [Description("Digital Alpha")]
        EM_ALPHA = 41,
        [Description("Hitachi SH")]
        EM_SH = 42,
        [Description("SPARC Version 9")]
        EM_SPARCV9 = 43,
        [Description("Siemens TriCore embedded processor")]
        EM_TRICORE = 44,
        [Description("Argonaut RISC Core, Argonaut Technologies Inc.")]
        EM_ARC = 45,
        [Description("Hitachi H8/300")]
        EM_H8_300 = 46,
        [Description("Hitachi H8/300H")]
        EM_H8_300H = 47,
        [Description("Hitachi H8S")]
        EM_H8S = 48,
        [Description("Hitachi H8/500")]
        EM_H8_500 = 49,
        [Description("Intel IA-64 processor architecture")]
        EM_IA_64 = 50,
        [Description("Stanford MIPS-X")]
        EM_MIPS_X = 51,
        [Description("Motorola ColdFire")]
        EM_COLDFIRE = 52,
        [Description("Motorola M68HC12")]
        EM_68HC12 = 53,
        [Description("Fujitsu MMA Multimedia Accelerator")]
        EM_MMA = 54,
        [Description("Siemens PCP")]
        EM_PCP = 55,
        [Description(" Sony nCPU embedded RISC processor")]
        EM_NCPU = 56,
        [Description(" Denso NDR1 microprocessor")]
        EM_NDR1 = 57,
        [Description("Motorola Star*Core processor")]
        EM_STARCORE = 58,
        [Description(" Toyota ME16 processor")]
        EM_ME16 = 59,
        [Description("STMicroelectronics ST100 processor")]
        EM_ST100 = 60,
        [Description("Advanced Logic Corp. TinyJ embedded processor family")]
        EM_TINYJ = 61,
        [Description("AMD x86-64 architecture")]
        EM_X86_64 = 62,
        [Description("Sony DSP Processor")]
        EM_PDSP = 63,
        [Description("Digital Equipment Corp. PDP-10")]
        EM_PDP10 = 64,
        [Description("Digital Equipment Corp. PDP-11")]
        EM_PDP11 = 65,
        [Description("Siemens FX66 microcontroller")]
        EM_FX66 = 66,
        [Description("STMicroelectronics ST9+ 8/16 bit microcontroller")]
        EM_ST9PLUS = 67,
        [Description("STMicroelectronics ST7 8-bit microcontroller")]
        EM_ST7 = 68,
        [Description("Motorola MC68HC16 Microcontroller")]
        EM_68HC16 = 69,
        [Description("Motorola MC68HC11 Microcontroller")]
        EM_68HC11 = 70,
        [Description("Motorola MC68HC08 Microcontroller")]
        EM_68HC08 = 71,
        [Description("Motorola MC68HC05 Microcontroller")]
        EM_68HC05 = 72,
        [Description("Silicon Graphics SVx")]
        EM_SVX = 73,
        [Description("STMicroelectronics ST19 8-bit microcontroller")]
        EM_ST19 = 74,
        [Description("Digital VAX")]
        EM_VAX = 75,
        [Description("Axis Communications 32-bit embedded processor")]
        EM_CRIS = 76,
        [Description("Infineon Technologies 32-bit embedded processor")]
        EM_JAVELIN = 77,
        [Description("Element 14 64-bit DSP Processor")]
        EM_FIREPATH = 78,
        [Description("LSI Logic 16-bit DSP Processor")]
        EM_ZSP = 79,
        [Description("Donald Knuth's educational 64-bit processor")]
        EM_MMIX = 80,
        [Description("Harvard University machine-independent object files")]
        EM_HUANY = 81,
        [Description("SiTera Prism")]
        EM_PRISM = 82,
        [Description("Atmel AVR 8-bit microcontroller")]
        EM_AVR = 83,
        [Description("Fujitsu FR30")]
        EM_FR30 = 84,
        [Description("Mitsubishi D10V")]
        EM_D10V = 85,
        [Description("Mitsubishi D30V")]
        EM_D30V = 86,
        [Description("NEC v850")]
        EM_V850 = 87,
        [Description("Mitsubishi M32R")]
        EM_M32R = 88,
        [Description("Matsushita MN10300")]
        EM_MN10300 = 89,
        [Description("Matsushita MN10200")]
        EM_MN10200 = 90,
        [Description("picoJava")]
        EM_PJ = 91,
        [Description("OpenRISC 32-bit embedded processor")]
        EM_OPENRISC = 92,
        [Description("ARC International ARCompact processor (old spelling/synonym: EM_ARC_A5)")]
        EM_ARC_COMPACT = 93,
        [Description("Tensilica Xtensa Architecture")]
        EM_XTENSA = 94,
        [Description("Alphamosaic VideoCore processor")]
        EM_VIDEOCORE = 95,
        [Description("Thompson Multimedia General Purpose Processor")]
        EM_TMM_GPP = 96,
        [Description("National Semiconductor 32000 series")]
        EM_NS32K = 97,
        [Description("Tenor Network TPC processor")]
        EM_TPC = 98,
        [Description("Trebia SNP 1000 processor")]
        EM_SNP1K = 99,
        [Description("STMicroelectronics (www.st.com) ST200 microcontroller")]
        EM_ST200 = 100,
        [Description("Ubicom IP2xxx microcontroller family")]
        EM_IP2K = 101,
        [Description("MAX Processor")]
        EM_MAX = 102,
        [Description("National Semiconductor CompactRISC microprocessor")]
        EM_CR = 103,
        [Description("Fujitsu F2MC16")]
        EM_F2MC16 = 104,
        [Description("Texas Instruments embedded microcontroller msp430")]
        EM_MSP430 = 105,
        [Description("Analog Devices Blackfin (DSP) processor")]
        EM_BLACKFIN = 106,
        [Description("S1C33 Family of Seiko Epson processors")]
        EM_SE_C33 = 107,
        [Description("Sharp embedded microprocessor")]
        EM_SEP = 108,
        [Description("Arca RISC Microprocessor")]
        EM_ARCA = 109,
        [Description("Microprocessor series from PKU-Unity Ltd. and MPRC of Peking University")]
        EM_UNICORE = 110,
        [Description("eXcess: 16/32/64-bit configurable embedded CPU")]
        EM_EXCESS = 111,
        [Description("Icera Semiconductor Inc. Deep Execution Processor")]
        EM_DXP = 112,
        [Description("Altera Nios II soft-core processor")]
        EM_ALTERA_NIOS2 = 113,
        [Description("National Semiconductor CompactRISC CRX microprocessor")]
        EM_CRX = 114,
        [Description("Motorola XGATE embedded processor")]
        EM_XGATE = 115,
        [Description("Infineon C16x/XC16x processor")]
        EM_C166 = 116,
        [Description("Renesas M16C series microprocessors")]
        EM_M16C = 117,
        [Description("Microchip Technology dsPIC30F Digital Signal Controller")]
        EM_DSPIC30F = 118,
        [Description("Freescale Communication Engine RISC core")]
        EM_CE = 119,
        [Description("Renesas M32C series microprocessors")]
        EM_M32C = 120,
        [Description("Altium TSK3000 core")]
        EM_TSK3000 = 131,
        [Description("Freescale RS08 embedded processor")]
        EM_RS08 = 132,
        [Description("Analog Devices SHARC family of 32-bit DSP processors")]
        EM_SHARC = 133,
        [Description("Cyan Technology eCOG2 microprocessor")]
        EM_ECOG2 = 134,
        [Description("Sunplus S+core7 RISC processor")]
        EM_SCORE7 = 135,
        [Description("New Japan Radio (NJR) 24-bit DSP Processor")]
        EM_DSP24 = 136,
        [Description("Broadcom VideoCore III processor")]
        EM_VIDEOCORE3 = 137,
        [Description("RISC processor for Lattice FPGA architecture")]
        EM_LATTICEMICO32 = 138,
        [Description("Seiko Epson C17 family")]
        EM_SE_C17 = 139,
        [Description("The Texas Instruments TMS320C6000 DSP family")]
        EM_TI_C6000 = 140,
        [Description("The Texas Instruments TMS320C2000 DSP family")]
        EM_TI_C2000 = 141,
        [Description("The Texas Instruments TMS320C55x DSP family")]
        EM_TI_C5500 = 142,
        [Description("Texas Instruments Application Specific RISC Processor, 32bit fetch")]
        EM_TI_ARP32 = 143,
        [Description("Texas Instruments Programmable Realtime Unit")]
        EM_TI_PRU = 144,
        [Description("STMicroelectronics 64bit VLIW Data Signal Processor")]
        EM_MMDSP_PLUS = 160,
        [Description("Cypress M8C microprocessor")]
        EM_CYPRESS_M8C = 161,
        [Description("Renesas R32C series microprocessors")]
        EM_R32C = 162,
        [Description("NXP Semiconductors TriMedia architecture family")]
        EM_TRIMEDIA = 163,
        [Description("QUALCOMM DSP6 Processor")]
        EM_QDSP6 = 164,
        [Description("Intel 8051 and variants")]
        EM_8051 = 165,
        [Description("STMicroelectronics STxP7x family of configurable and extensible RISC processors")]
        EM_STXP7X = 166,
        [Description("Andes Technology compact code size embedded RISC processor family")]
        EM_NDS32 = 167,
        [Description("Cyan Technology eCOG1X family")]
        EM_ECOG1 = 168,
        [Description("Cyan Technology eCOG1X family")]
        EM_ECOG1X = 168,
        [Description("Dallas Semiconductor MAXQ30 Core Micro-controllers")]
        EM_MAXQ30 = 169,
        [Description("New Japan Radio (NJR) 16-bit DSP Processor")]
        EM_XIMO16 = 170,
        [Description("M2000 Reconfigurable RISC Microprocessor")]
        EM_MANIK = 171,
        [Description("Cray Inc. NV2 vector architecture")]
        EM_CRAYNV2 = 172,
        [Description("Renesas RX family")]
        EM_RX = 173,
        [Description("Imagination Technologies META processor architecture")]
        EM_METAG = 174,
        [Description("MCST Elbrus general purpose hardware architecture")]
        EM_MCST_ELBRUS = 175,
        [Description("Cyan Technology eCOG16 family")]
        EM_ECOG16 = 176,
        [Description("National Semiconductor CompactRISC CR16 16-bit microprocessor")]
        EM_CR16 = 177,
        [Description("Freescale Extended Time Processing Unit")]
        EM_ETPU = 178,
        [Description("Infineon Technologies SLE9X core")]
        EM_SLE9X = 179,
        [Description("Intel L10M")]
        EM_L10M = 180,
        [Description("Intel K10M")]
        EM_K10M = 181,
        [Description("ARM 64-bit architecture (AARCH64)")]
        EM_AARCH64 = 183,
        [Description("Atmel Corporation 32-bit microprocessor family")]
        EM_AVR32 = 185,
        [Description("STMicroeletronics STM8 8-bit microcontroller")]
        EM_STM8 = 186,
        [Description("Tilera TILE64 multicore architecture family")]
        EM_TILE64 = 187,
        [Description("Tilera TILEPro multicore architecture family")]
        EM_TILEPRO = 188,
        [Description("Xilinx MicroBlaze 32-bit RISC soft processor core")]
        EM_MICROBLAZE = 189,
        [Description("NVIDIA CUDA architecture")]
        EM_CUDA = 190,
        [Description("Tilera TILE-Gx multicore architecture family")]
        EM_TILEGX = 191,
        [Description("CloudShield architecture family")]
        EM_CLOUDSHIELD = 192,
        [Description("KIPO-KAIST Core-A 1st generation processor family")]
        EM_COREA_1ST = 193,
        [Description("KIPO-KAIST Core-A 2nd generation processor family")]
        EM_COREA_2ND = 194,
        [Description("Synopsys ARCompact V2")]
        EM_ARC_COMPACT2 = 195,
        [Description("Open8 8-bit RISC soft processor core")]
        EM_OPEN8 = 196,
        [Description("Renesas RL78 family")]
        EM_RL78 = 197,
        [Description("Broadcom VideoCore V processor")]
        EM_VIDEOCORE5 = 198,
        [Description("Renesas 78KOR family")]
        EM_78KOR = 199,
        [Description("Freescale 56800EX Digital Signal Controller (DSC)")]
        EM_56800EX = 200,
        [Description("Beyond BA1 CPU architecture")]
        EM_BA1 = 201,
        [Description("Beyond BA2 CPU architecture")]
        EM_BA2 = 202,
        [Description("XMOS xCORE processor family")]
        EM_XCORE = 203,
        [Description("Microchip 8-bit PIC(r) family")]
        EM_MCHP_PIC = 204,
        [Description("Reserved by Intel")]
        EM_INTEL205 = 205,
        [Description("Reserved by Intel")]
        EM_INTEL206 = 206,
        [Description("Reserved by Intel")]
        EM_INTEL207 = 207,
        [Description("Reserved by Intel")]
        EM_INTEL208 = 208,
        [Description("Reserved by Intel")]
        EM_INTEL209 = 209,
        [Description("KM211 KM32 32-bit processor")]
        EM_KM32 = 210,
        [Description("KM211 KMX32 32-bit processor")]
        EM_KMX32 = 211,
        [Description("KM211 KMX16 16-bit processor")]
        EM_KMX16 = 212,
        [Description("KM211 KMX8 8-bit processor")]
        EM_KMX8 = 213,
        [Description("KM211 KVARC processor")]
        EM_KVARC = 214,
        [Description("Paneve CDP architecture family")]
        EM_CDP = 215,
        [Description("Cognitive Smart Memory Processor")]
        EM_COGE = 216,
        [Description("Bluechip Systems CoolEngine")]
        EM_COOL = 217,
        [Description("Nanoradio Optimized RISC")]
        EM_NORC = 218,
        [Description("CSR Kalimba architecture family")]
        EM_CSR_KALIMBA = 219,
        [Description("Zilog Z80")]
        EM_Z80 = 220,
        [Description("Controls and Data Services VISIUMcore processor")]
        EM_VISIUM = 221,
        [Description("FTDI Chip FT32 high performance 32-bit RISC architecture")]
        EM_FT32 = 222,
        [Description("Moxie processor family")]
        EM_MOXIE = 223,
        [Description("AMD GPU architecture")]
        EM_AMDGPU = 224,
        [Description("RISC-V")]
        EM_RISCV = 243,
        [Description("Reserved")]
        RESERVED = 0xFFFF,
    }
}