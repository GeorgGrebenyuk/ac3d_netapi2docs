using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000FE RID: 254
	[Wrapper("AeccDbSectionViewDepthLabel")]
	public class SectionViewDepthLabel : FeatureLabel
	{
		// Token: 0x06000B81 RID: 2945
		public static extern ObjectId Create(ObjectId sectionViewId, Point2d startPoint, Point2d endPoint);

		// Token: 0x06000B82 RID: 2946
		public static extern ObjectId Create(ObjectId sectionViewId, Point2d startPoint, Point2d endPoint, ObjectId labelStyleId);

		// Token: 0x06000B83 RID: 2947
		public static extern ObjectIdCollection GetAvailableLabelIds(ObjectId sectionViewId);

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000B84 RID: 2948
		// (set) Token: 0x06000B85 RID: 2949
		public extern Point2d StartPoint { get; set; }

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000B86 RID: 2950
		// (set) Token: 0x06000B87 RID: 2951
		public extern Point2d EndPoint { get; set; }

		// Token: 0x06000B88 RID: 2952
		protected internal extern SectionViewDepthLabel(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
