using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000E64 RID: 3684
	public class OffsetAlignmentWideningCriteria
	{
		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x06001BEB RID: 7147
		// (set) Token: 0x06001BEC RID: 7148
		public extern string WideningMethod { get; set; }

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x06001BED RID: 7149
		// (set) Token: 0x06001BEE RID: 7150
		public extern WideningSide WideningSide { get; set; }

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06001BEF RID: 7151
		// (set) Token: 0x06001BF0 RID: 7152
		public extern string MinimumRadiusTableName { get; set; }

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x06001BF1 RID: 7153
		// (set) Token: 0x06001BF2 RID: 7154
		public extern string TransitionLengthTableName { get; set; }

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x06001BF3 RID: 7155
		// (set) Token: 0x06001BF4 RID: 7156
		public extern string AttainmentMethod { get; set; }

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06001BF5 RID: 7157
		// (set) Token: 0x06001BF6 RID: 7158
		public extern double SpiralPercentForSC { get; set; }

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x06001BF7 RID: 7159
		// (set) Token: 0x06001BF8 RID: 7160
		public extern double TangentPercentForTC { get; set; }

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06001BF9 RID: 7161
		// (set) Token: 0x06001BFA RID: 7162
		public extern double LaneWidth { get; set; }

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x06001BFB RID: 7163
		// (set) Token: 0x06001BFC RID: 7164
		public extern int LeftLanesCount { get; set; }

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x06001BFD RID: 7165
		// (set) Token: 0x06001BFE RID: 7166
		public extern int RightLanesCount { get; set; }

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x06001BFF RID: 7167
		// (set) Token: 0x06001C00 RID: 7168
		public extern double WheelbaseLength { get; set; }

		// Token: 0x0400174A RID: 5962
		private int <SyntheticNonEmptyStructMarker>;
	}
}
