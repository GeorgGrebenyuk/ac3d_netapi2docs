using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x020001C1 RID: 449
	public sealed class SettingsCmdRunDesignCheck : SettingsPressureNetwork
	{
		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060001F1 RID: 497
		public extern SettingsCmdRunDesignCheck.SettingsCmdDesignCheckOption DesignCheckOption { get; }

		// Token: 0x020001C2 RID: 450
		public sealed class SettingsCmdDesignCheckOption : TreeOidWrapper
		{
			// Token: 0x1700010B RID: 267
			// (get) Token: 0x060001F2 RID: 498
			public extern PropertyBoolean UseDeflectionValidation { get; }

			// Token: 0x1700010A RID: 266
			// (get) Token: 0x060001F3 RID: 499
			public extern PropertyBoolean UseDiameterValidation { get; }

			// Token: 0x17000109 RID: 265
			// (get) Token: 0x060001F4 RID: 500
			public extern PropertyBoolean UseOpenConnectionValidation { get; }

			// Token: 0x17000108 RID: 264
			// (get) Token: 0x060001F5 RID: 501
			public extern PropertyBoolean UseRadiusOfCurvatureValidation { get; }
		}
	}
}
