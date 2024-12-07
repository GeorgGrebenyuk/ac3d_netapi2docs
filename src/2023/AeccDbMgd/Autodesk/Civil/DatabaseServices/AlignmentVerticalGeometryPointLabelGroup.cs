using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200011E RID: 286
	[Wrapper("AeccDbAlignmentVAGeomPointLabeling")]
	public class AlignmentVerticalGeometryPointLabelGroup : AlignmentLabelGroup
	{
		// Token: 0x06000C76 RID: 3190
		[Obsolete("Use Autodesk.Civil.DatabaseServices.AlignmentVerticalGeometryPointLabelGroup.GetAvailableLabelGroupIds instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2013)]
		public static extern ObjectIdCollection GetAvailableLabelGroups(ObjectId alignmentId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x06000C77 RID: 3191
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId alignmentId);

		// Token: 0x06000C78 RID: 3192
		public static extern ObjectId Create(ObjectId styleId, ObjectId alignmentId, ObjectId verticalAlignmentId);

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06000C79 RID: 3193
		// (set) Token: 0x06000C7A RID: 3194
		public virtual extern ObjectId VerticalAlignment { get; set; }

		// Token: 0x06000C7B RID: 3195
		public extern GeometryPointSelector<ProfilePointType> GetGeometryPointsOptions();

		// Token: 0x06000C7C RID: 3196
		public extern void SetGeometryPointsOptions(GeometryPointSelector<ProfilePointType> alignmentVerticalGeometryPoints);

		// Token: 0x06000C7D RID: 3197
		protected internal extern AlignmentVerticalGeometryPointLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
