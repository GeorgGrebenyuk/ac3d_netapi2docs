using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000124 RID: 292
	[Wrapper("AeccDbVAlignmentStationLabeling")]
	public class ProfileStationLabelGroup : ProfileLabelGroup
	{
		// Token: 0x06000C98 RID: 3224
		[Obsolete("Use Autodesk.Civil.DatabaseServices.ProfileStationLabelGroup.GetAvailableLabelGroupIds instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2013)]
		public static extern ObjectIdCollection GetAvailableLabelGroups(ObjectId profileViewId, ObjectId profileId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x06000C99 RID: 3225
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId profileViewId, ObjectId profileId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x06000C9A RID: 3226
		[Obsolete("Use Autodesk.Civil.DatabaseServices.ProfileStationLabelGroup.CreateMajor instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2013)]
		public static extern ObjectId Create(ObjectId profileViewId, ObjectId profileId, ObjectId styleId, double increment);

		// Token: 0x06000C9B RID: 3227
		public static extern ObjectId CreateMajor(ObjectId profileViewId, ObjectId profileId, ObjectId styleId, double increment);

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06000C9C RID: 3228
		// (set) Token: 0x06000C9D RID: 3229
		public virtual extern double Increment { get; set; }

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06000C9E RID: 3230
		// (set) Token: 0x06000C9F RID: 3231
		public virtual extern double StaggerLineHeight1 { get; set; }

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06000CA0 RID: 3232
		// (set) Token: 0x06000CA1 RID: 3233
		public virtual extern double StaggerLineHeight2 { get; set; }

		// Token: 0x06000CA2 RID: 3234
		protected internal extern ProfileStationLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
