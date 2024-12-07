using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x020010FC RID: 4348
	public class SettingsQuantityTakeoff : SettingsAmbient
	{
		// Token: 0x1700124D RID: 4685
		// (get) Token: 0x0600236B RID: 9067
		public extern SettingsQuantityTakeoff.SettingsStyles Styles { get; }

		// Token: 0x1700124C RID: 4684
		// (get) Token: 0x0600236C RID: 9068
		public extern SettingsQuantityTakeoff.SettingsNameFormat NameFormat { get; }

		// Token: 0x0200110F RID: 4367
		public sealed class SettingsStyles : TreeOidWrapper
		{
			// Token: 0x170012B9 RID: 4793
			// (get) Token: 0x060023D5 RID: 9173
			public extern PropertyString QuantityTakeoffCriteria { get; }

			// Token: 0x170012B8 RID: 4792
			// (get) Token: 0x060023D6 RID: 9174
			public extern PropertyObjectId QuantityTakeoffCriteriaId { get; }

			// Token: 0x170012B7 RID: 4791
			// (get) Token: 0x060023D7 RID: 9175
			public extern PropertyString MaterialShape { get; }

			// Token: 0x170012B6 RID: 4790
			// (get) Token: 0x060023D8 RID: 9176
			public extern PropertyObjectId MaterialShapeId { get; }
		}

		// Token: 0x02001110 RID: 4368
		public sealed class SettingsNameFormat : TreeOidWrapper
		{
			// Token: 0x170012BB RID: 4795
			// (get) Token: 0x060023D9 RID: 9177
			public extern PropertyString Material { get; }

			// Token: 0x170012BA RID: 4794
			// (get) Token: 0x060023DA RID: 9178
			public extern PropertyString MaterialList { get; }
		}
	}
}
