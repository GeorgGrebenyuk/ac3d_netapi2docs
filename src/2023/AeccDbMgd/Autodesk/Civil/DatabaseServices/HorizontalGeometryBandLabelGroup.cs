using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000129 RID: 297
	[Wrapper("AeccDbHorizontalGeometryBandLabeling")]
	public class HorizontalGeometryBandLabelGroup : ProfileBandLabelGroup
	{
		// Token: 0x06000CBE RID: 3262
		[DeprecatedVersion(CivilVersion.Civil2013)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.HorizontalGeometryBandLabelGroup.GetAvailableLabelGroupIds instead.", false)]
		public static extern ObjectIdCollection GetAvailableLabelGroups(ObjectId profileViewId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x06000CBF RID: 3263
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId profileViewId);

		// Token: 0x06000CC0 RID: 3264
		protected internal extern HorizontalGeometryBandLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
