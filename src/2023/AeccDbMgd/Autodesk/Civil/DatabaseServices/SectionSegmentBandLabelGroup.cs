using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000136 RID: 310
	[Wrapper("AeccDbSectionSegmentBandLabeling")]
	public class SectionSegmentBandLabelGroup : SectionBandLabelGroup
	{
		// Token: 0x06000D08 RID: 3336
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId sectionViewId);

		// Token: 0x06000D09 RID: 3337
		protected internal extern SectionSegmentBandLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
