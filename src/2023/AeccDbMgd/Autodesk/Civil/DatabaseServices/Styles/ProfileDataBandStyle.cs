using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000095 RID: 149
	[Wrapper("AeccDbGraphStyleProfileDataBands")]
	public sealed class ProfileDataBandStyle : BandStyle
	{
		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000689 RID: 1673
		public override extern BandType BandType { get; }

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x0600068A RID: 1674
		public override extern ObjectId TitleTextLabelStyleId { get; }

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x0600068B RID: 1675
		public extern ObjectId MajorIncrementLabelStyleId { get; }

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x0600068C RID: 1676
		public extern ObjectId MinorIncrementLabelStyleId { get; }

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x0600068D RID: 1677
		public extern ObjectId HGPLabelStyleId { get; }

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x0600068E RID: 1678
		public extern ObjectId VGPLabelStyleId { get; }

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x0600068F RID: 1679
		public extern ObjectId StationEquationLabelStyleId { get; }

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000690 RID: 1680
		public extern ObjectId IncrementalDistanceLabelStyleId { get; }

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000691 RID: 1681
		public extern BandTickStyle MajorIncrementTickStyle { get; }

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000692 RID: 1682
		public extern BandTickStyle MinorIncrementTickStyle { get; }

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000693 RID: 1683
		public extern BandTickStyle HGPTickStyle { get; }

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000694 RID: 1684
		public extern BandTickStyle VGPTickStyle { get; }

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000695 RID: 1685
		public extern BandTickStyle StationEquationTickStyle { get; }

		// Token: 0x06000696 RID: 1686
		public extern DisplayStyle GetDisplayStylePlan(ProfileDataDisplayStyleType type);
	}
}
