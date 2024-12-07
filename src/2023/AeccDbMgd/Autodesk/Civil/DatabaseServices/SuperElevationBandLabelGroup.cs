using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200012D RID: 301
	[Wrapper("AeccDbSuperElevationBandLabeling")]
	public class SuperElevationBandLabelGroup : ProfileBandLabelGroup
	{
		// Token: 0x06000CCA RID: 3274
		[Obsolete("Use Autodesk.Civil.DatabaseServices.SuperElevationBandLabelGroup.GetAvailableLabelGroupIds instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2013)]
		public static extern ObjectIdCollection GetAvailableLabelGroups(ObjectId profileViewId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x06000CCB RID: 3275
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId profileViewId);

		// Token: 0x06000CCC RID: 3276
		protected internal extern SuperElevationBandLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
