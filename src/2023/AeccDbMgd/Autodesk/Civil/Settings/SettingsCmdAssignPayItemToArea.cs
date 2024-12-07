using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02001101 RID: 4353
	public sealed class SettingsCmdAssignPayItemToArea : SettingsQuantityTakeoff
	{
		// Token: 0x1700125E RID: 4702
		// (get) Token: 0x0600237D RID: 9085
		public extern SettingsCmdAssignPayItemToArea.SettingsCmdAssignPayItemToAreaOptions AssignPayItemToAreaOption { get; }

		// Token: 0x02001102 RID: 4354
		public sealed class SettingsCmdAssignPayItemToAreaOptions : TreeOidWrapper
		{
			// Token: 0x17001261 RID: 4705
			// (get) Token: 0x0600237E RID: 9086
			public extern PropertyBoolean UseAcadLayerAndColor { get; }

			// Token: 0x17001260 RID: 4704
			// (get) Token: 0x0600237F RID: 9087
			public extern PropertyLayer LayerForHatch { get; }

			// Token: 0x1700125F RID: 4703
			// (get) Token: 0x06002380 RID: 9088
			public extern PropertyColor ColorForHatch { get; }
		}
	}
}
