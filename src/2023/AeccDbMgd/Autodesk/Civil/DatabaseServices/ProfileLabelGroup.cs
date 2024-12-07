using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000120 RID: 288
	[Wrapper("AeccDbVAlignmentLabeling")]
	public abstract class ProfileLabelGroup : AutoFeatureLabelGroup
	{
		// Token: 0x06000C7E RID: 3198
		[Obsolete("Use Autodesk.Civil.DatabaseServices.ProfileLabelGroup.GetAvailableLabelGroupIds instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2013)]
		public static extern ObjectIdCollection GetAvailableLabelGroups(RXClass runtimeClass, ObjectId profileViewId, ObjectId profileId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x06000C7F RID: 3199
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(RXClass runtimeClass, ObjectId profileViewId, ObjectId profileId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x06000C80 RID: 3200
		protected override extern double GetFeatureStartStation();

		// Token: 0x06000C81 RID: 3201
		protected override extern double GetFeatureEndStation();

		// Token: 0x06000C82 RID: 3202
		[return: MarshalAs(UnmanagedType.U1)]
		protected static extern bool IsProfileInProfileView(ObjectId profileId, ObjectId profileViewId);

		// Token: 0x06000C83 RID: 3203
		protected internal extern ProfileLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
