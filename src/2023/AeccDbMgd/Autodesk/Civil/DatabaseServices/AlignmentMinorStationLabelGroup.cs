using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000118 RID: 280
	[Wrapper("AeccDbAlignmentMinorStationLabeling")]
	public class AlignmentMinorStationLabelGroup : AlignmentStationLabelGroup
	{
		// Token: 0x06000C50 RID: 3152
		[Obsolete("Use Autodesk.Civil.DatabaseServices.AlignmentMinorStationLabelGroup.GetAvailableLabelGroupIds instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2013)]
		public new static extern ObjectIdCollection GetAvailableLabelGroups(ObjectId alignmentId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x06000C51 RID: 3153
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId alignmentId);

		// Token: 0x06000C52 RID: 3154
		public new static extern ObjectId Create(ObjectId styleId, ObjectId majorStationId, double increment);

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06000C53 RID: 3155
		// (set) Token: 0x06000C54 RID: 3156
		public virtual extern ObjectId MajorStationLabelGroup { get; set; }

		// Token: 0x1700053B RID: 1339
		// (set) Token: 0x06000C55 RID: 3157
		public override extern double RangeStart { set; }

		// Token: 0x1700053A RID: 1338
		// (set) Token: 0x06000C56 RID: 3158
		public override extern bool RangeStartFromFeature { [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000539 RID: 1337
		// (set) Token: 0x06000C57 RID: 3159
		public override extern double RangeEnd { set; }

		// Token: 0x17000538 RID: 1336
		// (set) Token: 0x06000C58 RID: 3160
		public override extern bool RangeEndFromFeature { [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x06000C59 RID: 3161
		public override extern void SetRange(double rangeStart, double rangeEnd);

		// Token: 0x06000C5A RID: 3162
		protected internal extern AlignmentMinorStationLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
