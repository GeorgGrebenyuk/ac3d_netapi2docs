using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000BA0 RID: 2976
	public sealed class SettingsCmdFeatureLinesFromCorridor : SettingsCorridor
	{
		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06001651 RID: 5713
		public extern SettingsCmdFeatureLinesFromCorridor.SettingsCmdFeatureLineCreation FeatureLineCreation { get; }

		// Token: 0x02000BA1 RID: 2977
		public sealed class SettingsCmdFeatureLineCreation : TreeOidWrapper
		{
			// Token: 0x170009C0 RID: 2496
			// (get) Token: 0x06001652 RID: 5714
			public extern PropertyBoolean FeatureLineName { get; }

			// Token: 0x170009BF RID: 2495
			// (get) Token: 0x06001653 RID: 5715
			public extern PropertyBoolean UseFeatureLineStyle { get; }

			// Token: 0x170009BE RID: 2494
			// (get) Token: 0x06001654 RID: 5716
			public extern PropertyEnum<FeatureLineLayerSettingType> LayerSetting { get; }

			// Token: 0x170009BD RID: 2493
			// (get) Token: 0x06001655 RID: 5717
			public extern PropertyBoolean CreateDynamicLink { get; }

			// Token: 0x170009BC RID: 2492
			// (get) Token: 0x06001656 RID: 5718
			public extern PropertyBoolean SmoothTheFeatureLine { get; }

			// Token: 0x170009BB RID: 2491
			// (get) Token: 0x06001657 RID: 5719
			public extern PropertyDouble HorizontalDeviation { get; }

			// Token: 0x170009BA RID: 2490
			// (get) Token: 0x06001658 RID: 5720
			public extern PropertyDouble InclusionDistance { get; }

			// Token: 0x170009B9 RID: 2489
			// (get) Token: 0x06001659 RID: 5721
			public extern PropertyDouble WeedingDistance { get; }
		}
	}
}
