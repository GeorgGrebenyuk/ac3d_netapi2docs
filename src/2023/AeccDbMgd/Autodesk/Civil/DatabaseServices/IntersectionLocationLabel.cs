using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000101 RID: 257
	[Wrapper("AeccDbIntersectionLocationLabel")]
	public class IntersectionLocationLabel : FeatureLabel
	{
		// Token: 0x06000B9B RID: 2971
		public static extern ObjectId Create(ObjectId intersectionId);

		// Token: 0x06000B9C RID: 2972
		public static extern ObjectId Create(ObjectId intersectionId, ObjectId labelStyleId);

		// Token: 0x06000B9D RID: 2973
		public static extern ObjectIdCollection GetAvailableLabelIds(ObjectId intersectionId);

		// Token: 0x06000B9E RID: 2974
		protected internal extern IntersectionLocationLabel(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
