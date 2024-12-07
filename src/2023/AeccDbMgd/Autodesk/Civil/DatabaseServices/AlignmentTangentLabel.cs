using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000F9 RID: 249
	[Wrapper("AeccDbAlignmentTangentLabel")]
	public class AlignmentTangentLabel : FeatureLabel
	{
		// Token: 0x06000B66 RID: 2918
		public static extern ObjectId Create(AlignmentSubEntityLine subEntityLine, ObjectId labelStyleId);

		// Token: 0x06000B67 RID: 2919
		public static extern ObjectId Create(AlignmentLine entityLine, ObjectId labelStyleId);

		// Token: 0x06000B68 RID: 2920
		protected internal extern AlignmentTangentLabel(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);

		// Token: 0x06000B69 RID: 2921
		protected override extern void checkStyleId(ObjectId styleId);
	}
}
