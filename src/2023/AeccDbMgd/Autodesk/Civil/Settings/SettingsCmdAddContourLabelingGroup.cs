using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000CE2 RID: 3298
	public sealed class SettingsCmdAddContourLabelingGroup : SettingsSurface
	{
		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06001773 RID: 6003
		public extern SettingsCmdAddContourLabelingGroup.SettingsCmdAddContourLabeling AddContourLabeling { get; }

		// Token: 0x02000CE3 RID: 3299
		public sealed class SettingsCmdAddContourLabeling : TreeOidWrapper
		{
			// Token: 0x17000A6A RID: 2666
			// (get) Token: 0x06001774 RID: 6004
			public extern PropertyDouble IntervalAlongContour { get; }
		}
	}
}
