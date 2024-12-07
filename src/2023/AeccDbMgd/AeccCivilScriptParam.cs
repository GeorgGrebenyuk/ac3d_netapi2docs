using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000B96 RID: 2966
[NativeCppClass]
[StructLayout(LayoutKind.Sequential, Size = 64)]
internal struct AeccCivilScriptParam
{
	// Token: 0x0400151B RID: 5403
	private long <alignment\u0020member>;

	// Token: 0x02000B97 RID: 2967
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum TargetToOption
	{

	}

	// Token: 0x02000B98 RID: 2968
	[CLSCompliant(false)]
	[NativeCppClass]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	public struct uVal
	{
		// Token: 0x0400151D RID: 5405
		[FieldOffset(0)]
		private long <alignment\u0020member>;
	}

	// Token: 0x02000B99 RID: 2969
	[CLSCompliant(false)]
	[NativeCppClass]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	public struct uTypeInfo
	{
		// Token: 0x0400151E RID: 5406
		[FieldOffset(0)]
		private int <alignment\u0020member>;
	}

	// Token: 0x02000B9A RID: 2970
	[CLSCompliant(false)]
	[NativeCppClass]
	[StructLayout(LayoutKind.Sequential, Size = 40)]
	public struct AeccParamReference
	{
		// Token: 0x0400151F RID: 5407
		private long <alignment\u0020member>;
	}

	// Token: 0x02000B9B RID: 2971
	[CLSCompliant(false)]
	[NativeCppClass]
	[StructLayout(LayoutKind.Sequential, Size = 32)]
	public struct ParamObjectTypeInfo
	{
		// Token: 0x04001520 RID: 5408
		private long <alignment\u0020member>;
	}

	// Token: 0x02000B9C RID: 2972
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum FlagsFields
	{

	}
}
