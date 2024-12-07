using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D19 RID: 3353
	public sealed class SettingsCmdCreateParcelFromObjects : SettingsParcel
	{
		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x060017FF RID: 6143
		public extern SettingsCmdCreateParcelFromObjects.SettingsCmdConvertFromEntities ConvertFromEntities { get; }

		// Token: 0x02000D1A RID: 3354
		public sealed class SettingsCmdConvertFromEntities : TreeOidWrapper
		{
			// Token: 0x17000AF7 RID: 2807
			// (get) Token: 0x06001800 RID: 6144
			public extern PropertyBoolean EraseAllExistingEntities { get; }

			// Token: 0x17000AF6 RID: 2806
			// (get) Token: 0x06001801 RID: 6145
			public extern PropertyBoolean AutoAddSegmentLabels { get; }
		}
	}
}
