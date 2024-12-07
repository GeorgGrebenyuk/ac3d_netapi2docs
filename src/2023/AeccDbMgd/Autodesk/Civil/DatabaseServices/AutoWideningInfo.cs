using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000DF9 RID: 3577
	public class AutoWideningInfo
	{
		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x06001A73 RID: 6771
		// (set) Token: 0x06001A74 RID: 6772
		public extern double IncreasedWidth { get; set; }

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x06001A75 RID: 6773
		// (set) Token: 0x06001A76 RID: 6774
		public extern double TransitionLength { get; set; }

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x06001A77 RID: 6775
		// (set) Token: 0x06001A78 RID: 6776
		public extern WideningSide Side { get; set; }

		// Token: 0x06001A79 RID: 6777
		public extern AutoWideningInfo();

		// Token: 0x040016A6 RID: 5798
		private int <SyntheticNonEmptyStructMarker>;
	}
}
