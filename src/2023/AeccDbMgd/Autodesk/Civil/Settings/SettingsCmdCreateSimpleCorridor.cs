using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x020010E2 RID: 4322
	public sealed class SettingsCmdCreateSimpleCorridor : SettingsCorridor
	{
		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x060022F9 RID: 8953
		public extern SettingsCmdCreateSimpleCorridor.SettingsCmdAssemblyInsertion AssemblyInsertion { get; }

		// Token: 0x020010E3 RID: 4323
		public sealed class SettingsCmdAssemblyInsertion : TreeOidWrapper
		{
			// Token: 0x170011E3 RID: 4579
			// (get) Token: 0x060022FA RID: 8954
			public extern PropertyEnum<CorridorRegionLockType> CorridorRegionLockMode { get; }

			// Token: 0x170011E2 RID: 4578
			// (get) Token: 0x060022FB RID: 8955
			public extern PropertyDouble FrequencyAlongTangents { get; }

			// Token: 0x170011E1 RID: 4577
			// (get) Token: 0x060022FC RID: 8956
			public extern PropertyDouble FrequencyAlongCurves { get; }

			// Token: 0x170011E0 RID: 4576
			// (get) Token: 0x060022FD RID: 8957
			public extern PropertyDouble FrequencyAlongSpirals { get; }

			// Token: 0x170011DF RID: 4575
			// (get) Token: 0x060022FE RID: 8958
			public extern PropertyBoolean HorizontalGeometryPoints { get; }

			// Token: 0x170011DE RID: 4574
			// (get) Token: 0x060022FF RID: 8959
			public extern PropertyBoolean SuperelevationCriticalPoints { get; }

			// Token: 0x170011DD RID: 4573
			// (get) Token: 0x06002300 RID: 8960
			public extern PropertyBoolean ProfileGeometryPoints { get; }

			// Token: 0x170011DC RID: 4572
			// (get) Token: 0x06002301 RID: 8961
			public extern PropertyBoolean ProfileHighLowPoints { get; }

			// Token: 0x170011DB RID: 4571
			// (get) Token: 0x06002302 RID: 8962
			public extern PropertyDouble FrequencyAlongProfileCurves { get; }
		}
	}
}
