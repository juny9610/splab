# CS_ARCH_MIPS, CS_MODE_MIPS32+CS_MODE_BIG_ENDIAN, None
0x78,0x82,0x43,0x59 = copy_s.b $t5, $w8[2]
0x78,0xa0,0xc8,0x59 = copy_s.h $at, $w25[0]
0x78,0xb1,0x2d,0x99 = copy_s.w $s6, $w5[1]
0x78,0xc4,0xa5,0x99 = copy_u.b $s6, $w20[4]
0x78,0xe0,0x25,0x19 = copy_u.h $s4, $w4[0]
0x78,0xf2,0x6f,0x99 = copy_u.w $fp, $w13[2]
0x78,0x04,0xe8,0x19 = sldi.b $w0, $w29[4]
0x78,0x20,0x8a,0x19 = sldi.h $w8, $w17[0]
0x78,0x32,0xdd,0x19 = sldi.w $w20, $w27[2]
0x78,0x38,0x61,0x19 = sldi.d $w4, $w12[0]
0x78,0x42,0x1e,0x59 = splati.b $w25, $w3[2]
0x78,0x61,0xe6,0x19 = splati.h $w24, $w28[1]
0x78,0x70,0x93,0x59 = splati.w $w13, $w18[0]
0x78,0x78,0x0f,0x19 = splati.d $w28, $w1[0]
0x78,0xbe,0xc5,0xd9 = move.v $w23, $w24