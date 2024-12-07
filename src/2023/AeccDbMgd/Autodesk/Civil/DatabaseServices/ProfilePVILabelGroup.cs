using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000126 RID: 294
	[Wrapper("AeccDbVAlignmentPVILabeling")]
	public class ProfilePVILabelGroup : ProfileLabelGroup
	{
		// Token: 0x06000CA9 RID: 3241
		[DeprecatedVersion(CivilVersion.Civil2013)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.ProfilePVILabelGroup.GetAvailableLabelGroupIds instead.", false)]
		public static extern ObjectIdCollection GetAvailableLabelGroups(ObjectId profileViewId, ObjectId profileId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x06000CAA RID: 3242
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId profileViewId, ObjectId profileId);

		// Token: 0x06000CAB RID: 3243
		public static extern ObjectId Create(ObjectId profileViewId, ObjectId profileId, ObjectId styleId);

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06000CAC RID: 3244
		// (set) Token: 0x06000CAD RID: 3245
		public extern double Weeding { get; set; }

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06000CAE RID: 3246
		// (set) Token: 0x06000CAF RID: 3247
		public virtual extern double StaggerLineHeight1 { get; set; }

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06000CB0 RID: 3248
		// (set) Token: 0x06000CB1 RID: 3249
		public virtual extern double StaggerLineHeight2 { get; set; }

		// Token: 0x06000CB2 RID: 3250
		protected internal extern ProfilePVILabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
