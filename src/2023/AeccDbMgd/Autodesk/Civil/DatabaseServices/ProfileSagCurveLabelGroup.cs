using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000127 RID: 295
	[Wrapper("AeccDbVAlignmentSagCurveLabeling")]
	public class ProfileSagCurveLabelGroup : ProfileLabelGroup
	{
		// Token: 0x06000CB3 RID: 3251
		[Obsolete("Use Autodesk.Civil.DatabaseServices.ProfileSagCurveLabelGroup.GetAvailableLabelGroupIds instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2013)]
		public static extern ObjectIdCollection GetAvailableLabelGroups(ObjectId profileViewId, ObjectId profileId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x06000CB4 RID: 3252
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId profileViewId, ObjectId profileId);

		// Token: 0x06000CB5 RID: 3253
		public static extern ObjectId Create(ObjectId profileViewId, ObjectId profileId, ObjectId styleId);

		// Token: 0x06000CB6 RID: 3254
		protected internal extern ProfileSagCurveLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
