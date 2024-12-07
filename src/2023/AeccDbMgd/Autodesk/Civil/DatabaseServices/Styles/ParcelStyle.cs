using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x0200009C RID: 156
	[Wrapper("AeccDbParcelStyle")]
	public sealed class ParcelStyle : StyleBase
	{
		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060006DC RID: 1756
		// (set) Token: 0x060006DD RID: 1757
		public extern bool ObservePatternFillDistance { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060006DE RID: 1758
		// (set) Token: 0x060006DF RID: 1759
		public extern double PatternFillDistance { get; set; }

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060006E0 RID: 1760
		// (set) Token: 0x060006E1 RID: 1761
		public extern string NameTemplate { get; set; }

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060006E2 RID: 1762
		// (set) Token: 0x060006E3 RID: 1763
		public extern ObjectId ParcelSegmentsMarkerStyle { get; set; }

		// Token: 0x060006E4 RID: 1764
		public extern DisplayStyle GetDisplayStylePlan(ParcelDisplayStyleType type);

		// Token: 0x060006E5 RID: 1765
		public extern DisplayStyle GetDisplayStyleModel(ParcelDisplayStyleType type);

		// Token: 0x060006E6 RID: 1766
		public extern DisplayStyle GetDisplayStyleSection();

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060006E7 RID: 1767
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.ParcelStyle.GetAreaFillHatchDisplayStylePlan instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2010)]
		public extern HatchDisplayStyle AreaFillHatchDisplayStylePlan { get; }

		// Token: 0x060006E8 RID: 1768
		public extern HatchDisplayStyle GetAreaFillHatchDisplayStylePlan();

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060006E9 RID: 1769
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.ParcelStyle.GetAreaFillHatchDisplayStyleModel instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2010)]
		public extern HatchDisplayStyle AreaFillHatchDisplayStyleModel { get; }

		// Token: 0x060006EA RID: 1770
		public extern HatchDisplayStyle GetAreaFillHatchDisplayStyleModel();
	}
}
