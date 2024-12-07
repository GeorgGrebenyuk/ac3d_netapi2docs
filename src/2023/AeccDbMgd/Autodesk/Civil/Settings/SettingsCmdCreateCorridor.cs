using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x020010DC RID: 4316
	public sealed class SettingsCmdCreateCorridor : SettingsCorridor
	{
		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x060022E3 RID: 8931
		public extern SettingsCmdCreateCorridor.SettingsCmdAssemblyInsertion AssemblyInsertion { get; }

		// Token: 0x020010DD RID: 4317
		public sealed class SettingsCmdAssemblyInsertion : TreeOidWrapper
		{
			// Token: 0x170011D4 RID: 4564
			// (get) Token: 0x060022E4 RID: 8932
			public extern PropertyEnum<CorridorRegionLockType> CorridorRegionLockMode { get; }

			// Token: 0x170011D3 RID: 4563
			// (get) Token: 0x060022E5 RID: 8933
			public extern PropertyDouble FrequencyAlongTangents { get; }

			// Token: 0x170011D2 RID: 4562
			// (get) Token: 0x060022E6 RID: 8934
			public extern PropertyEnum<CorridorAlongCurveOption> CorridorAlongCurvesOption { get; }

			// Token: 0x170011D1 RID: 4561
			// (get) Token: 0x060022E7 RID: 8935
			public extern PropertyDouble FrequencyAlongCurves { get; }

			// Token: 0x170011D0 RID: 4560
			// (get) Token: 0x060022E8 RID: 8936
			public extern PropertyDouble MODAlongCurves { get; }

			// Token: 0x170011CF RID: 4559
			// (get) Token: 0x060022E9 RID: 8937
			public extern PropertyDouble FrequencyAlongSpirals { get; }

			// Token: 0x170011CE RID: 4558
			// (get) Token: 0x060022EA RID: 8938
			public extern PropertyBoolean HorizontalGeometryPoints { get; }

			// Token: 0x170011CD RID: 4557
			// (get) Token: 0x060022EB RID: 8939
			public extern PropertyBoolean SuperelevationCriticalPoints { get; }

			// Token: 0x170011CC RID: 4556
			// (get) Token: 0x060022EC RID: 8940
			public extern PropertyBoolean ProfileGeometryPoints { get; }

			// Token: 0x170011CB RID: 4555
			// (get) Token: 0x060022ED RID: 8941
			public extern PropertyBoolean ProfileHighLowPoints { get; }

			// Token: 0x170011CA RID: 4554
			// (get) Token: 0x060022EE RID: 8942
			public extern PropertyBoolean OffsetTargetGeometryPoints { get; }

			// Token: 0x170011C9 RID: 4553
			// (get) Token: 0x060022EF RID: 8943
			public extern PropertyBoolean OffsetTargetStartEnd { get; }

			// Token: 0x170011C8 RID: 4552
			// (get) Token: 0x060022F0 RID: 8944
			public extern PropertyEnum<CorridorAlongOffsetTargetCurveOption> CorridorAlongOffsetTargetCurvesOption { get; }

			// Token: 0x170011C7 RID: 4551
			// (get) Token: 0x060022F1 RID: 8945
			public extern PropertyDouble FrequencyAlongOffsetTargetCurves { get; }

			// Token: 0x170011C6 RID: 4550
			// (get) Token: 0x060022F2 RID: 8946
			public extern PropertyDouble MODAlongOffsetTargetCurves { get; }

			// Token: 0x170011C5 RID: 4549
			// (get) Token: 0x060022F3 RID: 8947
			public extern PropertyDouble FrequencyAlongProfileCurves { get; }
		}
	}
}
