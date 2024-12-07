using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.Civil.DatabaseServices.Styles;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000934 RID: 2356
	public class SectionViewBandItem : SectionViewBandSetItem
	{
		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x0600120C RID: 4620
		public extern ObjectId SampleLineId { get; }

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x0600120D RID: 4621
		// (set) Token: 0x0600120E RID: 4622
		public extern ObjectId Section1Id { get; set; }

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x0600120F RID: 4623
		// (set) Token: 0x06001210 RID: 4624
		public extern ObjectId Section2Id { get; set; }

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06001211 RID: 4625
		protected unsafe override extern char* SettingsNode { get; }
	}
}
