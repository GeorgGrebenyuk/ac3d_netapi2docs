using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020008F9 RID: 2297
	public class SectionSource
	{
		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06001193 RID: 4499
		public extern ObjectId SourceId { get; }

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06001194 RID: 4500
		public extern SectionSourceType SourceType { get; }

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06001195 RID: 4501
		public extern string SourceName { get; }

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06001196 RID: 4502
		// (set) Token: 0x06001197 RID: 4503
		public extern ObjectId StyleId { get; set; }

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06001198 RID: 4504
		// (set) Token: 0x06001199 RID: 4505
		public extern SectionUpdateType UpdateMode { get; set; }

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x0600119A RID: 4506
		// (set) Token: 0x0600119B RID: 4507
		public extern bool IsSampled { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x0600119C RID: 4508
		public extern ObjectIdCollection GetSectionIds();

		// Token: 0x04001301 RID: 4865
		private int <SyntheticNonEmptyStructMarker>;
	}
}
