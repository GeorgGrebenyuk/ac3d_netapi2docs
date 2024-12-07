using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D6D RID: 3437
	public class SettingsSampleLine : SettingsAmbient
	{
		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x060018C1 RID: 6337
		public extern SettingsSampleLine.SettingsStyles Styles { get; }

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x060018C2 RID: 6338
		public extern SettingsSampleLine.SettingsNameFormat NameFormat { get; }

		// Token: 0x02000DAC RID: 3500
		public sealed class SettingsStyles : TreeOidWrapper
		{
			// Token: 0x17000CCB RID: 3275
			// (get) Token: 0x060019D2 RID: 6610
			public extern PropertyString SampleLine { get; }

			// Token: 0x17000CCA RID: 3274
			// (get) Token: 0x060019D3 RID: 6611
			public extern PropertyObjectId SampleLineStyleId { get; }

			// Token: 0x17000CC9 RID: 3273
			// (get) Token: 0x060019D4 RID: 6612
			public extern PropertyString SampleLineLabel { get; }

			// Token: 0x17000CC8 RID: 3272
			// (get) Token: 0x060019D5 RID: 6613
			public extern PropertyObjectId SampleLineLabelStyleId { get; }
		}

		// Token: 0x02000DAD RID: 3501
		public sealed class SettingsNameFormat : TreeOidWrapper
		{
			// Token: 0x17000CCD RID: 3277
			// (get) Token: 0x060019D6 RID: 6614
			public extern PropertyString SampleLine { get; }

			// Token: 0x17000CCC RID: 3276
			// (get) Token: 0x060019D7 RID: 6615
			public extern PropertyString SampleLineGroup { get; }
		}
	}
}
