using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000CCB RID: 3275
	public sealed class SettingsCmdCreateSheets : SettingsViewFrameGroup
	{
		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06001737 RID: 5943
		public extern SettingsCmdCreateSheets.SettingsCmdSheetCreation SheetCreation { get; }

		// Token: 0x02000CCC RID: 3276
		public sealed class SettingsCmdSheetCreation : TreeOidWrapper
		{
			// Token: 0x17000A36 RID: 2614
			// (get) Token: 0x06001738 RID: 5944
			public extern PropertyEnum<SheetCreateType> SheetCreateMethod { get; }

			// Token: 0x17000A35 RID: 2613
			// (get) Token: 0x06001739 RID: 5945
			public extern PropertyInt NumberOfLayoutsPerDrawing { get; }

			// Token: 0x17000A34 RID: 2612
			// (get) Token: 0x0600173A RID: 5946
			public extern PropertyBoolean AlignNorthArrow { get; }

			// Token: 0x17000A33 RID: 2611
			// (get) Token: 0x0600173B RID: 5947
			public extern PropertyString NorthArrowBlockName { get; }

			// Token: 0x17000A32 RID: 2610
			// (get) Token: 0x0600173C RID: 5948
			public extern PropertyBoolean UseExistingSheetSet { get; }

			// Token: 0x17000A31 RID: 2609
			// (get) Token: 0x0600173D RID: 5949
			public extern PropertyString ExistingSheetSetName { get; }

			// Token: 0x17000A30 RID: 2608
			// (get) Token: 0x0600173E RID: 5950
			public extern PropertyBoolean AddNetworkLabels { get; }

			// Token: 0x17000A2F RID: 2607
			// (get) Token: 0x0600173F RID: 5951
			public extern PropertyBoolean AddToVault { get; }

			// Token: 0x17000A2E RID: 2606
			// (get) Token: 0x06001740 RID: 5952
			public extern PropertyEnum<PlanViewAlignType> AlignProfileAndPlanViewType { get; }
		}
	}
}
