using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000072 RID: 114
	[Wrapper("AeccDbSectionBandLabeling")]
	public class SectionBandLabelGroup : AutoFeatureLabelGroup
	{
		// Token: 0x060004D6 RID: 1238
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(Type bandLabelGroupClassType, ObjectId sectionViewId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060004D7 RID: 1239
		// (set) Token: 0x060004D8 RID: 1240
		public override extern ObjectId StyleId { get; set; }

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060004D9 RID: 1241
		// (set) Token: 0x060004DA RID: 1242
		public override extern string StyleName { get; set; }

		// Token: 0x060004DB RID: 1243
		protected internal extern SectionBandLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
