using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000BB2 RID: 2994
	public sealed class AppliedAssemblySetting
	{
		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x0600167B RID: 5755
		// (set) Token: 0x0600167C RID: 5756
		public extern double FrequencyAlongTangents { get; set; }

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x0600167D RID: 5757
		// (set) Token: 0x0600167E RID: 5758
		public extern CorridorAlongCurveOption CorridorAlongCurvesOption { get; set; }

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x0600167F RID: 5759
		// (set) Token: 0x06001680 RID: 5760
		public extern double MODAlongCurves { get; set; }

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06001681 RID: 5761
		// (set) Token: 0x06001682 RID: 5762
		public extern double FrequencyAlongCurves { get; set; }

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06001683 RID: 5763
		// (set) Token: 0x06001684 RID: 5764
		public extern double FrequencyAlongSpirals { get; set; }

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06001685 RID: 5765
		// (set) Token: 0x06001686 RID: 5766
		public extern double FrequencyAlongProfileCurves { get; set; }

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06001687 RID: 5767
		// (set) Token: 0x06001688 RID: 5768
		public extern bool AppliedAtHorizontalGeometryPoints { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06001689 RID: 5769
		// (set) Token: 0x0600168A RID: 5770
		public extern bool AppliedAtSuperelevationCriticalPoints { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x0600168B RID: 5771
		// (set) Token: 0x0600168C RID: 5772
		public extern bool AppliedAtProfileGeometryPoints { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x0600168D RID: 5773
		// (set) Token: 0x0600168E RID: 5774
		public extern bool AppliedAtProfileHighLowPoints { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x0600168F RID: 5775
		// (set) Token: 0x06001690 RID: 5776
		public extern bool AppliedAtOffsetTargetGeometryPoints { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06001691 RID: 5777
		// (set) Token: 0x06001692 RID: 5778
		public extern bool AppliedAdjacentToOffsetTargetStartEnd { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06001693 RID: 5779
		// (set) Token: 0x06001694 RID: 5780
		public extern CorridorAlongOffsetTargetCurveOption TargetCurveOption { get; set; }

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06001695 RID: 5781
		// (set) Token: 0x06001696 RID: 5782
		public extern double MODAlongTargetCurves { get; set; }

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06001697 RID: 5783
		// (set) Token: 0x06001698 RID: 5784
		public extern double FrequencyAlongTargetCurves { get; set; }

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06001699 RID: 5785
		// (set) Token: 0x0600169A RID: 5786
		public extern List<AdditionalAppliedAssemblyInfo> AdditionalAppliedAssemblies { get; set; }

		// Token: 0x04001534 RID: 5428
		private int <SyntheticNonEmptyStructMarker>;
	}
}
