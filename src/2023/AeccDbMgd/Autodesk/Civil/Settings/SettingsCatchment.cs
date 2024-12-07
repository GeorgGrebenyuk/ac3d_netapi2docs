using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000B02 RID: 2818
	public class SettingsCatchment : SettingsAmbient
	{
		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06001508 RID: 5384
		public extern PropertyString NameTemplate { get; }

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06001509 RID: 5385
		public extern SettingsCatchment.SettingsStyles Styles { get; }

		// Token: 0x02000B03 RID: 2819
		public class SettingsStyles : TreeOidWrapper
		{
			// Token: 0x170008F8 RID: 2296
			// (get) Token: 0x0600150A RID: 5386
			public extern PropertyString CatchmentStyle { get; }

			// Token: 0x170008F7 RID: 2295
			// (get) Token: 0x0600150B RID: 5387
			public extern PropertyObjectId CatchmentStyleId { get; }

			// Token: 0x170008F6 RID: 2294
			// (get) Token: 0x0600150C RID: 5388
			public extern PropertyString CatchmentLabelStyle { get; }

			// Token: 0x170008F5 RID: 2293
			// (get) Token: 0x0600150D RID: 5389
			public extern PropertyObjectId CatchmentLabelStyleId { get; }

			// Token: 0x170008F4 RID: 2292
			// (get) Token: 0x0600150E RID: 5390
			public extern PropertyString FlowSegmentLabelStyle { get; }

			// Token: 0x170008F3 RID: 2291
			// (get) Token: 0x0600150F RID: 5391
			public extern PropertyObjectId FlowSegmentLabelStyleId { get; }
		}
	}
}
