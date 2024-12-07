using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000132 RID: 306
	[Wrapper("AeccDbSectionMinorOffsetLabeling")]
	public class SectionMinorOffsetLabelGroup : SectionOffsetLabelGroup
	{
		// Token: 0x06000CEE RID: 3310
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId sectionViewId, ObjectId sectionId);

		// Token: 0x06000CEF RID: 3311
		public static extern ObjectId Create(ObjectId majorOffsetLabelGroupId, double increment);

		// Token: 0x06000CF0 RID: 3312
		public static extern ObjectId Create(ObjectId majorOffsetLabelGroupId, double increment, ObjectId labelGroupStyleId);

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06000CF1 RID: 3313
		// (set) Token: 0x06000CF2 RID: 3314
		public extern ObjectId MajorOffsetLabelGroupId { get; set; }

		// Token: 0x1700055A RID: 1370
		// (set) Token: 0x06000CF3 RID: 3315
		public override extern double RangeStart { set; }

		// Token: 0x17000559 RID: 1369
		// (set) Token: 0x06000CF4 RID: 3316
		public override extern bool RangeStartFromFeature { [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000558 RID: 1368
		// (set) Token: 0x06000CF5 RID: 3317
		public override extern double RangeEnd { set; }

		// Token: 0x17000557 RID: 1367
		// (set) Token: 0x06000CF6 RID: 3318
		public override extern bool RangeEndFromFeature { [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x06000CF7 RID: 3319
		protected internal extern SectionMinorOffsetLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
