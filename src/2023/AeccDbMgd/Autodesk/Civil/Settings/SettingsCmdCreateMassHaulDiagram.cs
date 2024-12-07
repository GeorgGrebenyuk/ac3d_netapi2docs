using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D87 RID: 3463
	public sealed class SettingsCmdCreateMassHaulDiagram : SettingsMassHaulView
	{
		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x06001905 RID: 6405
		public new extern SettingsCmdCreateMassHaulDiagram.SettingsCmdMassHaulCreation MassHaulCreation { get; }

		// Token: 0x02000D88 RID: 3464
		public sealed class SettingsCmdMassHaulCreation : TreeOidWrapper
		{
			// Token: 0x17000BFE RID: 3070
			// (get) Token: 0x06001906 RID: 6406
			public extern PropertyDouble BorrowPitCapacity { get; }

			// Token: 0x17000BFD RID: 3069
			// (get) Token: 0x06001907 RID: 6407
			public extern PropertyDouble DumpSiteCapacity { get; }

			// Token: 0x17000BFC RID: 3068
			// (get) Token: 0x06001908 RID: 6408
			public extern PropertyDouble FreeHaulDistance { get; }
		}
	}
}
