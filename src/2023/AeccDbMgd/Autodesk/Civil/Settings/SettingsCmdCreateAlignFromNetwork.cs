using System;
using Autodesk.Civil.DatabaseServices;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000FD2 RID: 4050
	public sealed class SettingsCmdCreateAlignFromNetwork : SettingsPipeNetwork
	{
		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x0600201C RID: 8220
		public extern SettingsCmdCreateAlignFromNetwork.SettingsCmdAlignmentTypeOption AlignmentTypeOption { get; }

		// Token: 0x02000FD3 RID: 4051
		public sealed class SettingsCmdAlignmentTypeOption : TreeOidWrapper
		{
			// Token: 0x1700100D RID: 4109
			// (get) Token: 0x0600201D RID: 8221
			public extern PropertyEnum<AlignmentType> AlignmentType { get; }
		}
	}
}
