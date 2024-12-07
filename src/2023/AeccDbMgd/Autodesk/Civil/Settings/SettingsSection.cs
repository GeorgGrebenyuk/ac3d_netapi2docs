using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000DBA RID: 3514
	public sealed class SettingsSection : SettingsAmbient
	{
		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x06001A1A RID: 6682
		public extern SettingsSection.SettingsStyles Styles { get; }

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x06001A1B RID: 6683
		public extern SettingsSection.SettingsNameFormat NameFormat { get; }

		// Token: 0x02000DBB RID: 3515
		public sealed class SettingsStyles : TreeOidWrapper
		{
			// Token: 0x17000D13 RID: 3347
			// (get) Token: 0x06001A1C RID: 6684
			public extern PropertyString Section { get; }

			// Token: 0x17000D12 RID: 3346
			// (get) Token: 0x06001A1D RID: 6685
			public extern PropertyObjectId SectionStyleId { get; }
		}

		// Token: 0x02000DBC RID: 3516
		public sealed class SettingsNameFormat : TreeOidWrapper
		{
			// Token: 0x17000D14 RID: 3348
			// (get) Token: 0x06001A1E RID: 6686
			public extern PropertyString Section { get; }
		}
	}
}
