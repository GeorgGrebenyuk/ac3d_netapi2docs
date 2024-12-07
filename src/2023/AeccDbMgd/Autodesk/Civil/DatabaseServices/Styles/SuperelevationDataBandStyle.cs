using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000AB RID: 171
	[Wrapper("AeccDbGraphStyleSuperElevationBands")]
	public sealed class SuperelevationDataBandStyle : BandStyle
	{
		// Token: 0x1700030D RID: 781
		// (get) Token: 0x0600079F RID: 1951
		public override extern BandType BandType { get; }

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x060007A0 RID: 1952
		public override extern ObjectId TitleTextLabelStyleId { get; }

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x060007A1 RID: 1953
		public extern ObjectId NormalCrownLabelStyleId { get; }

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x060007A2 RID: 1954
		public extern ObjectId LevelCrownLabelStyleId { get; }

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x060007A3 RID: 1955
		public extern ObjectId ReverseCrownLabelStyleId { get; }

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x060007A4 RID: 1956
		public extern ObjectId FullSuperLabelStyleId { get; }

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x060007A5 RID: 1957
		public extern ObjectId ShoulderCriticalPointsLabelStyleId { get; }

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x060007A6 RID: 1958
		public extern ObjectId SlopeTransitionRegionLabelStyleId { get; }

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x060007A7 RID: 1959
		public extern BandTickStyle NormalCrownTickStyle { get; }

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x060007A8 RID: 1960
		public extern BandTickStyle LevelCrownTickStyle { get; }

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x060007A9 RID: 1961
		public extern BandTickStyle ReverseCrownTickStyle { get; }

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x060007AA RID: 1962
		public extern BandTickStyle FullSuperTickStyle { get; }

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x060007AB RID: 1963
		public extern BandTickStyle ShoulderCriticalPointsTickStyle { get; }

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x060007AC RID: 1964
		public extern BandTickStyle SlopeTransitionRegionTickStyle { get; }

		// Token: 0x060007AD RID: 1965
		public extern DisplayStyle GetDisplayStylePlan(SuperelevationDataDisplayStyleType type);
	}
}
