using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000056 RID: 86
	public class MultipleProfileViewsCreationOptions
	{
		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600037E RID: 894
		// (set) Token: 0x0600037F RID: 895
		public extern double LengthOfEachView { get; set; }

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000380 RID: 896
		// (set) Token: 0x06000381 RID: 897
		public extern ProfileViewPlotType DrawOrder { get; set; }

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000382 RID: 898
		// (set) Token: 0x06000383 RID: 899
		public extern int MaxViewInRowOrColumn { get; set; }

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000384 RID: 900
		// (set) Token: 0x06000385 RID: 901
		public extern ProfileViewStartCornerType StartCorner { get; set; }

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000386 RID: 902
		// (set) Token: 0x06000387 RID: 903
		public extern double GapBetweenViewsInRow { get; set; }

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000388 RID: 904
		// (set) Token: 0x06000389 RID: 905
		public extern double GapBetweenViewsInColumn { get; set; }

		// Token: 0x0600038A RID: 906
		public extern MultipleProfileViewsCreationOptions();

		// Token: 0x040002F7 RID: 759
		private int <SyntheticNonEmptyStructMarker>;
	}
}
