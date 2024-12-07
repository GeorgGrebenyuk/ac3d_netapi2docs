using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200012C RID: 300
	[Wrapper("AeccDbSectionalDataBandLabeling")]
	public class SectionalDataBandLabelGroup : ProfileBandLabelGroup
	{
		// Token: 0x06000CC7 RID: 3271
		[Obsolete("Use Autodesk.Civil.DatabaseServices.SectionalDataBandLabelGroup.GetAvailableLabelGroupIds instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2013)]
		public static extern ObjectIdCollection GetAvailableLabelGroups(ObjectId profileViewId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x06000CC8 RID: 3272
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId profileViewId);

		// Token: 0x06000CC9 RID: 3273
		protected internal extern SectionalDataBandLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
