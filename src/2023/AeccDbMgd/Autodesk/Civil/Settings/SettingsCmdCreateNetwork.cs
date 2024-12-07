using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000FDA RID: 4058
	public sealed class SettingsCmdCreateNetwork : SettingsPipeNetwork
	{
		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x06002023 RID: 8227
		public extern SettingsCmdCreateNetwork.SettingsCmdLabelNewParts LabelNewParts { get; }

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x06002024 RID: 8228
		public extern PropertyEnum<NetworkDefaultLayoutCommandType> DefaultLayoutCommand { get; }

		// Token: 0x02000FDB RID: 4059
		public sealed class SettingsCmdLabelNewParts : TreeOidWrapper
		{
			// Token: 0x17001019 RID: 4121
			// (get) Token: 0x06002025 RID: 8229
			public extern PropertyBoolean PipeInPlan { get; }

			// Token: 0x17001018 RID: 4120
			// (get) Token: 0x06002026 RID: 8230
			public extern PropertyBoolean PipeProfile { get; }

			// Token: 0x17001017 RID: 4119
			// (get) Token: 0x06002027 RID: 8231
			public extern PropertyBoolean CrossPipeProfile { get; }

			// Token: 0x17001016 RID: 4118
			// (get) Token: 0x06002028 RID: 8232
			public extern PropertyBoolean StructureInPlan { get; }

			// Token: 0x17001015 RID: 4117
			// (get) Token: 0x06002029 RID: 8233
			public extern PropertyBoolean StructureProfile { get; }
		}
	}
}
