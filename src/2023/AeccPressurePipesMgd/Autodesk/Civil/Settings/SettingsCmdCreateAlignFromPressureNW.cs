using System;
using Autodesk.Civil.DatabaseServices;

namespace Autodesk.Civil.Settings
{
	// Token: 0x020001B8 RID: 440
	public sealed class SettingsCmdCreateAlignFromPressureNW : SettingsPressureNetwork
	{
		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060001DF RID: 479
		public extern SettingsCmdCreateAlignFromPressureNW.SettingsCmdAlignmentTypeOption AlignmentTypeOption { get; }

		// Token: 0x020001B9 RID: 441
		public sealed class SettingsCmdAlignmentTypeOption : TreeOidWrapper
		{
			// Token: 0x170000F6 RID: 246
			// (get) Token: 0x060001E0 RID: 480
			public extern PropertyEnum<AlignmentType> AlignmentType { get; }
		}
	}
}
