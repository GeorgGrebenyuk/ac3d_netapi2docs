using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000CD1 RID: 3281
	public class SettingsPoint : SettingsAmbient
	{
		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x0600174E RID: 5966
		public extern SettingsPoint.SettingsStyles Styles { get; }

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x0600174F RID: 5967
		public extern SettingsPoint.SettingsNameFormat NameFormat { get; }

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06001750 RID: 5968
		public extern SettingsPoint.SettingsUpdatePoints UpdatePoints { get; }

		// Token: 0x02000D9F RID: 3487
		public sealed class SettingsStyles : TreeOidWrapper
		{
			// Token: 0x17000C6E RID: 3182
			// (get) Token: 0x06001975 RID: 6517
			public extern PropertyString Point { get; }

			// Token: 0x17000C6D RID: 3181
			// (get) Token: 0x06001976 RID: 6518
			public extern PropertyObjectId PointStyleId { get; }

			// Token: 0x17000C6C RID: 3180
			// (get) Token: 0x06001977 RID: 6519
			public extern PropertyString PointLabel { get; }

			// Token: 0x17000C6B RID: 3179
			// (get) Token: 0x06001978 RID: 6520
			public extern PropertyObjectId PointLabelStyleId { get; }
		}

		// Token: 0x02000DA0 RID: 3488
		public sealed class SettingsNameFormat : TreeOidWrapper
		{
			// Token: 0x17000C70 RID: 3184
			// (get) Token: 0x06001979 RID: 6521
			public extern PropertyString Point { get; }

			// Token: 0x17000C6F RID: 3183
			// (get) Token: 0x0600197A RID: 6522
			public extern PropertyString PointGroup { get; }
		}

		// Token: 0x02000DA1 RID: 3489
		public sealed class SettingsUpdatePoints : TreeOidWrapper
		{
			// Token: 0x17000C71 RID: 3185
			// (get) Token: 0x0600197B RID: 6523
			public extern PropertyBoolean AllowCheckedInPointsToBeModified { get; }
		}
	}
}
