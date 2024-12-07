using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000079 RID: 121
[UnsafeValueType]
[NativeCppClass]
[StructLayout(LayoutKind.Sequential, Size = 28)]
internal struct AeccAttribute
{
	// Token: 0x0400009C RID: 156
	private int <alignment\u0020member>;

	// Token: 0x0200007A RID: 122
	[CLSCompliant(false)]
	[NativeCppClass]
	public enum ATTRTYPE
	{

	}

	// Token: 0x0200007B RID: 123
	[NativeCppClass]
	[CLSCompliant(false)]
	[StructLayout(LayoutKind.Sequential, Size = 8)]
	public struct Expr
	{
		// Token: 0x0400009E RID: 158
		private long <alignment\u0020member>;
	}

	// Token: 0x0200007C RID: 124
	[NativeCppClass]
	[UnsafeValueType]
	internal struct AttrVal
	{
	}
}
