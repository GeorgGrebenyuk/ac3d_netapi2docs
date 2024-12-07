using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000125 RID: 293
	[Wrapper("AeccDbVAlignmentMinorStationLabeling")]
	public class ProfileMinorStationLabelGroup : ProfileStationLabelGroup
	{
		// Token: 0x06000CA3 RID: 3235
		[DeprecatedVersion(CivilVersion.Civil2013)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.ProfileMinorStationLabelGroup.GetAvailableLabelGroupIds instead.", false)]
		public new static extern ObjectIdCollection GetAvailableLabelGroups(ObjectId profileViewId, ObjectId profileId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x06000CA4 RID: 3236
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId profileViewId, ObjectId profileId);

		// Token: 0x06000CA5 RID: 3237
		public static extern ObjectId Create(ObjectId styleId, ObjectId majorStationLabelGroupId, double increment);

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06000CA6 RID: 3238
		// (set) Token: 0x06000CA7 RID: 3239
		public virtual extern ObjectId MajorStationLabelGroup { get; set; }

		// Token: 0x06000CA8 RID: 3240
		protected internal extern ProfileMinorStationLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
