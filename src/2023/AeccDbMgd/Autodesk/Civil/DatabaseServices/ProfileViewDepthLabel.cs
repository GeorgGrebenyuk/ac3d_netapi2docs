using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000FC RID: 252
	[Wrapper("AeccDbProfileViewDepthLabel")]
	public class ProfileViewDepthLabel : FeatureLabel
	{
		// Token: 0x06000B78 RID: 2936
		public static extern ObjectId Create(ObjectId profileViewId, ObjectId labelStyleId, Point2d startPoint, Point2d endPoint);

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000B79 RID: 2937
		// (set) Token: 0x06000B7A RID: 2938
		public extern Point2d StartPoint { get; set; }

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000B7B RID: 2939
		// (set) Token: 0x06000B7C RID: 2940
		public extern Point2d EndPoint { get; set; }

		// Token: 0x06000B7D RID: 2941
		protected internal extern ProfileViewDepthLabel(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
