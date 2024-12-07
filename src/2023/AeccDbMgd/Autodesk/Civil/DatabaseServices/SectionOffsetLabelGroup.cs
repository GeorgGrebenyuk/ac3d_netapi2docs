using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000131 RID: 305
	[Wrapper("AeccDbSectionOffsetLabeling")]
	public class SectionOffsetLabelGroup : SectionLabelGroup
	{
		// Token: 0x06000CE4 RID: 3300
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId sectionViewId, ObjectId sectionId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x06000CE5 RID: 3301
		public static extern ObjectId CreateMajor(ObjectId sectionViewId, ObjectId sectionId, double increment);

		// Token: 0x06000CE6 RID: 3302
		public static extern ObjectId CreateMajor(ObjectId sectionViewId, ObjectId sectionId, double increment, ObjectId labelStyleId);

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06000CE7 RID: 3303
		// (set) Token: 0x06000CE8 RID: 3304
		public extern double Increment { get; set; }

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06000CE9 RID: 3305
		// (set) Token: 0x06000CEA RID: 3306
		public extern double StaggerLineHeight1 { get; set; }

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06000CEB RID: 3307
		// (set) Token: 0x06000CEC RID: 3308
		public extern double StaggerLineHeight2 { get; set; }

		// Token: 0x06000CED RID: 3309
		protected internal extern SectionOffsetLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
