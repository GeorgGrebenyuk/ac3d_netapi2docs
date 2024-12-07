using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000114 RID: 276
	[Wrapper("AeccDbAlignmentLabeling")]
	public abstract class AlignmentLabelGroup : AutoFeatureLabelGroup
	{
		// Token: 0x06000C3A RID: 3130
		[DeprecatedVersion(CivilVersion.Civil2013)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.AlignmentLabelGroup.GetAvailableLabelGroupIds instead.", false)]
		public static extern ObjectIdCollection GetAvailableLabelGroups(RXClass rxClass, ObjectId alignmentId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x06000C3B RID: 3131
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(RXClass rxClass, ObjectId alignmentId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x06000C3C RID: 3132
		protected override extern double GetFeatureStartStation();

		// Token: 0x06000C3D RID: 3133
		protected override extern double GetFeatureEndStation();

		// Token: 0x06000C3E RID: 3134
		protected internal extern AlignmentLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
