using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200012B RID: 299
	[Wrapper("AeccDbProfileDataBandLabeling")]
	public class ProfileDataBandLabelGroup : ProfileBandLabelGroup
	{
		// Token: 0x06000CC4 RID: 3268
		[Obsolete("Use Autodesk.Civil.DatabaseServices.ProfileDataBandLabelGroup.GetAvailableLabelGroupIds instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2013)]
		public static extern ObjectIdCollection GetAvailableLabelGroups(ObjectId profileViewId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x06000CC5 RID: 3269
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId profileViewId);

		// Token: 0x06000CC6 RID: 3270
		protected internal extern ProfileDataBandLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
