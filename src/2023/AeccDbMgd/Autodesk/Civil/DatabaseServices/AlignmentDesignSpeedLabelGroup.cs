using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000115 RID: 277
	[Wrapper("AeccDbAlignmentDesignSpeedLabeling")]
	public class AlignmentDesignSpeedLabelGroup : AlignmentLabelGroup
	{
		// Token: 0x06000C3F RID: 3135
		[DeprecatedVersion(CivilVersion.Civil2013)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.AlignmentDesignSpeedLabelGroup.GetAvailableLabelGroupIds instead.", false)]
		public static extern ObjectIdCollection GetAvailableLabelGroups(ObjectId alignmentId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x06000C40 RID: 3136
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId alignmentId);

		// Token: 0x06000C41 RID: 3137
		public static extern ObjectId Create(ObjectId styleId, ObjectId alignmentId);

		// Token: 0x06000C42 RID: 3138
		protected internal extern AlignmentDesignSpeedLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
