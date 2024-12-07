using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000116 RID: 278
	[Wrapper("AeccDbAlignmentStaEquLabeling")]
	public class AlignmentStationEquationLabelGroup : AlignmentLabelGroup
	{
		// Token: 0x06000C43 RID: 3139
		[DeprecatedVersion(CivilVersion.Civil2013)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.AlignmentStationEquationLabelGroup.GetAvailableLabelGroupIds instead.", false)]
		public static extern ObjectIdCollection GetAvailableLabelGroups(ObjectId alignmentId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x06000C44 RID: 3140
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId alignmentId);

		// Token: 0x06000C45 RID: 3141
		public static extern ObjectId Create(ObjectId styleId, ObjectId alignmentId);

		// Token: 0x06000C46 RID: 3142
		protected internal extern AlignmentStationEquationLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
