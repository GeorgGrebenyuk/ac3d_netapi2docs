using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000A3 RID: 163
	[Wrapper("AeccDbSheetStyle")]
	public sealed class SheetStyle : StyleBase
	{
		// Token: 0x170002BD RID: 701
		// (get) Token: 0x0600072B RID: 1835
		// (set) Token: 0x0600072C RID: 1836
		public extern ObjectId PageLayoutId { get; set; }

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x0600072D RID: 1837
		// (set) Token: 0x0600072E RID: 1838
		public extern double PageMarginTop { get; set; }

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x0600072F RID: 1839
		// (set) Token: 0x06000730 RID: 1840
		public extern double PageMarginBottom { get; set; }

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000731 RID: 1841
		// (set) Token: 0x06000732 RID: 1842
		public extern double PageMarginLeft { get; set; }

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000733 RID: 1843
		// (set) Token: 0x06000734 RID: 1844
		public extern double PageMarginRight { get; set; }
	}
}
