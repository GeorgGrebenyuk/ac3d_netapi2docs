using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x0200000B RID: 11
[NativeCppClass]
[UnsafeValueType]
[StructLayout(LayoutKind.Sequential, Size = 28)]
internal struct AeccAttribute
{
	// Token: 0x0400000A RID: 10
	private int <alignment\u0020member>;

	// Token: 0x0200000C RID: 12
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum ATTRTYPE
	{

	}

	// Token: 0x0200000D RID: 13
	[CLSCompliant(false)]
	[NativeCppClass]
	[StructLayout(LayoutKind.Sequential, Size = 8)]
	public struct Expr
	{
		// Token: 0x0400000C RID: 12
		private long <alignment\u0020member>;
	}

	// Token: 0x0200000E RID: 14
	[UnsafeValueType]
	[NativeCppClass]
	internal struct AttrVal
	{
	}
}
