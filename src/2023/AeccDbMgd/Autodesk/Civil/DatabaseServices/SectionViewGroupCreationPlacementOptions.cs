using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200090B RID: 2315
	public class SectionViewGroupCreationPlacementOptions
	{
		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x060011C6 RID: 4550
		public extern PlacementOptionType PlacementOption { get; }

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x060011C7 RID: 4551
		public extern string TemplateFilePath { get; }

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x060011C8 RID: 4552
		public extern string LayoutName { get; }

		// Token: 0x060011C9 RID: 4553
		public extern void UseDraftPlacement();

		// Token: 0x060011CA RID: 4554
		public extern void UseProductionPlacement(string templateFilePath, string layoutName);

		// Token: 0x060011CB RID: 4555
		public extern string[] GetAvailableLayoutNames(string templateFilePath);

		// Token: 0x060011CC RID: 4556
		public extern SectionViewGroupCreationPlacementOptions();

		// Token: 0x04001313 RID: 4883
		private int <SyntheticNonEmptyStructMarker>;
	}
}
