using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x020010E0 RID: 4320
	public sealed class SettingsCmdCreateProfileFromCorridor : SettingsCorridor
	{
		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x060022F4 RID: 8948
		public extern SettingsCmdCreateProfileFromCorridor.SettingsCmdCriteriaBasedDesignOptions CriteriaBasedDesignOptions { get; }

		// Token: 0x020010E1 RID: 4321
		public sealed class SettingsCmdCriteriaBasedDesignOptions : TreeOidWrapper
		{
			// Token: 0x170011D9 RID: 4569
			// (get) Token: 0x060022F5 RID: 8949
			public extern PropertyBoolean UseDesignCriteriaFileOption { get; }

			// Token: 0x170011D8 RID: 4568
			// (get) Token: 0x060022F6 RID: 8950
			public extern PropertyBoolean UseDesignChecksOption { get; }

			// Token: 0x170011D7 RID: 4567
			// (get) Token: 0x060022F7 RID: 8951
			public extern PropertyString DefaultDesignCheckSet { get; }

			// Token: 0x170011D6 RID: 4566
			// (get) Token: 0x060022F8 RID: 8952
			public extern PropertyObjectId DefaultDesignCheckSetId { get; }
		}
	}
}
