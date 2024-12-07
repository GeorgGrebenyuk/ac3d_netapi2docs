using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000F5 RID: 245
	[Wrapper("AeccDbAlignmentCurveLabel")]
	public class AlignmentCurveLabel : FeatureLabel
	{
		// Token: 0x06000B57 RID: 2903
		public static extern ObjectId Create(AlignmentSubEntityArc subEntityArc, ObjectId labelStyleId);

		// Token: 0x06000B58 RID: 2904
		public static extern ObjectId Create(AlignmentArc entity, ObjectId labelStyleId);

		// Token: 0x06000B59 RID: 2905
		protected internal extern AlignmentCurveLabel(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);

		// Token: 0x06000B5A RID: 2906
		protected override extern void checkStyleId(ObjectId styleId);
	}
}
