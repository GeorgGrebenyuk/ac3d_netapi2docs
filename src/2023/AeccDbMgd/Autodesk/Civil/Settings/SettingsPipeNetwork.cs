using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000FC4 RID: 4036
	public class SettingsPipeNetwork : SettingsAmbient
	{
		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x06002005 RID: 8197
		public extern SettingsPipeNetwork.SettingsStyles Styles { get; }

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x06002006 RID: 8198
		public extern SettingsPipeNetwork.SettingsNameFormat NameFormat { get; }

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x06002007 RID: 8199
		public extern SettingsPipeNetwork.SettingsRules Rules { get; }

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x06002008 RID: 8200
		public extern SettingsPipeNetwork.SettingsDefault Default { get; }

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x06002009 RID: 8201
		public extern SettingsPipeNetwork.SettingsStormSewersMigration StormSewersMigration { get; }

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x0600200A RID: 8202
		public extern SettingsPipeNetwork.SettingsProfileLabelPlacement ProfileLabelPlacement { get; }

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x0600200B RID: 8203
		public extern SettingsPipeNetwork.SettingsSectionLabelPlacement SectionLabelPlacement { get; }

		// Token: 0x02000FE6 RID: 4070
		public class SettingsStyles : TreeOidWrapper
		{
			// Token: 0x1700102F RID: 4143
			// (get) Token: 0x0600202A RID: 8234
			public extern PropertyString Interference { get; }

			// Token: 0x1700102E RID: 4142
			// (get) Token: 0x0600202B RID: 8235
			public extern PropertyObjectId InterferenceStyleId { get; }

			// Token: 0x1700102D RID: 4141
			// (get) Token: 0x0600202C RID: 8236
			public extern PropertyString Structure { get; }

			// Token: 0x1700102C RID: 4140
			// (get) Token: 0x0600202D RID: 8237
			public extern PropertyObjectId StructureStyleId { get; }

			// Token: 0x1700102B RID: 4139
			// (get) Token: 0x0600202E RID: 8238
			public extern PropertyString Pipe { get; }

			// Token: 0x1700102A RID: 4138
			// (get) Token: 0x0600202F RID: 8239
			public extern PropertyObjectId PipeStyleId { get; }

			// Token: 0x17001029 RID: 4137
			// (get) Token: 0x06002030 RID: 8240
			public extern PropertyString InterferenceRenderMaterial { get; }

			// Token: 0x17001028 RID: 4136
			// (get) Token: 0x06002031 RID: 8241
			public extern PropertyString StructurePlanLabel { get; }

			// Token: 0x17001027 RID: 4135
			// (get) Token: 0x06002032 RID: 8242
			public extern PropertyObjectId StructurePlanLabelStyleId { get; }

			// Token: 0x17001026 RID: 4134
			// (get) Token: 0x06002033 RID: 8243
			public extern PropertyString PipePlanLabel { get; }

			// Token: 0x17001025 RID: 4133
			// (get) Token: 0x06002034 RID: 8244
			public extern PropertyObjectId PipePlanLabelStyleId { get; }

			// Token: 0x17001024 RID: 4132
			// (get) Token: 0x06002035 RID: 8245
			public extern PropertyString StructureProfileLabel { get; }

			// Token: 0x17001023 RID: 4131
			// (get) Token: 0x06002036 RID: 8246
			public extern PropertyObjectId StructureProfileLabelStyleId { get; }

			// Token: 0x17001022 RID: 4130
			// (get) Token: 0x06002037 RID: 8247
			public extern PropertyString PipeProfileLabel { get; }

			// Token: 0x17001021 RID: 4129
			// (get) Token: 0x06002038 RID: 8248
			public extern PropertyObjectId PipeProfileLabelStyleId { get; }

			// Token: 0x17001020 RID: 4128
			// (get) Token: 0x06002039 RID: 8249
			public extern PropertyString StructureSectionLabel { get; }

			// Token: 0x1700101F RID: 4127
			// (get) Token: 0x0600203A RID: 8250
			public extern PropertyObjectId StructureSectionLabelStyleId { get; }

			// Token: 0x1700101E RID: 4126
			// (get) Token: 0x0600203B RID: 8251
			public extern PropertyString PipeSectionLabel { get; }

			// Token: 0x1700101D RID: 4125
			// (get) Token: 0x0600203C RID: 8252
			public extern PropertyObjectId PipeSectionLabelStyleId { get; }

			// Token: 0x1700101C RID: 4124
			// (get) Token: 0x0600203D RID: 8253
			public extern PropertyString RenderMaterial { get; }

			// Token: 0x1700101B RID: 4123
			// (get) Token: 0x0600203E RID: 8254
			public extern PropertyString PartsList { get; }

			// Token: 0x1700101A RID: 4122
			// (get) Token: 0x0600203F RID: 8255
			public extern PropertyObjectId PartsListId { get; }
		}

		// Token: 0x02000FE7 RID: 4071
		public class SettingsNameFormat : TreeOidWrapper
		{
			// Token: 0x17001035 RID: 4149
			// (get) Token: 0x06002040 RID: 8256
			public extern PropertyString InterferenceCheck { get; }

			// Token: 0x17001034 RID: 4148
			// (get) Token: 0x06002041 RID: 8257
			public extern PropertyString Network { get; }

			// Token: 0x17001033 RID: 4147
			// (get) Token: 0x06002042 RID: 8258
			public extern PropertyString Interference { get; }

			// Token: 0x17001032 RID: 4146
			// (get) Token: 0x06002043 RID: 8259
			public extern PropertyString AlignmentFromNetwork { get; }

			// Token: 0x17001031 RID: 4145
			// (get) Token: 0x06002044 RID: 8260
			public extern PropertyString Structure { get; }

			// Token: 0x17001030 RID: 4144
			// (get) Token: 0x06002045 RID: 8261
			public extern PropertyString Pipe { get; }
		}

		// Token: 0x02000FE8 RID: 4072
		public class SettingsRules : TreeOidWrapper
		{
			// Token: 0x17001039 RID: 4153
			// (get) Token: 0x06002046 RID: 8262
			public extern PropertyString Structure { get; }

			// Token: 0x17001038 RID: 4152
			// (get) Token: 0x06002047 RID: 8263
			public extern PropertyObjectId StructureStyleId { get; }

			// Token: 0x17001037 RID: 4151
			// (get) Token: 0x06002048 RID: 8264
			public extern PropertyString Pipe { get; }

			// Token: 0x17001036 RID: 4150
			// (get) Token: 0x06002049 RID: 8265
			public extern PropertyObjectId PipeStyleId { get; }
		}

		// Token: 0x02000FE9 RID: 4073
		public class SettingsDefault : TreeOidWrapper
		{
			// Token: 0x1700103A RID: 4154
			// (get) Token: 0x0600204A RID: 8266
			public extern PropertyBoolean UsePartListDescriptionForNewParts { get; }
		}

		// Token: 0x02000FEA RID: 4074
		public class SettingsStormSewersMigration : TreeOidWrapper
		{
			// Token: 0x1700103E RID: 4158
			// (get) Token: 0x0600204B RID: 8267
			public extern PropertyString PartMatching { get; }

			// Token: 0x1700103D RID: 4157
			// (get) Token: 0x0600204C RID: 8268
			public extern PropertyObjectId PartMatchingId { get; }

			// Token: 0x1700103C RID: 4156
			// (get) Token: 0x0600204D RID: 8269
			public extern PropertyString PartsListUsedForMigration { get; }

			// Token: 0x1700103B RID: 4155
			// (get) Token: 0x0600204E RID: 8270
			public extern PropertyObjectId PartsListIdUsedForMigration { get; }
		}

		// Token: 0x02000FEB RID: 4075
		public class SettingsProfileLabelPlacement : TreeOidWrapper
		{
			// Token: 0x17001045 RID: 4165
			// (get) Token: 0x0600204F RID: 8271
			public extern PropertyEnum<DimensionAnchorType> DimensionAnchorOptionForPipes { get; }

			// Token: 0x17001044 RID: 4164
			// (get) Token: 0x06002050 RID: 8272
			public extern PropertyDouble DimensionAnchorElevationValueForPipes { get; }

			// Token: 0x17001043 RID: 4163
			// (get) Token: 0x06002051 RID: 8273
			public extern PropertyDouble DimensionAnchorPlotHeightValueForPipes { get; }

			// Token: 0x17001042 RID: 4162
			// (get) Token: 0x06002052 RID: 8274
			public extern PropertyEnum<DimensionAnchorType> DimensionAnchorOptionForStructures { get; }

			// Token: 0x17001041 RID: 4161
			// (get) Token: 0x06002053 RID: 8275
			public extern PropertyDouble DimensionAnchorElevationValueForStructures { get; }

			// Token: 0x17001040 RID: 4160
			// (get) Token: 0x06002054 RID: 8276
			public extern PropertyDouble DimensionAnchorPlotHeightValueForStructures { get; }

			// Token: 0x1700103F RID: 4159
			// (get) Token: 0x06002055 RID: 8277
			public extern PropertyEnum<StructureProfileLabelPlacementType> StructureLabelPlacement { get; }
		}

		// Token: 0x02000FEC RID: 4076
		public class SettingsSectionLabelPlacement : TreeOidWrapper
		{
			// Token: 0x1700104D RID: 4173
			// (get) Token: 0x06002056 RID: 8278
			public extern PropertyEnum<DimensionAnchorType> DimensionAnchorOptionForPipes { get; }

			// Token: 0x1700104C RID: 4172
			// (get) Token: 0x06002057 RID: 8279
			public extern PropertyDouble DimensionAnchorElevationValueForPipes { get; }

			// Token: 0x1700104B RID: 4171
			// (get) Token: 0x06002058 RID: 8280
			public extern PropertyDouble DimensionAnchorPlotHeightValueForPipes { get; }

			// Token: 0x1700104A RID: 4170
			// (get) Token: 0x06002059 RID: 8281
			public extern PropertyEnum<DimensionAnchorType> DimensionAnchorOptionForStructures { get; }

			// Token: 0x17001049 RID: 4169
			// (get) Token: 0x0600205A RID: 8282
			public extern PropertyDouble DimensionAnchorElevationValueForStructures { get; }

			// Token: 0x17001048 RID: 4168
			// (get) Token: 0x0600205B RID: 8283
			public extern PropertyDouble DimensionAnchorPlotHeightValueForStructures { get; }

			// Token: 0x17001047 RID: 4167
			// (get) Token: 0x0600205C RID: 8284
			public extern PropertyEnum<StructureProfileLabelPlacementType> StructureLabelPlacement { get; }

			// Token: 0x17001046 RID: 4166
			// (get) Token: 0x0600205D RID: 8285
			public extern PropertyEnum<PipeSectionLabelPlacementType> PipeSectionLabel { get; }
		}
	}
}
