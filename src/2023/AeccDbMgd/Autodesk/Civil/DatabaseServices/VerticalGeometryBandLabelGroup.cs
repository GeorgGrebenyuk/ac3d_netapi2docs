using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200012E RID: 302
	[Wrapper("AeccDbVerticalGeometryBandLabeling")]
	public class VerticalGeometryBandLabelGroup : ProfileBandLabelGroup
	{
		// Token: 0x06000CCD RID: 3277
		[DeprecatedVersion(CivilVersion.Civil2013)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.VerticalGeometryBandLabelGroup.GetAvailableLabelGroupIds instead.", false)]
		public static extern ObjectIdCollection GetAvailableLabelGroups(ObjectId profileViewId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x06000CCE RID: 3278
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId profileViewId);

		// Token: 0x06000CCF RID: 3279
		protected internal extern VerticalGeometryBandLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
