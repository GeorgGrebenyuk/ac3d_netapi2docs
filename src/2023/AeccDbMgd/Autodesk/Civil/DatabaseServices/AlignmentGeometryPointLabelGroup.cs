using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200011D RID: 285
	[Wrapper("AeccDbAlignmentGeomPointLabeling")]
	public class AlignmentGeometryPointLabelGroup : AlignmentLabelGroup
	{
		// Token: 0x06000C70 RID: 3184
		[DeprecatedVersion(CivilVersion.Civil2013)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.AlignmentGeometryPointLabelGroup.GetAvailableLabelGroupIds instead.", false)]
		public static extern ObjectIdCollection GetAvailableLabelGroups(ObjectId alignmentId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x06000C71 RID: 3185
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId alignmentId);

		// Token: 0x06000C72 RID: 3186
		public static extern ObjectId Create(ObjectId styleId, ObjectId alignmentId);

		// Token: 0x06000C73 RID: 3187
		public extern GeometryPointSelector<AlignmentPointType> GetGeometryPointsOptions();

		// Token: 0x06000C74 RID: 3188
		public extern void SetGeometryPointsOptions(GeometryPointSelector<AlignmentPointType> alignmentGeometryPoints);

		// Token: 0x06000C75 RID: 3189
		protected internal extern AlignmentGeometryPointLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
