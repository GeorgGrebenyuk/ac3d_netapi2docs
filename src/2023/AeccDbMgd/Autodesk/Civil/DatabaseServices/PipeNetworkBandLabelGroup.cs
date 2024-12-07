using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200012A RID: 298
	[Wrapper("AeccDbPipeNetworkBandLabeling")]
	public class PipeNetworkBandLabelGroup : ProfileBandLabelGroup
	{
		// Token: 0x06000CC1 RID: 3265
		[DeprecatedVersion(CivilVersion.Civil2013)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.PipeNetworkBandLabelGroup.GetAvailableLabelGroupIds instead.", false)]
		public static extern ObjectIdCollection GetAvailableLabelGroups(ObjectId profileViewId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x06000CC2 RID: 3266
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId profileViewId);

		// Token: 0x06000CC3 RID: 3267
		protected internal extern PipeNetworkBandLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
