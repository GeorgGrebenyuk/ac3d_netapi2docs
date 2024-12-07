using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D07 RID: 3335
	public class SettingsParcel : SettingsAmbient
	{
		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x060017C5 RID: 6085
		public extern SettingsParcel.SettingsStyles Styles { get; }

		// Token: 0x02000D9E RID: 3486
		public sealed class SettingsStyles : TreeOidWrapper
		{
			// Token: 0x17000C6A RID: 3178
			// (get) Token: 0x0600196D RID: 6509
			public extern PropertyString Parcel { get; }

			// Token: 0x17000C69 RID: 3177
			// (get) Token: 0x0600196E RID: 6510
			public extern PropertyObjectId ParcelStyleId { get; }

			// Token: 0x17000C68 RID: 3176
			// (get) Token: 0x0600196F RID: 6511
			public extern PropertyString ParcelLineLabel { get; }

			// Token: 0x17000C67 RID: 3175
			// (get) Token: 0x06001970 RID: 6512
			public extern PropertyObjectId ParcelLineLabelStyleId { get; }

			// Token: 0x17000C66 RID: 3174
			// (get) Token: 0x06001971 RID: 6513
			public extern PropertyString ParcelCurveLabel { get; }

			// Token: 0x17000C65 RID: 3173
			// (get) Token: 0x06001972 RID: 6514
			public extern PropertyObjectId ParcelCurveLabelStyleId { get; }

			// Token: 0x17000C64 RID: 3172
			// (get) Token: 0x06001973 RID: 6515
			public extern PropertyString ParcelAreaLabelStyle { get; }

			// Token: 0x17000C63 RID: 3171
			// (get) Token: 0x06001974 RID: 6516
			public extern PropertyObjectId ParcelAreaLabelStyleId { get; }
		}
	}
}
