using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000133 RID: 307
	[Wrapper("AeccDbSectionSegmentLabeling")]
	public class SectionSegmentLabelGroup : SectionLabelGroup
	{
		// Token: 0x06000CF8 RID: 3320
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId sectionViewId, ObjectId sectionId);

		// Token: 0x06000CF9 RID: 3321
		public static extern ObjectId Create(ObjectId sectionViewId, ObjectId sectionId);

		// Token: 0x06000CFA RID: 3322
		public static extern ObjectId Create(ObjectId sectionViewId, ObjectId sectionId, ObjectId labelGroupStyleId);

		// Token: 0x06000CFB RID: 3323
		protected internal extern SectionSegmentLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
