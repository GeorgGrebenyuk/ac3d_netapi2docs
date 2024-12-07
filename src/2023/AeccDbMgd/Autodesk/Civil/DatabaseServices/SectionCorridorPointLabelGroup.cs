using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000134 RID: 308
	[Wrapper("AeccDbSectionCorridorPointLabeling")]
	public class SectionCorridorPointLabelGroup : SectionLabelGroup
	{
		// Token: 0x06000CFC RID: 3324
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId sectionViewId, ObjectId sectionId);

		// Token: 0x06000CFD RID: 3325
		public static extern ObjectId Create(ObjectId sectionViewId, ObjectId sectionId);

		// Token: 0x06000CFE RID: 3326
		public static extern ObjectId Create(ObjectId sectionViewId, ObjectId sectionId, ObjectId labelGroupStyleId);

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06000CFF RID: 3327
		public override extern IList<LabelGroupSubEntity> SubEntities { get; }

		// Token: 0x06000D00 RID: 3328
		public extern IList<LabelGroupSubEntity> getDisplayedSubEntities();

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06000D01 RID: 3329
		// (set) Token: 0x06000D02 RID: 3330
		public extern double StaggerLineHeight1 { get; set; }

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06000D03 RID: 3331
		// (set) Token: 0x06000D04 RID: 3332
		public extern double StaggerLineHeight2 { get; set; }

		// Token: 0x06000D05 RID: 3333
		protected internal extern SectionCorridorPointLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
