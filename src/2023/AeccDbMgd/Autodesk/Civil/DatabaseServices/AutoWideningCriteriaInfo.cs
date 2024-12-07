using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000DFA RID: 3578
	public class AutoWideningCriteriaInfo
	{
		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x06001A7A RID: 6778
		// (set) Token: 0x06001A7B RID: 6779
		public extern string CriteriaFileName { get; set; }

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x06001A7C RID: 6780
		// (set) Token: 0x06001A7D RID: 6781
		public extern string WideningMethod { get; set; }

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x06001A7E RID: 6782
		// (set) Token: 0x06001A7F RID: 6783
		public extern string MinimumRadiusTableName { get; set; }

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x06001A80 RID: 6784
		// (set) Token: 0x06001A81 RID: 6785
		public extern string TransitionLengthTableName { get; set; }

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x06001A82 RID: 6786
		// (set) Token: 0x06001A83 RID: 6787
		public extern string AttainmentMethod { get; set; }

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06001A84 RID: 6788
		// (set) Token: 0x06001A85 RID: 6789
		public extern double SpiralPercentForSC { get; set; }

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x06001A86 RID: 6790
		// (set) Token: 0x06001A87 RID: 6791
		public extern double TangentPercentForTC { get; set; }

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x06001A88 RID: 6792
		// (set) Token: 0x06001A89 RID: 6793
		public extern double LaneWidth { get; set; }

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x06001A8A RID: 6794
		// (set) Token: 0x06001A8B RID: 6795
		public extern int LeftLanesCount { get; set; }

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x06001A8C RID: 6796
		// (set) Token: 0x06001A8D RID: 6797
		public extern int RightLanesCount { get; set; }

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x06001A8E RID: 6798
		// (set) Token: 0x06001A8F RID: 6799
		public extern double WheelbaseLength { get; set; }

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x06001A90 RID: 6800
		// (set) Token: 0x06001A91 RID: 6801
		public extern WideningSide WideningSide { get; set; }

		// Token: 0x06001A92 RID: 6802
		public extern AutoWideningCriteriaInfo();

		// Token: 0x040016A7 RID: 5799
		private int <SyntheticNonEmptyStructMarker>;
	}
}
