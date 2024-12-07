using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000135 RID: 309
	[Wrapper("AeccDbSectionDataBandLabeling")]
	public class SectionDataBandLabelGroup : SectionBandLabelGroup
	{
		// Token: 0x06000D06 RID: 3334
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId sectionViewId);

		// Token: 0x06000D07 RID: 3335
		protected internal extern SectionDataBandLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
