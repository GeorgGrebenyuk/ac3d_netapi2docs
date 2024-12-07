using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000121 RID: 289
	[Wrapper("AeccDbVAlignmentCrestCurveLabeling")]
	public class ProfileCrestCurveLabelGroup : ProfileLabelGroup
	{
		// Token: 0x06000C84 RID: 3204
		[Obsolete("Use Autodesk.Civil.DatabaseServices.ProfileCrestCurveLabelGroup.GetAvailableLabelGroupIds instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2013)]
		public static extern ObjectIdCollection GetAvailableLabelGroups(ObjectId profileViewId, ObjectId profileId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x06000C85 RID: 3205
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId profileViewId, ObjectId profileId);

		// Token: 0x06000C86 RID: 3206
		public static extern ObjectId Create(ObjectId profileViewId, ObjectId profileId, ObjectId styleId);

		// Token: 0x06000C87 RID: 3207
		protected internal extern ProfileCrestCurveLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
