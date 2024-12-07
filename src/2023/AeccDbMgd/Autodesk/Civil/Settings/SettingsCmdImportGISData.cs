using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000BF7 RID: 3063
	public sealed class SettingsCmdImportGISData : Autodesk.Civil.Settings.SettingsGeneral
	{
		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06001724 RID: 5924
		public extern SettingsCmdImportGISData.SettingsCmdPipeNetwork PipeNetwork { get; }

		// Token: 0x02000BF8 RID: 3064
		public sealed class SettingsCmdPipeNetwork : TreeOidWrapper
		{
			// Token: 0x17000A29 RID: 2601
			// (get) Token: 0x06001725 RID: 5925
			public extern PropertyString NetworkNameTemplate { get; }

			// Token: 0x17000A28 RID: 2600
			// (get) Token: 0x06001726 RID: 5926
			public extern PropertyString PipeNameTemplate { get; }

			// Token: 0x17000A27 RID: 2599
			// (get) Token: 0x06001727 RID: 5927
			public extern PropertyString StructureNameTemplate { get; }

			// Token: 0x17000A26 RID: 2598
			// (get) Token: 0x06001728 RID: 5928
			public extern PropertyString PartsList { get; }

			// Token: 0x17000A25 RID: 2597
			// (get) Token: 0x06001729 RID: 5929
			public extern PropertyObjectId PartsListId { get; }

			// Token: 0x17000A24 RID: 2596
			// (get) Token: 0x0600172A RID: 5930
			public extern PropertyString PipeLabelStyle { get; }

			// Token: 0x17000A23 RID: 2595
			// (get) Token: 0x0600172B RID: 5931
			public extern PropertyObjectId PipeLabelStyleId { get; }

			// Token: 0x17000A22 RID: 2594
			// (get) Token: 0x0600172C RID: 5932
			public extern PropertyString StructureLabelStyle { get; }

			// Token: 0x17000A21 RID: 2593
			// (get) Token: 0x0600172D RID: 5933
			public extern PropertyObjectId StructureLabelStyleId { get; }

			// Token: 0x17000A20 RID: 2592
			// (get) Token: 0x0600172E RID: 5934
			public extern PropertyDouble SnappingTolerance { get; }
		}
	}
}
