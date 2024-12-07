using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000BF3 RID: 3059
	public class SettingsGeneral : SettingsAmbient
	{
		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06001721 RID: 5921
		public extern Autodesk.Civil.Settings.SettingsGeneral.SettingsStyles Styles { get; }

		// Token: 0x020010AA RID: 4266
		public sealed class SettingsStyles : TreeOidWrapper
		{
			// Token: 0x17001166 RID: 4454
			// (get) Token: 0x06002257 RID: 8791
			public extern PropertyString NoteLabel { get; }

			// Token: 0x17001165 RID: 4453
			// (get) Token: 0x06002258 RID: 8792
			public extern PropertyObjectId NoteLabelStyleId { get; }

			// Token: 0x17001164 RID: 4452
			// (get) Token: 0x06002259 RID: 8793
			public extern PropertyString LineLabel { get; }

			// Token: 0x17001163 RID: 4451
			// (get) Token: 0x0600225A RID: 8794
			public extern PropertyObjectId LineLabelStyleId { get; }

			// Token: 0x17001162 RID: 4450
			// (get) Token: 0x0600225B RID: 8795
			public extern PropertyString CurveLabel { get; }

			// Token: 0x17001161 RID: 4449
			// (get) Token: 0x0600225C RID: 8796
			public extern PropertyObjectId CurveLabelStyleId { get; }
		}
	}
}
