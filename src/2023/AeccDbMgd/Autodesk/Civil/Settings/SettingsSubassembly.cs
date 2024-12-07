using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x020010F7 RID: 4343
	public class SettingsSubassembly : SettingsAmbient
	{
		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x0600235F RID: 9055
		public extern SettingsSubassembly.SettingsNameFormat NameFormat { get; }

		// Token: 0x17001240 RID: 4672
		// (get) Token: 0x06002360 RID: 9056
		public extern SettingsSubassembly.SettingsDefaultStyles DefaultStyles { get; }

		// Token: 0x02001111 RID: 4369
		public sealed class SettingsNameFormat : TreeOidWrapper
		{
			// Token: 0x170012BD RID: 4797
			// (get) Token: 0x060023DB RID: 9179
			public extern PropertyString CreateFromMacro { get; }

			// Token: 0x170012BC RID: 4796
			// (get) Token: 0x060023DC RID: 9180
			public extern PropertyString CreateFromEntities { get; }
		}

		// Token: 0x02001112 RID: 4370
		public sealed class SettingsDefaultStyles : TreeOidWrapper
		{
			// Token: 0x170012BF RID: 4799
			// (get) Token: 0x060023DD RID: 9181
			public extern PropertyString CodeSetStyle { get; }

			// Token: 0x170012BE RID: 4798
			// (get) Token: 0x060023DE RID: 9182
			public extern PropertyObjectId CodeSetStyleId { get; }
		}
	}
}
