using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000E22 RID: 3618
	public class DesignSpeed : CivilWrapper<AeccDbAlignment>
	{
		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x06001B4C RID: 6988
		public extern int SpeedNumber { get; }

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x06001B4D RID: 6989
		// (set) Token: 0x06001B4E RID: 6990
		public extern double Station { get; set; }

		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x06001B4F RID: 6991
		// (set) Token: 0x06001B50 RID: 6992
		public extern double Value { get; set; }

		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x06001B51 RID: 6993
		// (set) Token: 0x06001B52 RID: 6994
		public extern string Comment { get; set; }

		// Token: 0x040016DB RID: 5851
		private int <SyntheticNonEmptyStructMarker>;
	}
}
