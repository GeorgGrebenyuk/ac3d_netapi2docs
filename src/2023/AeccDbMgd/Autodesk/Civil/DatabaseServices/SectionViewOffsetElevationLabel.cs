using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000FF RID: 255
	[Wrapper("AeccDbOffsetElevLabel")]
	public class SectionViewOffsetElevationLabel : FeatureLabel
	{
		// Token: 0x06000B89 RID: 2953
		public static extern ObjectId Create(ObjectId sectionViewId, double offset, double elevation);

		// Token: 0x06000B8A RID: 2954
		public static extern ObjectId Create(ObjectId sectionViewId, double offset, double elevation, ObjectId labelStyleId, ObjectId markerStyleId);

		// Token: 0x06000B8B RID: 2955
		public static extern ObjectIdCollection GetAvailableLabelIds(ObjectId sectionViewId);

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000B8C RID: 2956
		// (set) Token: 0x06000B8D RID: 2957
		public extern double Offset { get; set; }

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000B8E RID: 2958
		// (set) Token: 0x06000B8F RID: 2959
		public extern double Elevation { get; set; }

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000B90 RID: 2960
		// (set) Token: 0x06000B91 RID: 2961
		public extern ObjectId Section1Id { get; set; }

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000B92 RID: 2962
		// (set) Token: 0x06000B93 RID: 2963
		public extern ObjectId Section2Id { get; set; }

		// Token: 0x06000B94 RID: 2964
		protected internal extern SectionViewOffsetElevationLabel(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
