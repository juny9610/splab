# CS_ARCH_ARM64, 0, None
0x20,0x38,0x30,0x0e = saddlv h0, v1.8b
0x20,0x38,0x30,0x4e = saddlv h0, v1.16b
0x20,0x38,0x70,0x0e = saddlv s0, v1.4h
0x20,0x38,0x70,0x4e = saddlv s0, v1.8h
0x20,0x38,0xb0,0x4e = saddlv d0, v1.4s
0x20,0x38,0x30,0x2e = uaddlv h0, v1.8b
0x20,0x38,0x30,0x6e = uaddlv h0, v1.16b
0x20,0x38,0x70,0x2e = uaddlv s0, v1.4h
0x20,0x38,0x70,0x6e = uaddlv s0, v1.8h
0x20,0x38,0xb0,0x6e = uaddlv d0, v1.4s
0x20,0xa8,0x30,0x0e = smaxv b0, v1.8b
0x20,0xa8,0x30,0x4e = smaxv b0, v1.16b
0x20,0xa8,0x70,0x0e = smaxv h0, v1.4h
0x20,0xa8,0x70,0x4e = smaxv h0, v1.8h
0x20,0xa8,0xb0,0x4e = smaxv s0, v1.4s
0x20,0xa8,0x31,0x0e = sminv b0, v1.8b
0x20,0xa8,0x31,0x4e = sminv b0, v1.16b
0x20,0xa8,0x71,0x0e = sminv h0, v1.4h
0x20,0xa8,0x71,0x4e = sminv h0, v1.8h
0x20,0xa8,0xb1,0x4e = sminv s0, v1.4s
0x20,0xa8,0x30,0x2e = umaxv b0, v1.8b
0x20,0xa8,0x30,0x6e = umaxv b0, v1.16b
0x20,0xa8,0x70,0x2e = umaxv h0, v1.4h
0x20,0xa8,0x70,0x6e = umaxv h0, v1.8h
0x20,0xa8,0xb0,0x6e = umaxv s0, v1.4s
0x20,0xa8,0x31,0x2e = uminv b0, v1.8b
0x20,0xa8,0x31,0x6e = uminv b0, v1.16b
0x20,0xa8,0x71,0x2e = uminv h0, v1.4h
0x20,0xa8,0x71,0x6e = uminv h0, v1.8h
0x20,0xa8,0xb1,0x6e = uminv s0, v1.4s
0x20,0xb8,0x31,0x0e = addv b0, v1.8b
0x20,0xb8,0x31,0x4e = addv b0, v1.16b
0x20,0xb8,0x71,0x0e = addv h0, v1.4h
0x20,0xb8,0x71,0x4e = addv h0, v1.8h
0x20,0xb8,0xb1,0x4e = addv s0, v1.4s
0x20,0xc8,0x30,0x6e = fmaxnmv s0, v1.4s
0x20,0xc8,0xb0,0x6e = fminnmv s0, v1.4s
0x20,0xf8,0x30,0x6e = fmaxv s0, v1.4s
0x20,0xf8,0xb0,0x6e = fminv s0, v1.4s
