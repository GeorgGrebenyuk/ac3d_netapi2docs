using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000905 RID: 2309
	public class SectionViewGroup
	{
		// Token: 0x060011A2 RID: 4514
		public extern ObjectIdCollection GetSectionViewIds();

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x060011A3 RID: 4515
		// (set) Token: 0x060011A4 RID: 4516
		public extern ObjectId PlotStyleId { get; set; }

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060011A5 RID: 4517
		public extern string Name { get; }

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060011A6 RID: 4518
		public extern bool IsIndividual { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060011A7 RID: 4519
		public extern ObjectId SampleLineGroupId { get; }

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060011A8 RID: 4520
		public extern string TemplateFilePath { get; }

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060011A9 RID: 4521
		public extern string LayoutName { get; }

		// Token: 0x060011AA RID: 4522
		public extern void UpdateLayout();

		// Token: 0x060011AB RID: 4523
		public extern void ImportLabelSetForSectionsInGroup(SectionSource sectionSource, ObjectId labelSetId);

		// Token: 0x0400130D RID: 4877
		private int <SyntheticNonEmptyStructMarker>;
	}
}
