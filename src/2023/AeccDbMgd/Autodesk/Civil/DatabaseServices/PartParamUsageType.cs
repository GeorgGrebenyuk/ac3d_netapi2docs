using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000FF3 RID: 4083
	public enum PartParamUsageType
	{
		// Token: 0x04001899 RID: 6297
		DoubleGeneral = 101,
		// Token: 0x0400189A RID: 6298
		DoubleNonZero,
		// Token: 0x0400189B RID: 6299
		DoubleNonZeroNonNegative,
		// Token: 0x0400189C RID: 6300
		DoubleDistance,
		// Token: 0x0400189D RID: 6301
		DoubleDistanceMinor,
		// Token: 0x0400189E RID: 6302
		DoubleAngle,
		// Token: 0x0400189F RID: 6303
		DoublePercent,
		// Token: 0x040018A0 RID: 6304
		DoubleArea,
		// Token: 0x040018A1 RID: 6305
		DoubleVolume,
		// Token: 0x040018A2 RID: 6306
		DoubleElevation,
		// Token: 0x040018A3 RID: 6307
		IntGeneral = 201,
		// Token: 0x040018A4 RID: 6308
		IntNonZero,
		// Token: 0x040018A5 RID: 6309
		IntNonZeroNonNegative,
		// Token: 0x040018A6 RID: 6310
		StringGeneral = 301,
		// Token: 0x040018A7 RID: 6311
		StringName,
		// Token: 0x040018A8 RID: 6312
		StringGuid,
		// Token: 0x040018A9 RID: 6313
		StringEnumKey,
		// Token: 0x040018AA RID: 6314
		BoolGeneral = 401,
		// Token: 0x040018AB RID: 6315
		MultipleValuePosition = 501,
		// Token: 0x040018AC RID: 6316
		MultipleValueDirection
	}
}
