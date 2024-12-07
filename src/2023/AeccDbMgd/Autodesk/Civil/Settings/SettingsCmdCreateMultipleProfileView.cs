using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D69 RID: 3433
	public sealed class SettingsCmdCreateMultipleProfileView : SettingsProfileView
	{
		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x060018B8 RID: 6328
		public extern SettingsCmdCreateMultipleProfileView.SettingsCmdMultipleProfileViewCreation MultipleProfileViewCreation { get; }

		// Token: 0x02000D6A RID: 3434
		public sealed class SettingsCmdMultipleProfileViewCreation : TreeOidWrapper
		{
			// Token: 0x17000BB6 RID: 2998
			// (get) Token: 0x060018B9 RID: 6329
			public extern PropertyDouble DefaultProfileViewLength { get; }

			// Token: 0x17000BB5 RID: 2997
			// (get) Token: 0x060018BA RID: 6330
			public extern PropertyDouble DefaultProfileViewHeight { get; }

			// Token: 0x17000BB4 RID: 2996
			// (get) Token: 0x060018BB RID: 6331
			public extern PropertyEnum<ProfileViewDatumType> ProfileViewDatumBy { get; }

			// Token: 0x17000BB3 RID: 2995
			// (get) Token: 0x060018BC RID: 6332
			public extern PropertyEnum<ProfileViewPlotType> PlotPattern { get; }

			// Token: 0x17000BB2 RID: 2994
			// (get) Token: 0x060018BD RID: 6333
			public extern PropertyInt ProfileViewsInRowOrColumn { get; }

			// Token: 0x17000BB1 RID: 2993
			// (get) Token: 0x060018BE RID: 6334
			public extern PropertyEnum<ProfileViewStartCornerType> StartCorner { get; }

			// Token: 0x17000BB0 RID: 2992
			// (get) Token: 0x060018BF RID: 6335
			public extern PropertyDouble ColumnSpacing { get; }

			// Token: 0x17000BAF RID: 2991
			// (get) Token: 0x060018C0 RID: 6336
			public extern PropertyDouble RowSpacing { get; }
		}
	}
}
