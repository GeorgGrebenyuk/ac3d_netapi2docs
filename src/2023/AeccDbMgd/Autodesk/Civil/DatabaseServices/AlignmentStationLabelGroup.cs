using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000117 RID: 279
	[Wrapper("AeccDbAlignmentStationLabeling")]
	public class AlignmentStationLabelGroup : AlignmentLabelGroup
	{
		// Token: 0x06000C47 RID: 3143
		[DeprecatedVersion(CivilVersion.Civil2013)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.AlignmentStationLabelGroup.GetAvailableLabelGroupIds instead.", false)]
		public static extern ObjectIdCollection GetAvailableLabelGroups(ObjectId alignmentId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x06000C48 RID: 3144
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId alignmentId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x06000C49 RID: 3145
		[DeprecatedVersion(CivilVersion.Civil2013)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.AlignmentStationLabelGroup.CreateMajor instead.", false)]
		public static extern ObjectId Create(ObjectId styleId, ObjectId alignmentId, double increment);

		// Token: 0x06000C4A RID: 3146
		public static extern ObjectId CreateMajor(ObjectId styleId, ObjectId alignmentId, double increment);

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06000C4B RID: 3147
		// (set) Token: 0x06000C4C RID: 3148
		public virtual extern double Increment { get; set; }

		// Token: 0x17000536 RID: 1334
		// (set) Token: 0x06000C4D RID: 3149
		public override extern double RangeStart { set; }

		// Token: 0x17000535 RID: 1333
		// (set) Token: 0x06000C4E RID: 3150
		public override extern double RangeEnd { set; }

		// Token: 0x06000C4F RID: 3151
		protected internal extern AlignmentStationLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
