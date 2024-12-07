using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200030D RID: 781
	[Flags]
	public enum StationTypes
	{
		// Token: 0x04000A19 RID: 2585
		All = -1,
		// Token: 0x04000A1A RID: 2586
		Major = 1,
		// Token: 0x04000A1B RID: 2587
		Minor = 2,
		// Token: 0x04000A1C RID: 2588
		GeometryPoint = 8,
		// Token: 0x04000A1D RID: 2589
		Equation = 16,
		// Token: 0x04000A1E RID: 2590
		SuperTransPoint = 128,
		// Token: 0x04000A1F RID: 2591
		RangeStart = 32,
		// Token: 0x04000A20 RID: 2592
		RangeEnd = 64,
		// Token: 0x04000A21 RID: 2593
		HorizontalMask = 8191,
		// Token: 0x04000A22 RID: 2594
		PIPoint = 65536,
		// Token: 0x04000A23 RID: 2595
		CurveByCurvature = 1024,
		// Token: 0x04000A24 RID: 2596
		CurveAtIncrement = 4096,
		// Token: 0x04000A25 RID: 2597
		OffsetTargetCurveOnly = 2048
	}
}
