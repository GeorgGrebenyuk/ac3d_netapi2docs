using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200011B RID: 283
	[Wrapper("AeccDbAlignmentSuperelevationLabeling")]
	public class AlignmentSuperelevationLabelGroup : AlignmentLabelGroup
	{
		// Token: 0x06000C64 RID: 3172
		[DeprecatedVersion(CivilVersion.Civil2013)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.AlignmentSuperelevationLabelGroup.GetAvailableLabelGroupIds instead.", false)]
		public static extern ObjectIdCollection GetAvailableLabelGroups(ObjectId alignmentId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x06000C65 RID: 3173
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId alignmentId);

		// Token: 0x06000C66 RID: 3174
		public static extern ObjectId Create(ObjectId styleId, ObjectId alignmentId);

		// Token: 0x06000C67 RID: 3175
		public extern GeometryPointSelector<SuperelevationPointType> GetGeometryPointsOptions();

		// Token: 0x06000C68 RID: 3176
		public extern void SetGeometryPointsOptions(GeometryPointSelector<SuperelevationPointType> transitionPoints);

		// Token: 0x06000C69 RID: 3177
		protected internal extern AlignmentSuperelevationLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
