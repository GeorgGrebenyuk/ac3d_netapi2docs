using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02001103 RID: 4355
	public sealed class SettingsCmdComputeMaterials : SettingsQuantityTakeoff
	{
		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x06002381 RID: 9089
		public extern SettingsCmdComputeMaterials.SettingsCmdDefineMaterial DefineMaterialOption { get; }

		// Token: 0x02001104 RID: 4356
		public sealed class SettingsCmdDefineMaterial : TreeOidWrapper
		{
			// Token: 0x17001264 RID: 4708
			// (get) Token: 0x06002382 RID: 9090
			public extern PropertyBoolean ApplyCurveCorrection { get; }

			// Token: 0x17001263 RID: 4707
			// (get) Token: 0x06002383 RID: 9091
			public extern PropertyDouble CurveCorrectionTolerance { get; }
		}
	}
}
