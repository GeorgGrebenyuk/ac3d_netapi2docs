using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000379 RID: 889
[NativeCppClass]
[StructLayout(LayoutKind.Sequential, Size = 56)]
internal struct AeccDbCogoPoint
{
	// Token: 0x04000AFA RID: 2810
	private long <alignment\u0020member>;

	// Token: 0x0200037A RID: 890
	[CLSCompliant(false)]
	[NativeCppClass]
	public enum eUserParamHints
	{

	}

	// Token: 0x0200037B RID: 891
	[CLSCompliant(false)]
	[NativeCppClass]
	public enum eProjectionAnchor
	{

	}

	// Token: 0x0200037C RID: 892
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum Hints
	{

	}

	// Token: 0x0200037D RID: 893
	[CLSCompliant(false)]
	[NativeCppClass]
	[StructLayout(LayoutKind.Sequential, Size = 24)]
	public struct UserParamInfoBase
	{
		// Token: 0x04000AFE RID: 2814
		private long <alignment\u0020member>;
	}

	// Token: 0x0200037E RID: 894
	[CLSCompliant(false)]
	[NativeCppClass]
	[StructLayout(LayoutKind.Sequential, Size = 120)]
	public struct LabelAnchorInfo
	{
		// Token: 0x04000AFF RID: 2815
		private long <alignment\u0020member>;
	}

	// Token: 0x0200037F RID: 895
	[NativeCppClass]
	[CLSCompliant(false)]
	[StructLayout(LayoutKind.Sequential, Size = 232)]
	public struct UserParamInfo
	{
		// Token: 0x04000B00 RID: 2816
		private long <alignment\u0020member>;
	}

	// Token: 0x02000380 RID: 896
	[NativeCppClass]
	[CLSCompliant(false)]
	[StructLayout(LayoutKind.Sequential, Size = 16)]
	public struct BlockData
	{
		// Token: 0x04000B01 RID: 2817
		private long <alignment\u0020member>;
	}
}
