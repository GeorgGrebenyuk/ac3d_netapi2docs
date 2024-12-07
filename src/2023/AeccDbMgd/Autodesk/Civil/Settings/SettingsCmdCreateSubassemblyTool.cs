using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x020010F8 RID: 4344
	public sealed class SettingsCmdCreateSubassemblyTool : SettingsSubassembly
	{
		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x06002361 RID: 9057
		public extern SettingsCmdCreateSubassemblyTool.SettingsCmdSubassemblyOptions SubassemblyOptions { get; }

		// Token: 0x020010F9 RID: 4345
		public sealed class SettingsCmdSubassemblyOptions : TreeOidWrapper
		{
			// Token: 0x17001248 RID: 4680
			// (get) Token: 0x06002362 RID: 9058
			public extern PropertyEnum<RoadwaySideType> CurrentSide { get; }

			// Token: 0x17001247 RID: 4679
			// (get) Token: 0x06002363 RID: 9059
			public extern PropertyBoolean AutoDetectSide { get; }

			// Token: 0x17001246 RID: 4678
			// (get) Token: 0x06002364 RID: 9060
			public extern PropertyEnum<AssemblyGroupNameType> AssemblyGroupName { get; }

			// Token: 0x17001245 RID: 4677
			// (get) Token: 0x06002365 RID: 9061
			public extern PropertyBoolean AssemblyGroupNamePrompt { get; }

			// Token: 0x17001244 RID: 4676
			// (get) Token: 0x06002366 RID: 9062
			public extern PropertyEnum<SubassemblyNameType> SubassemblyName { get; }

			// Token: 0x17001243 RID: 4675
			// (get) Token: 0x06002367 RID: 9063
			public extern PropertyBoolean SubassemblyNamePrompt { get; }
		}
	}
}
