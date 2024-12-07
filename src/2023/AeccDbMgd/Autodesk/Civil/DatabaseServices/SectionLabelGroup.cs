using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200012F RID: 303
	[Wrapper("AeccDbSectionLabeling")]
	public class SectionLabelGroup : AutoFeatureLabelGroup
	{
		// Token: 0x17000550 RID: 1360
		// (set) Token: 0x06000CD0 RID: 3280
		public override extern double RangeStart { set; }

		// Token: 0x1700054F RID: 1359
		// (set) Token: 0x06000CD1 RID: 3281
		public override extern bool RangeStartFromFeature { [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700054E RID: 1358
		// (set) Token: 0x06000CD2 RID: 3282
		public override extern double RangeEnd { set; }

		// Token: 0x1700054D RID: 1357
		// (set) Token: 0x06000CD3 RID: 3283
		public override extern bool RangeEndFromFeature { [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x06000CD4 RID: 3284
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(Type labelGroupClassType, ObjectId sectionViewId, ObjectId sectionId, [MarshalAs(UnmanagedType.U1)] bool includeDerived);

		// Token: 0x06000CD5 RID: 3285
		protected internal extern SectionLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);

		// Token: 0x06000CD6 RID: 3286
		protected override extern double GetFeatureStartStation();

		// Token: 0x06000CD7 RID: 3287
		protected override extern double GetFeatureEndStation();

		// Token: 0x06000CD8 RID: 3288
		[return: MarshalAs(UnmanagedType.U1)]
		protected static extern bool IsSectionInSectionView(AcDbObjectId oidSection, AcDbObjectId oidSectionView);

		// Token: 0x06000CD9 RID: 3289
		[return: MarshalAs(UnmanagedType.U1)]
		protected static extern bool DoesSectionSupportSectionLabelGroup(AcDbObjectId oidSection);
	}
}
