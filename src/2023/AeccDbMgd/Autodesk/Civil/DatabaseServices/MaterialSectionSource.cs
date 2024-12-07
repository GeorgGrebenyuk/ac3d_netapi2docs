using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020008EB RID: 2283
	public class MaterialSectionSource
	{
		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x0600117F RID: 4479
		public extern SectionSourceType SourceType { get; }

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06001180 RID: 4480
		public extern QTOMaterial Material { get; }

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06001181 RID: 4481
		// (set) Token: 0x06001182 RID: 4482
		public extern ObjectId StyleId { get; set; }

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06001183 RID: 4483
		public extern SectionUpdateType UpdateMode { get; }

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06001184 RID: 4484
		public extern bool IsSampled { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x06001185 RID: 4485
		public extern ObjectIdCollection GetMaterialSectionIds();

		// Token: 0x040012F5 RID: 4853
		private int <SyntheticNonEmptyStructMarker>;
	}
}
