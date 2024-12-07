using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000123 RID: 291
	[Wrapper("AeccDbVAlignmentLineLabeling")]
	public class ProfileLineLabelGroup : ProfileLabelGroup
	{
		// Token: 0x06000C92 RID: 3218
		[DeprecatedVersion(CivilVersion.Civil2013)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.ProfileLineLabelGroup.GetAvailableLabelGroupIds instead.", false)]
		public static extern ObjectIdCollection GetAvailableLabelGroups(ObjectId profileViewId, ObjectId profileId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x06000C93 RID: 3219
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId profileViewId, ObjectId profileId);

		// Token: 0x06000C94 RID: 3220
		public static extern ObjectId Create(ObjectId profileViewId, ObjectId profileId, ObjectId styleId);

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06000C95 RID: 3221
		// (set) Token: 0x06000C96 RID: 3222
		public extern double Weeding { get; set; }

		// Token: 0x06000C97 RID: 3223
		protected internal extern ProfileLineLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
