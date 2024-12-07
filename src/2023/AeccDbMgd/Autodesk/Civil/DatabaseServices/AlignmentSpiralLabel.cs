using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000F6 RID: 246
	[Wrapper("AeccDbAlignmentSpiralLabel")]
	public class AlignmentSpiralLabel : FeatureLabel
	{
		// Token: 0x06000B5B RID: 2907
		public static extern ObjectId Create(AlignmentSubEntitySpiral subEntitySpiral, ObjectId labelStyleId);

		// Token: 0x06000B5C RID: 2908
		public static extern ObjectId Create(AlignmentSpiral entitySpiral, ObjectId labelStyleId);

		// Token: 0x06000B5D RID: 2909
		protected internal extern AlignmentSpiralLabel(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
