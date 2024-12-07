using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000F05 RID: 3845
	public enum EntityVerticalConstraintType
	{
		// Token: 0x040017DF RID: 6111
		CurveLength = 513,
		// Token: 0x040017E0 RID: 6112
		KValue,
		// Token: 0x040017E1 RID: 6113
		Radius,
		// Token: 0x040017E2 RID: 6114
		PassThroughPt,
		// Token: 0x040017E3 RID: 6115
		PassThroughPt1AndPt2,
		// Token: 0x040017E4 RID: 6116
		ThreePassPoints = 519,
		// Token: 0x040017E5 RID: 6117
		TwoPassPointsAndGrade,
		// Token: 0x040017E6 RID: 6118
		TwoPassPointsAndParameter,
		// Token: 0x040017E7 RID: 6119
		PreviousSubEntPassPtAndParameter,
		// Token: 0x040017E8 RID: 6120
		NextSubEntPassPtAndParameter,
		// Token: 0x040017E9 RID: 6121
		PreviousSubEntPassPtWithGrade,
		// Token: 0x040017EA RID: 6122
		NextSubEntPassPtWithGrade,
		// Token: 0x040017EB RID: 6123
		PreviousSubEntEndAndPassPt,
		// Token: 0x040017EC RID: 6124
		NextSubEntEndAndPassPt,
		// Token: 0x040017ED RID: 6125
		PassThroughPt1,
		// Token: 0x040017EE RID: 6126
		PassThroughPt2,
		// Token: 0x040017EF RID: 6127
		NoConstraints,
		// Token: 0x040017F0 RID: 6128
		BestFit,
		// Token: 0x040017F1 RID: 6129
		HighLowPoints
	}
}
