using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D03 RID: 3331
	public sealed class SettingsCmdSimplifySurface : SettingsSurface
	{
		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x060017BB RID: 6075
		public extern PropertyEnum<SurfaceSimplifyType> SimplifyMethod { get; }

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x060017BC RID: 6076
		public extern PropertyEnum<SurfaceRegionOptionsType> RegionOptions { get; }

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x060017BD RID: 6077
		public extern PropertyBoolean UsePercentageOfPointsToRemove { get; }

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x060017BE RID: 6078
		public extern PropertyDouble PercentageOfPointsToRemove { get; }

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x060017BF RID: 6079
		public extern PropertyBoolean UseMaximumChangeInElevation { get; }

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x060017C0 RID: 6080
		public extern PropertyDouble MaximumChangeInElevation { get; }
	}
}
