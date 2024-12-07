using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200011C RID: 284
	[Wrapper("AeccDbAlignmentCantLabeling")]
	public class AlignmentCantLabelGroup : AlignmentLabelGroup
	{
		// Token: 0x06000C6A RID: 3178
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId alignmentId);

		// Token: 0x06000C6B RID: 3179
		public static extern ObjectId Create(ObjectId alignmentId);

		// Token: 0x06000C6C RID: 3180
		public static extern ObjectId Create(ObjectId alignmentId, ObjectId styleId);

		// Token: 0x06000C6D RID: 3181
		public extern GeometryPointSelector<CantPointType> GetGeometryPointsOptions();

		// Token: 0x06000C6E RID: 3182
		public extern void SetGeometryPointsOptions(GeometryPointSelector<CantPointType> transitionPointsOptions);

		// Token: 0x06000C6F RID: 3183
		protected internal extern AlignmentCantLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
