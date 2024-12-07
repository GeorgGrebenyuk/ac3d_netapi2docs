using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000AF6 RID: 2806
	public class SettingsAmbient : TreeOidWrapper
	{
		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x060014D8 RID: 5336
		public extern SettingsAmbient.SettingsTime Time { get; }

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x060014D9 RID: 5337
		public extern SettingsAmbient.SettingsUnitless Unitless { get; }

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x060014DA RID: 5338
		public extern SettingsAmbient.SettingsAngle Angle { get; }

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x060014DB RID: 5339
		public extern SettingsAmbient.SettingsArea Area { get; }

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x060014DC RID: 5340
		public extern SettingsAmbient.SettingsCoordinate Coordinate { get; }

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x060014DD RID: 5341
		public extern SettingsAmbient.SettingsDimension Dimension { get; }

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x060014DE RID: 5342
		public extern SettingsAmbient.SettingsDirection Direction { get; }

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x060014DF RID: 5343
		public extern SettingsAmbient.SettingsDistance Distance { get; }

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x060014E0 RID: 5344
		public extern SettingsAmbient.SettingsElevation Elevation { get; }

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x060014E1 RID: 5345
		public extern SettingsAmbient.SettingsGeneral General { get; }

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x060014E2 RID: 5346
		public extern SettingsAmbient.SettingsGrade Grade { get; }

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x060014E3 RID: 5347
		public extern SettingsAmbient.SettingsGradeSlope GradeSlope { get; }

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x060014E4 RID: 5348
		public extern SettingsAmbient.SettingsGridCoordinate GridCoordinate { get; }

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x060014E5 RID: 5349
		public extern SettingsAmbient.SettingsLabeling Labeling { get; }

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x060014E6 RID: 5350
		public extern SettingsAmbient.SettingsLatLong LatLong { get; }

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x060014E7 RID: 5351
		public extern SettingsAmbient.SettingsStation Station { get; }

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x060014E8 RID: 5352
		public extern SettingsAmbient.SettingsAcceleration Acceleration { get; }

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x060014E9 RID: 5353
		public extern SettingsAmbient.SettingsTransparentCommands TransparentCommands { get; }

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x060014EA RID: 5354
		public extern SettingsAmbient.SettingsSlope Slope { get; }

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x060014EB RID: 5355
		public extern SettingsAmbient.SettingsSpeed Speed { get; }

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x060014EC RID: 5356
		public extern SettingsAmbient.SettingsVolume Volume { get; }

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x060014ED RID: 5357
		public extern SettingsAmbient.SettingsPressure Pressure { get; }

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x060014EE RID: 5358
		public extern SettingsAmbient.SettingsDegreeOfCurvature DegreeOfCurvature { get; }

		// Token: 0x060014EF RID: 5359
		protected extern SettingsAmbient(SettingsRoot root, string path);

		// Token: 0x02000AF7 RID: 2807
		public abstract class SettingsUnitlessNumber : TreeOidWrapper
		{
			// Token: 0x170008DB RID: 2267
			// (get) Token: 0x060014F0 RID: 5360
			public extern PropertyInt Precision { get; }

			// Token: 0x170008DA RID: 2266
			// (get) Token: 0x060014F1 RID: 5361
			public extern PropertyEnum<RoundingType> Rounding { get; }

			// Token: 0x170008D9 RID: 2265
			// (get) Token: 0x060014F2 RID: 5362
			public extern PropertyEnum<SignType> Sign { get; }

			// Token: 0x040014BB RID: 5307
			private int <SyntheticNonEmptyStructMarker>;
		}

		// Token: 0x02000AF8 RID: 2808
		public abstract class SettingsUnitNumber<TUnit> : SettingsAmbient.SettingsUnitlessNumber where TUnit : struct
		{
			// Token: 0x170008DC RID: 2268
			// (get) Token: 0x060014F3 RID: 5363
			public extern PropertyEnum<TUnit> Unit { get; }

			// Token: 0x040014BC RID: 5308
			private int <SyntheticNonEmptyStructMarker>;
		}

		// Token: 0x02000AF9 RID: 2809
		public abstract class SettingsFormatNumber<TFormat> : SettingsAmbient.SettingsUnitlessNumber where TFormat : struct
		{
			// Token: 0x170008DD RID: 2269
			// (get) Token: 0x060014F4 RID: 5364
			public extern PropertyEnum<TFormat> Format { get; }

			// Token: 0x040014BD RID: 5309
			private int <SyntheticNonEmptyStructMarker>;
		}

		// Token: 0x02000AFA RID: 2810
		public abstract class SettingsUnitFormatNumber<TUnit, TFormat> : SettingsAmbient.SettingsUnitlessNumber where TUnit : struct where TFormat : struct
		{
			// Token: 0x170008DF RID: 2271
			// (get) Token: 0x060014F5 RID: 5365
			public extern PropertyEnum<TFormat> Format { get; }

			// Token: 0x170008DE RID: 2270
			// (get) Token: 0x060014F6 RID: 5366
			public extern PropertyEnum<TUnit> Unit { get; }

			// Token: 0x040014BE RID: 5310
			private int <SyntheticNonEmptyStructMarker>;
		}

		// Token: 0x020010B5 RID: 4277
		public sealed class SettingsTime : TreeOidWrapper
		{
			// Token: 0x17001172 RID: 4466
			// (get) Token: 0x06002271 RID: 8817
			public extern PropertyEnum<TimeUnitType> Unit { get; }

			// Token: 0x17001171 RID: 4465
			// (get) Token: 0x06002272 RID: 8818
			public extern PropertyInt Precision { get; }

			// Token: 0x17001170 RID: 4464
			// (get) Token: 0x06002273 RID: 8819
			public extern PropertyEnum<RoundingType> Rounding { get; }
		}

		// Token: 0x020010B6 RID: 4278
		public sealed class SettingsUnitless : SettingsAmbient.SettingsUnitlessNumber
		{
		}

		// Token: 0x020010B7 RID: 4279
		public sealed class SettingsAngle : SettingsAmbient.SettingsUnitFormatNumber<AngleUnitType, AngleFormatType>
		{
			// Token: 0x17001174 RID: 4468
			// (get) Token: 0x06002274 RID: 8820
			public extern PropertyEnum<DropDecimalWholeType> DropDecimalForWholeNumbers { get; }

			// Token: 0x17001173 RID: 4467
			// (get) Token: 0x06002275 RID: 8821
			public extern PropertyEnum<DropLeadingZeroType> DropLeadingZerosForDegrees { get; }
		}

		// Token: 0x020010B8 RID: 4280
		public sealed class SettingsArea : SettingsAmbient.SettingsUnitNumber<AreaUnitType>
		{
		}

		// Token: 0x020010B9 RID: 4281
		public sealed class SettingsCoordinate : SettingsAmbient.SettingsUnitNumber<LinearUnitType>
		{
		}

		// Token: 0x020010BA RID: 4282
		public sealed class SettingsDimension : SettingsAmbient.SettingsUnitNumber<LinearUnitType>
		{
		}

		// Token: 0x020010BB RID: 4283
		public sealed class SettingsDirection : SettingsAmbient.SettingsUnitFormatNumber<AngleUnitType, AngleFormatType>
		{
			// Token: 0x1700117A RID: 4474
			// (get) Token: 0x06002276 RID: 8822
			public extern PropertyEnum<DirectionDisplayType> Direction { get; }

			// Token: 0x17001179 RID: 4473
			// (get) Token: 0x06002277 RID: 8823
			public extern PropertyEnum<DirectionNameDisplayType> Capitalization { get; }

			// Token: 0x17001178 RID: 4472
			// (get) Token: 0x06002278 RID: 8824
			public extern PropertyEnum<VectorMeasurementType> MeasurementType { get; }

			// Token: 0x17001177 RID: 4471
			// (get) Token: 0x06002279 RID: 8825
			public extern PropertyEnum<BearingQuadrantType> BearingQuadrant { get; }

			// Token: 0x17001176 RID: 4470
			// (get) Token: 0x0600227A RID: 8826
			public extern PropertyEnum<DropDecimalWholeType> DropDecimalForWholeNumbers { get; }

			// Token: 0x17001175 RID: 4469
			// (get) Token: 0x0600227B RID: 8827
			public extern PropertyEnum<DropLeadingZeroType> DropLeadingZerosForDegrees { get; }
		}

		// Token: 0x020010BC RID: 4284
		public sealed class SettingsDistance : SettingsAmbient.SettingsUnitNumber<LinearUnitType>
		{
		}

		// Token: 0x020010BD RID: 4285
		public sealed class SettingsElevation : SettingsAmbient.SettingsUnitNumber<LinearUnitType>
		{
		}

		// Token: 0x020010BE RID: 4286
		public sealed class SettingsGeneral : TreeOidWrapper
		{
			// Token: 0x17001181 RID: 4481
			// (get) Token: 0x0600227C RID: 8828
			public extern PropertyEnum<PlottedUnitDisplayType> PlottedUnitDisplay { get; }

			// Token: 0x17001180 RID: 4480
			// (get) Token: 0x0600227D RID: 8829
			public extern PropertyBoolean SaveCommandChangesToSettings { get; }

			// Token: 0x1700117F RID: 4479
			// (get) Token: 0x0600227E RID: 8830
			public extern PropertyBoolean ShowEventViewer { get; }

			// Token: 0x1700117E RID: 4478
			// (get) Token: 0x0600227F RID: 8831
			public extern PropertyBoolean ShowToolTips { get; }

			// Token: 0x1700117D RID: 4477
			// (get) Token: 0x06002280 RID: 8832
			public extern PropertyBoolean NewEntityToolTipState { get; }

			// Token: 0x1700117C RID: 4476
			// (get) Token: 0x06002281 RID: 8833
			public extern PropertyEnum<DrivingDirectionType> DrivingDirection { get; }

			// Token: 0x1700117B RID: 4475
			// (get) Token: 0x06002282 RID: 8834
			public extern PropertyBoolean IndependentLayerOn { get; }
		}

		// Token: 0x020010BF RID: 4287
		public sealed class SettingsGrade : SettingsAmbient.SettingsFormatNumber<GradeFormatType>
		{
		}

		// Token: 0x020010C0 RID: 4288
		public sealed class SettingsGradeSlope : SettingsAmbient.SettingsFormatNumber<GradeSlopeFormatType>
		{
		}

		// Token: 0x020010C1 RID: 4289
		public sealed class SettingsGridCoordinate : SettingsAmbient.SettingsUnitNumber<LinearUnitType>
		{
		}

		// Token: 0x020010C2 RID: 4290
		public sealed class SettingsLabeling : TreeOidWrapper
		{
			// Token: 0x17001182 RID: 4482
			// (get) Token: 0x06002283 RID: 8835
			public extern PropertyEnum<LabelingPromptType> PromptMethod { get; }
		}

		// Token: 0x020010C3 RID: 4291
		public sealed class SettingsLatLong : SettingsAmbient.SettingsUnitFormatNumber<AngleUnitType, AngleFormatType>
		{
			// Token: 0x17001186 RID: 4486
			// (get) Token: 0x06002284 RID: 8836
			public extern PropertyEnum<LatLongDirectionType> Direction { get; }

			// Token: 0x17001185 RID: 4485
			// (get) Token: 0x06002285 RID: 8837
			public extern PropertyEnum<DirectionNameDisplayType> Capitalization { get; }

			// Token: 0x17001184 RID: 4484
			// (get) Token: 0x06002286 RID: 8838
			public extern PropertyEnum<DropDecimalWholeType> DropDecimalForWholeNumbers { get; }

			// Token: 0x17001183 RID: 4483
			// (get) Token: 0x06002287 RID: 8839
			public extern PropertyEnum<DropLeadingZeroType> DropLeadingZerosForDegrees { get; }
		}

		// Token: 0x020010C4 RID: 4292
		public sealed class SettingsStation : SettingsAmbient.SettingsUnitFormatNumber<LinearUnitType, StationFormatType>
		{
			// Token: 0x1700118B RID: 4491
			// (get) Token: 0x06002288 RID: 8840
			public extern PropertyEnum<StationDelimiterCharacterType> StationDelimiterCharacter { get; }

			// Token: 0x1700118A RID: 4490
			// (get) Token: 0x06002289 RID: 8841
			public extern PropertyEnum<StationDelimiterPositionType> StationDelimiterPosition { get; }

			// Token: 0x17001189 RID: 4489
			// (get) Token: 0x0600228A RID: 8842
			public extern PropertyEnum<DropDecimalWholeType> DropDecimalForWholeNumbers { get; }

			// Token: 0x17001188 RID: 4488
			// (get) Token: 0x0600228B RID: 8843
			public extern PropertyEnum<DropLeadingZeroType> DropLeadingZerosRightOfStationCharacter { get; }

			// Token: 0x17001187 RID: 4487
			// (get) Token: 0x0600228C RID: 8844
			public extern PropertyInt MinimumDisplayWidth { get; }
		}

		// Token: 0x020010C5 RID: 4293
		public sealed class SettingsAcceleration : SettingsAmbient.SettingsUnitNumber<AccelerationUnitType>
		{
		}

		// Token: 0x020010C6 RID: 4294
		public sealed class SettingsTransparentCommands : TreeOidWrapper
		{
			// Token: 0x1700118F RID: 4495
			// (get) Token: 0x0600228D RID: 8845
			public extern PropertyBoolean PromptFor3DPoints { get; }

			// Token: 0x1700118E RID: 4494
			// (get) Token: 0x0600228E RID: 8846
			public extern PropertyBoolean PromptForYBeforeX { get; }

			// Token: 0x1700118D RID: 4493
			// (get) Token: 0x0600228F RID: 8847
			public extern PropertyBoolean PromptForEastingThenNorthing { get; }

			// Token: 0x1700118C RID: 4492
			// (get) Token: 0x06002290 RID: 8848
			public extern PropertyBoolean PromptForLongitudeThenLatitude { get; }
		}

		// Token: 0x020010C7 RID: 4295
		public sealed class SettingsSlope : SettingsAmbient.SettingsFormatNumber<SlopeFormatType>
		{
		}

		// Token: 0x020010C8 RID: 4296
		public sealed class SettingsSpeed : SettingsAmbient.SettingsUnitNumber<SpeedUnitType>
		{
		}

		// Token: 0x020010C9 RID: 4297
		public sealed class SettingsVolume : SettingsAmbient.SettingsUnitNumber<VolumeUnitType>
		{
		}

		// Token: 0x020010CA RID: 4298
		public sealed class SettingsPressure : SettingsAmbient.SettingsUnitNumber<PressureUnitType>
		{
		}

		// Token: 0x020010CB RID: 4299
		public sealed class SettingsDegreeOfCurvature : TreeOidWrapper
		{
			// Token: 0x17001191 RID: 4497
			// (get) Token: 0x06002291 RID: 8849
			public extern PropertyDouble UnitChordLength { get; }

			// Token: 0x17001190 RID: 4496
			// (get) Token: 0x06002292 RID: 8850
			public extern PropertyDouble UnitArcLength { get; }
		}
	}
}
