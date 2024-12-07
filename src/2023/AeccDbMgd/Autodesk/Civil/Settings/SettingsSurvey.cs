using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02001208 RID: 4616
	public class SettingsSurvey : SettingsAmbient
	{
		// Token: 0x170013EE RID: 5102
		// (get) Token: 0x06002707 RID: 9991
		public extern SettingsSurvey.SettingsStyles Styles { get; }

		// Token: 0x0200120C RID: 4620
		public sealed class SettingsStyles : TreeOidWrapper
		{
			// Token: 0x170013F8 RID: 5112
			// (get) Token: 0x06002708 RID: 9992
			public extern PropertyString Figure { get; }

			// Token: 0x170013F7 RID: 5111
			// (get) Token: 0x06002709 RID: 9993
			public extern PropertyObjectId FigureStyleId { get; }

			// Token: 0x170013F6 RID: 5110
			// (get) Token: 0x0600270A RID: 9994
			public extern PropertyString Network { get; }

			// Token: 0x170013F5 RID: 5109
			// (get) Token: 0x0600270B RID: 9995
			public extern PropertyObjectId NetworkStyleId { get; }

			// Token: 0x170013F4 RID: 5108
			// (get) Token: 0x0600270C RID: 9996
			public extern PropertyString LineLabel { get; }

			// Token: 0x170013F3 RID: 5107
			// (get) Token: 0x0600270D RID: 9997
			public extern PropertyObjectId LineLabelStyleId { get; }

			// Token: 0x170013F2 RID: 5106
			// (get) Token: 0x0600270E RID: 9998
			public extern PropertyString CurveLabel { get; }

			// Token: 0x170013F1 RID: 5105
			// (get) Token: 0x0600270F RID: 9999
			public extern PropertyObjectId CurveLabelStyleId { get; }

			// Token: 0x170013F0 RID: 5104
			// (get) Token: 0x06002710 RID: 10000
			public extern PropertyString FigureLabel { get; }

			// Token: 0x170013EF RID: 5103
			// (get) Token: 0x06002711 RID: 10001
			public extern PropertyObjectId FigureLabelStyleId { get; }
		}
	}
}
