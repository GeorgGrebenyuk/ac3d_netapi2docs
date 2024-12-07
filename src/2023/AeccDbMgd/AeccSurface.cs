using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x020002E4 RID: 740
[NativeCppClass]
[StructLayout(LayoutKind.Sequential, Size = 24)]
internal struct AeccSurface
{
	// Token: 0x040009C9 RID: 2505
	private long <alignment\u0020member>;

	// Token: 0x020002E5 RID: 741
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum AeccSurfaceBoundaryType
	{

	}

	// Token: 0x020002E6 RID: 742
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum AeccSurfaceBorderType
	{

	}

	// Token: 0x020002E7 RID: 743
	[CLSCompliant(false)]
	[NativeCppClass]
	public enum EnumPointsAlongPolylinePointCode
	{

	}

	// Token: 0x020002E8 RID: 744
	[CLSCompliant(false)]
	[NativeCppClass]
	public enum SmoothFlags
	{

	}

	// Token: 0x020002E9 RID: 745
	[UnsafeValueType]
	[NativeCppClass]
	[CLSCompliant(false)]
	[StructLayout(LayoutKind.Sequential, Size = 64)]
	public struct _SmoothParams
	{
		// Token: 0x040009CE RID: 2510
		private long <alignment\u0020member>;
	}

	// Token: 0x020002EA RID: 746
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum AeccSurfaceContourOptions
	{

	}

	// Token: 0x020002EB RID: 747
	[CLSCompliant(false)]
	[NativeCppClass]
	[StructLayout(LayoutKind.Sequential, Size = 80)]
	public struct AeccSurfaceBuildCallbacks
	{
		// Token: 0x040009D0 RID: 2512
		private long <alignment\u0020member>;
	}

	// Token: 0x020002EC RID: 748
	[CLSCompliant(false)]
	[NativeCppClass]
	[StructLayout(LayoutKind.Sequential, Size = 16)]
	public struct AeccSurfaceClipDisabler
	{
		// Token: 0x040009D1 RID: 2513
		private long <alignment\u0020member>;
	}

	// Token: 0x020002ED RID: 749
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum LODComponentType
	{

	}
}
