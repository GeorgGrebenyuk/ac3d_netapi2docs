using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000B9F RID: 2975
	public class SettingsCorridor : SettingsAmbient
	{
		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x0600164E RID: 5710
		public extern SettingsCorridor.SettingsStyles Styles { get; }

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x0600164F RID: 5711
		public extern SettingsCorridor.SettingsNameFormat NameFormat { get; }

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06001650 RID: 5712
		public extern SettingsCorridor.SettingsRegionHighlightGraphics RegionHighlightGraphics { get; }

		// Token: 0x0200110A RID: 4362
		public sealed class SettingsStyles : TreeOidWrapper
		{
			// Token: 0x17001289 RID: 4745
			// (get) Token: 0x06002396 RID: 9110
			public extern PropertyString Alignment { get; }

			// Token: 0x17001288 RID: 4744
			// (get) Token: 0x06002397 RID: 9111
			public extern PropertyObjectId AlignmentStyleId { get; }

			// Token: 0x17001287 RID: 4743
			// (get) Token: 0x06002398 RID: 9112
			public extern PropertyString SlopePattern { get; }

			// Token: 0x17001286 RID: 4742
			// (get) Token: 0x06002399 RID: 9113
			public extern PropertyObjectId SlopePatternStyleId { get; }

			// Token: 0x17001285 RID: 4741
			// (get) Token: 0x0600239A RID: 9114
			public extern PropertyString CorridorSurface { get; }

			// Token: 0x17001284 RID: 4740
			// (get) Token: 0x0600239B RID: 9115
			public extern PropertyObjectId CorridorSurfaceStyleId { get; }

			// Token: 0x17001283 RID: 4739
			// (get) Token: 0x0600239C RID: 9116
			public extern PropertyString Corridor { get; }

			// Token: 0x17001282 RID: 4738
			// (get) Token: 0x0600239D RID: 9117
			public extern PropertyObjectId CorridorStyleId { get; }

			// Token: 0x17001281 RID: 4737
			// (get) Token: 0x0600239E RID: 9118
			public extern PropertyString Profile { get; }

			// Token: 0x17001280 RID: 4736
			// (get) Token: 0x0600239F RID: 9119
			public extern PropertyObjectId ProfileStyleId { get; }

			// Token: 0x1700127F RID: 4735
			// (get) Token: 0x060023A0 RID: 9120
			public extern PropertyString ProfileLabelSet { get; }

			// Token: 0x1700127E RID: 4734
			// (get) Token: 0x060023A1 RID: 9121
			public extern PropertyObjectId ProfileLabelSetId { get; }

			// Token: 0x1700127D RID: 4733
			// (get) Token: 0x060023A2 RID: 9122
			public extern PropertyString RenderMaterial { get; }

			// Token: 0x1700127C RID: 4732
			// (get) Token: 0x060023A3 RID: 9123
			public extern PropertyString AlignmentLabelSet { get; }

			// Token: 0x1700127B RID: 4731
			// (get) Token: 0x060023A4 RID: 9124
			public extern PropertyObjectId AlignmentLabelSetId { get; }

			// Token: 0x1700127A RID: 4730
			// (get) Token: 0x060023A5 RID: 9125
			public extern PropertyString CorridorCodeSet { get; }

			// Token: 0x17001279 RID: 4729
			// (get) Token: 0x060023A6 RID: 9126
			public extern PropertyObjectId CorridorCodeSetId { get; }

			// Token: 0x17001278 RID: 4728
			// (get) Token: 0x060023A7 RID: 9127
			public extern PropertyString FeatureLine { get; }

			// Token: 0x17001277 RID: 4727
			// (get) Token: 0x060023A8 RID: 9128
			public extern PropertyObjectId FeatureLineStyleId { get; }
		}

		// Token: 0x0200110B RID: 4363
		public sealed class SettingsNameFormat : TreeOidWrapper
		{
			// Token: 0x17001290 RID: 4752
			// (get) Token: 0x060023A9 RID: 9129
			public extern PropertyString AlignmentFromFeatureLine { get; }

			// Token: 0x1700128F RID: 4751
			// (get) Token: 0x060023AA RID: 9130
			public extern PropertyString ProfileFromFeatureLine { get; }

			// Token: 0x1700128E RID: 4750
			// (get) Token: 0x060023AB RID: 9131
			public extern PropertyString Corridor { get; }

			// Token: 0x1700128D RID: 4749
			// (get) Token: 0x060023AC RID: 9132
			public extern PropertyString CorridorSurface { get; }

			// Token: 0x1700128C RID: 4748
			// (get) Token: 0x060023AD RID: 9133
			public extern PropertyString CorridorBaseline { get; }

			// Token: 0x1700128B RID: 4747
			// (get) Token: 0x060023AE RID: 9134
			public extern PropertyString CorridorRegion { get; }

			// Token: 0x1700128A RID: 4746
			// (get) Token: 0x060023AF RID: 9135
			public extern PropertyString FeatureLine { get; }
		}

		// Token: 0x0200110C RID: 4364
		public sealed class SettingsRegionHighlightGraphics : TreeOidWrapper
		{
			// Token: 0x1700129C RID: 4764
			// (get) Token: 0x060023B0 RID: 9136
			public extern PropertyBoolean HighlightBaseline { get; }

			// Token: 0x1700129B RID: 4763
			// (get) Token: 0x060023B1 RID: 9137
			public extern PropertyColor BaselineColor { get; }

			// Token: 0x1700129A RID: 4762
			// (get) Token: 0x060023B2 RID: 9138
			public extern PropertyEnum<LineWeight> BaselineLineweight { get; }

			// Token: 0x17001299 RID: 4761
			// (get) Token: 0x060023B3 RID: 9139
			public extern PropertyBoolean HighlightRegionBoundary { get; }

			// Token: 0x17001298 RID: 4760
			// (get) Token: 0x060023B4 RID: 9140
			public extern PropertyColor RegionBoundaryColor { get; }

			// Token: 0x17001297 RID: 4759
			// (get) Token: 0x060023B5 RID: 9141
			public extern PropertyEnum<LineWeight> RegionBoundaryLineweight { get; }

			// Token: 0x17001296 RID: 4758
			// (get) Token: 0x060023B6 RID: 9142
			public extern PropertyBoolean HighlightHorizontalTargets { get; }

			// Token: 0x17001295 RID: 4757
			// (get) Token: 0x060023B7 RID: 9143
			public extern PropertyColor HorizontalTargetsColor { get; }

			// Token: 0x17001294 RID: 4756
			// (get) Token: 0x060023B8 RID: 9144
			public extern PropertyEnum<LineWeight> HorizontalTargetsLineweight { get; }

			// Token: 0x17001293 RID: 4755
			// (get) Token: 0x060023B9 RID: 9145
			public extern PropertyBoolean HighlightInteriorAssemblies { get; }

			// Token: 0x17001292 RID: 4754
			// (get) Token: 0x060023BA RID: 9146
			public extern PropertyColor InteriorAssembliesColor { get; }

			// Token: 0x17001291 RID: 4753
			// (get) Token: 0x060023BB RID: 9147
			public extern PropertyEnum<LineWeight> InteriorAssembliesLineweight { get; }
		}
	}
}
