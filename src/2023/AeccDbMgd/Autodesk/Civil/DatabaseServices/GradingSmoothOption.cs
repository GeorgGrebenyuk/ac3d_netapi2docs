using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000BBA RID: 3002
	public struct GradingSmoothOption
	{
		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x060016A7 RID: 5799
		// (set) Token: 0x060016A8 RID: 5800
		public extern bool NeedSmooth { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x060016A9 RID: 5801
		// (set) Token: 0x060016AA RID: 5802
		public extern double ArcInclusionDistance { get; set; }

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x060016AB RID: 5803
		// (set) Token: 0x060016AC RID: 5804
		public extern double WeedingDistance { get; set; }

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x060016AD RID: 5805
		// (set) Token: 0x060016AE RID: 5806
		public extern double HorizDeviation { get; set; }

		// Token: 0x060016AF RID: 5807
		public extern GradingSmoothOption([MarshalAs(UnmanagedType.U1)] bool isSoomth, double arcInclusionDistance, double weedingDistance, double horizDeviation);

		// Token: 0x0400153E RID: 5438
		private bool m_isSmooth;

		// Token: 0x0400153F RID: 5439
		private double m_arcInclusionDistance;

		// Token: 0x04001540 RID: 5440
		private double m_weedingDistance;

		// Token: 0x04001541 RID: 5441
		private double m_horizDeviation;

		// Token: 0x04001542 RID: 5442
		private unsafe AeccAttributeTypeInfoDouble* m_pRange;
	}
}
