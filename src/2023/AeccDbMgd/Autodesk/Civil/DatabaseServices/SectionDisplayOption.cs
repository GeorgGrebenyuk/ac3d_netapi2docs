using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000908 RID: 2312
	public sealed class SectionDisplayOption : GraphDisplayOption
	{
		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x060011AC RID: 4524
		public override extern string SourceName { get; }

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x060011AD RID: 4525
		public extern SectionSourceType SourceType { get; }

		// Token: 0x17000744 RID: 1860
		// (set) Token: 0x060011AE RID: 4526
		public override extern bool UseOverrideStyle { [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000743 RID: 1859
		// (set) Token: 0x060011AF RID: 4527
		public override extern string OverrideStyleName { set; }

		// Token: 0x17000742 RID: 1858
		// (set) Token: 0x060011B0 RID: 4528
		public override extern ObjectId OverrideStyleId { set; }

		// Token: 0x17000741 RID: 1857
		// (set) Token: 0x060011B1 RID: 4529
		public override extern ObjectId LabelSetId { set; }

		// Token: 0x04001310 RID: 4880
		private int <SyntheticNonEmptyStructMarker>;
	}
}
