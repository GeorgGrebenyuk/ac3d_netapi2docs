using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000130 RID: 304
	[Wrapper("AeccDbSectionGradeBreakLabeling")]
	public class SectionGradeBreakLabelGroup : SectionLabelGroup
	{
		// Token: 0x06000CDA RID: 3290
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId sectionViewId, ObjectId sectionId);

		// Token: 0x06000CDB RID: 3291
		public static extern ObjectId Create(ObjectId sectionViewId, ObjectId sectionId);

		// Token: 0x06000CDC RID: 3292
		public static extern ObjectId Create(ObjectId sectionViewId, ObjectId sectionId, ObjectId labelStyleId);

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06000CDD RID: 3293
		// (set) Token: 0x06000CDE RID: 3294
		public extern double StaggerLineHeight1 { get; set; }

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06000CDF RID: 3295
		// (set) Token: 0x06000CE0 RID: 3296
		public extern double StaggerLineHeight2 { get; set; }

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06000CE1 RID: 3297
		// (set) Token: 0x06000CE2 RID: 3298
		public extern double Weeding { get; set; }

		// Token: 0x06000CE3 RID: 3299
		protected internal extern SectionGradeBreakLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
