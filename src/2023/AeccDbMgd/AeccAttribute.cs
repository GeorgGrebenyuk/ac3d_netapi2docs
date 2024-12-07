using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000625 RID: 1573
[NativeCppClass]
[UnsafeValueType]
[StructLayout(LayoutKind.Sequential, Size = 28)]
internal struct AeccAttribute
{
	// Token: 0x0400103E RID: 4158
	private int <alignment\u0020member>;

	// Token: 0x02000626 RID: 1574
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum ATTRTYPE
	{

	}

	// Token: 0x02000627 RID: 1575
	[NativeCppClass]
	[CLSCompliant(false)]
	[StructLayout(LayoutKind.Sequential, Size = 8)]
	public struct Expr
	{
		// Token: 0x04001040 RID: 4160
		private long <alignment\u0020member>;

		// Token: 0x02000628 RID: 1576
		[NativeCppClass]
		[CLSCompliant(false)]
		public enum RuntimeErrors
		{

		}

		// Token: 0x02000629 RID: 1577
		[NativeCppClass]
		[UnsafeValueType]
		[CLSCompliant(false)]
		[StructLayout(LayoutKind.Sequential, Size = 12)]
		public struct ErrorInfo
		{
			// Token: 0x04001042 RID: 4162
			private int <alignment\u0020member>;
		}
	}

	// Token: 0x0200062A RID: 1578
	[CLSCompliant(false)]
	[NativeCppClass]
	[StructLayout(LayoutKind.Sequential, Size = 8)]
	public struct func
	{
		// Token: 0x04001043 RID: 4163
		private long <alignment\u0020member>;
	}

	// Token: 0x0200062B RID: 1579
	[CLSCompliant(false)]
	[NativeCppClass]
	[StructLayout(LayoutKind.Sequential, Size = 8)]
	public struct AeccAttrVal<AeccAttribute::Expr\u0020*>
	{
		// Token: 0x04001044 RID: 4164
		private long <alignment\u0020member>;
	}

	// Token: 0x0200062C RID: 1580
	[NativeCppClass]
	[CLSCompliant(false)]
	[StructLayout(LayoutKind.Sequential, Size = 8)]
	public struct AeccAttrVal<AecULongPtrList>
	{
		// Token: 0x04001045 RID: 4165
		private long <alignment\u0020member>;
	}

	// Token: 0x0200062D RID: 1581
	[CLSCompliant(false)]
	[NativeCppClass]
	[StructLayout(LayoutKind.Sequential, Size = 8)]
	public struct AeccAttrVal<AecULongList>
	{
		// Token: 0x04001046 RID: 4166
		private long <alignment\u0020member>;
	}

	// Token: 0x0200062E RID: 1582
	[CLSCompliant(false)]
	[NativeCppClass]
	[StructLayout(LayoutKind.Sequential, Size = 8)]
	public struct AeccAttrVal<std::vector<AeccAttribute,std::allocator<AeccAttribute>\u0020>\u0020>
	{
		// Token: 0x04001047 RID: 4167
		private long <alignment\u0020member>;
	}

	// Token: 0x0200062F RID: 1583
	[NativeCppClass]
	[CLSCompliant(false)]
	[StructLayout(LayoutKind.Sequential, Size = 8)]
	public struct AeccAttrVal<std::vector<AcGePoint3d,std::allocator<AcGePoint3d>\u0020>\u0020>
	{
		// Token: 0x04001048 RID: 4168
		private long <alignment\u0020member>;
	}

	// Token: 0x02000630 RID: 1584
	[CLSCompliant(false)]
	[NativeCppClass]
	[StructLayout(LayoutKind.Sequential, Size = 8)]
	public struct AeccAttrVal<AcCmColor>
	{
		// Token: 0x04001049 RID: 4169
		private long <alignment\u0020member>;
	}

	// Token: 0x02000631 RID: 1585
	[NativeCppClass]
	[UnsafeValueType]
	internal struct AttrVal
	{
	}
}
