using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200075F RID: 1887
	public sealed class ConnectedAlignmentSSCSInfo : ConnectedAlignmentInfo
	{
		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06000E97 RID: 3735
		// (set) Token: 0x06000E98 RID: 3736
		public extern double CurveRadius { get; set; }

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06000E99 RID: 3737
		public extern SpiralType SpiralDefinition { get; }

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06000E9A RID: 3738
		// (set) Token: 0x06000E9B RID: 3739
		public extern double ReverseSpiralInLength { get; set; }

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06000E9C RID: 3740
		// (set) Token: 0x06000E9D RID: 3741
		public extern double SpiralInLength { get; set; }

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06000E9E RID: 3742
		// (set) Token: 0x06000E9F RID: 3743
		public extern double SpiralOutLength { get; set; }
	}
}
