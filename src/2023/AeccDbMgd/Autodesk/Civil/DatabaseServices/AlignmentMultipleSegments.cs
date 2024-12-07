using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000E4E RID: 3662
	public class AlignmentMultipleSegments : AlignmentCurve
	{
		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x06001BCB RID: 7115
		public override extern int SubEntityCount { get; }

		// Token: 0x17000DF3 RID: 3571
		public override extern AlignmentSubEntity this[int index]
		{
			get;
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x06001BCD RID: 7117
		public extern AlignmentMultipleSegmentsConstraintType Constraint2 { get; }
	}
}
