using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000F8 RID: 248
	[Wrapper("AeccDbAlignmentIndexedPILabel")]
	public class AlignmentIndexedPILabel : FeatureLabel
	{
		// Token: 0x06000B62 RID: 2914
		public static extern ObjectId Create(AlignmentSCS scs, ObjectId labelStyleId);

		// Token: 0x06000B63 RID: 2915
		public static extern ObjectId Create(AlignmentArc arc, ObjectId labelStyleId);

		// Token: 0x06000B64 RID: 2916
		public static extern ObjectId Create(AlignmentLine tangentIn, ObjectId labelStyleId);

		// Token: 0x06000B65 RID: 2917
		protected internal extern AlignmentIndexedPILabel(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
