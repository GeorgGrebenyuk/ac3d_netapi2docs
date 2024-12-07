using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000F7 RID: 247
	[Wrapper("AeccDbAlignmentPILabel")]
	public class AlignmentPILabel : FeatureLabel
	{
		// Token: 0x06000B5E RID: 2910
		public static extern ObjectId Create(AlignmentSCS scs, ObjectId labelStyleId);

		// Token: 0x06000B5F RID: 2911
		public static extern ObjectId Create(AlignmentArc arc, ObjectId labelStyleId);

		// Token: 0x06000B60 RID: 2912
		public static extern ObjectId Create(AlignmentLine tangentIn, ObjectId labelStyleId);

		// Token: 0x06000B61 RID: 2913
		protected internal extern AlignmentPILabel(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
