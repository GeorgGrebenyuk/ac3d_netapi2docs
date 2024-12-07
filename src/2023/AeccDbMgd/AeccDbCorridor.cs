using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x0200046A RID: 1130
[NativeCppClass]
[StructLayout(LayoutKind.Sequential, Size = 200)]
internal struct AeccDbCorridor
{
	// Token: 0x04000E33 RID: 3635
	private long <alignment\u0020member>;

	// Token: 0x0200046B RID: 1131
	[CLSCompliant(false)]
	[NativeCppClass]
	public enum RegionLockMode
	{

	}

	// Token: 0x0200046C RID: 1132
	[CLSCompliant(false)]
	[NativeCppClass]
	public enum RegionOutOfDateStatus
	{

	}

	// Token: 0x0200046D RID: 1133
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum UpdateStatus
	{

	}

	// Token: 0x0200046E RID: 1134
	[CLSCompliant(false)]
	[NativeCppClass]
	public enum ALONG_CURVE_OPTION_INDEX
	{

	}

	// Token: 0x0200046F RID: 1135
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum ALONG_TARGET_CURVE_OPTION_INDEX
	{

	}

	// Token: 0x02000470 RID: 1136
	[CLSCompliant(false)]
	[NativeCppClass]
	public enum REHAB_MILL_LEVEL_TYPE_INDEX
	{

	}

	// Token: 0x02000471 RID: 1137
	[NativeCppClass]
	[CLSCompliant(false)]
	[StructLayout(LayoutKind.Sequential, Size = 56)]
	public struct AeccAssemblyExtentInfo
	{
		// Token: 0x04000E3A RID: 3642
		private double <alignment\u0020member>;
	}

	// Token: 0x02000472 RID: 1138
	[CLSCompliant(false)]
	[NativeCppClass]
	public struct AeccApplyTargetResult
	{
	}

	// Token: 0x02000473 RID: 1139
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum eFeatureLineConnectDirection
	{

	}

	// Token: 0x02000474 RID: 1140
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum eMaskType
	{

	}

	// Token: 0x02000475 RID: 1141
	[CLSCompliant(false)]
	[NativeCppClass]
	public enum eParameterOverrideType
	{

	}

	// Token: 0x02000476 RID: 1142
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum eUndoCode
	{

	}

	// Token: 0x02000477 RID: 1143
	[CLSCompliant(false)]
	[NativeCppClass]
	public enum eOverhangCorrectionType
	{

	}

	// Token: 0x02000478 RID: 1144
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum AeccAddStationFromTargetObjects
	{

	}

	// Token: 0x02000479 RID: 1145
	[CLSCompliant(false)]
	[NativeCppClass]
	[StructLayout(LayoutKind.Sequential, Size = 16)]
	public struct ADDITIONAL_STATIONS
	{
		// Token: 0x04000E41 RID: 3649
		private long <alignment\u0020member>;
	}

	// Token: 0x0200047A RID: 1146
	[UnsafeValueType]
	[CLSCompliant(false)]
	[NativeCppClass]
	[StructLayout(LayoutKind.Sequential, Size = 80)]
	public struct MASK_FEATURELINE_INFO
	{
		// Token: 0x04000E42 RID: 3650
		private long <alignment\u0020member>;
	}

	// Token: 0x0200047B RID: 1147
	[CLSCompliant(false)]
	[NativeCppClass]
	[StructLayout(LayoutKind.Sequential, Size = 160)]
	public struct AeccPayItemDetails
	{
		// Token: 0x04000E43 RID: 3651
		private long <alignment\u0020member>;
	}

	// Token: 0x0200047C RID: 1148
	[NativeCppClass]
	[CLSCompliant(false)]
	[StructLayout(LayoutKind.Sequential, Size = 8)]
	public struct AeccCorridorReferenceSynchronizer
	{
		// Token: 0x04000E44 RID: 3652
		private long <alignment\u0020member>;
	}

	// Token: 0x0200047D RID: 1149
	[CLSCompliant(false)]
	[NativeCppClass]
	public enum ClearedBowtieType
	{

	}
}
