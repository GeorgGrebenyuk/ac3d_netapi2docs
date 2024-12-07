using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000761 RID: 1889
	public sealed class ConnectedAlignmentSSCSSInfo : ConnectedAlignmentInfo
	{
		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06000EA9 RID: 3753
		// (set) Token: 0x06000EAA RID: 3754
		public extern double CurveRadius { get; set; }

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06000EAB RID: 3755
		public extern SpiralType SpiralDefinition { get; }

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06000EAC RID: 3756
		// (set) Token: 0x06000EAD RID: 3757
		public extern double ReverseSpiralInLength { get; set; }

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06000EAE RID: 3758
		// (set) Token: 0x06000EAF RID: 3759
		public extern double SpiralInLength { get; set; }

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06000EB0 RID: 3760
		// (set) Token: 0x06000EB1 RID: 3761
		public extern double SpiralOutLength { get; set; }

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06000EB2 RID: 3762
		// (set) Token: 0x06000EB3 RID: 3763
		public extern double ReverseSpiralOutLength { get; set; }
	}
}
