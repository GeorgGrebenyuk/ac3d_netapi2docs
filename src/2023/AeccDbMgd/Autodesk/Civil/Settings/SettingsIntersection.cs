using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x020010E9 RID: 4329
	public class SettingsIntersection : SettingsAmbient
	{
		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x0600231D RID: 8989
		public extern SettingsIntersection.SettingsStyles Styles { get; }

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x0600231E RID: 8990
		public extern SettingsIntersection.SettingsNameFormat NameFormat { get; }

		// Token: 0x0200110D RID: 4365
		public sealed class SettingsStyles : TreeOidWrapper
		{
			// Token: 0x170012AE RID: 4782
			// (get) Token: 0x060023BC RID: 9148
			public extern PropertyString Intersection { get; }

			// Token: 0x170012AD RID: 4781
			// (get) Token: 0x060023BD RID: 9149
			public extern PropertyObjectId IntersectionStyleId { get; }

			// Token: 0x170012AC RID: 4780
			// (get) Token: 0x060023BE RID: 9150
			public extern PropertyString IntersectionLabel { get; }

			// Token: 0x170012AB RID: 4779
			// (get) Token: 0x060023BF RID: 9151
			public extern PropertyObjectId IntersectionLabelStyleId { get; }

			// Token: 0x170012AA RID: 4778
			// (get) Token: 0x060023C0 RID: 9152
			public extern PropertyString OffsetAlignment { get; }

			// Token: 0x170012A9 RID: 4777
			// (get) Token: 0x060023C1 RID: 9153
			public extern PropertyObjectId OffsetAlignmentStyleId { get; }

			// Token: 0x170012A8 RID: 4776
			// (get) Token: 0x060023C2 RID: 9154
			public extern PropertyString CurbReturnAlignment { get; }

			// Token: 0x170012A7 RID: 4775
			// (get) Token: 0x060023C3 RID: 9155
			public extern PropertyObjectId CurbReturnAlignmentStyleId { get; }

			// Token: 0x170012A6 RID: 4774
			// (get) Token: 0x060023C4 RID: 9156
			public extern PropertyString OffsetProfile { get; }

			// Token: 0x170012A5 RID: 4773
			// (get) Token: 0x060023C5 RID: 9157
			public extern PropertyObjectId OffsetProfileStyleId { get; }

			// Token: 0x170012A4 RID: 4772
			// (get) Token: 0x060023C6 RID: 9158
			public extern PropertyString CurbReturnProfile { get; }

			// Token: 0x170012A3 RID: 4771
			// (get) Token: 0x060023C7 RID: 9159
			public extern PropertyObjectId CurbReturnProfileStyleId { get; }

			// Token: 0x170012A2 RID: 4770
			// (get) Token: 0x060023C8 RID: 9160
			public extern PropertyString OffsetAlignmentLabelSet { get; }

			// Token: 0x170012A1 RID: 4769
			// (get) Token: 0x060023C9 RID: 9161
			public extern PropertyObjectId OffsetAlignmentLabelSetId { get; }

			// Token: 0x170012A0 RID: 4768
			// (get) Token: 0x060023CA RID: 9162
			public extern PropertyString CurbReturnAlignmentLabelSet { get; }

			// Token: 0x1700129F RID: 4767
			// (get) Token: 0x060023CB RID: 9163
			public extern PropertyObjectId CurbReturnAlignmentLabelSetId { get; }

			// Token: 0x1700129E RID: 4766
			// (get) Token: 0x060023CC RID: 9164
			[Obsolete("Functionality has been removed.", false)]
			[DeprecatedVersion(CivilVersion.Civil2010)]
			public extern PropertyString OffsetProfileLabelSet { get; }

			// Token: 0x1700129D RID: 4765
			// (get) Token: 0x060023CD RID: 9165
			[Obsolete("Functionality has been removed", false)]
			[DeprecatedVersion(CivilVersion.Civil2010)]
			public extern PropertyString CurbReturnProfileLabelSet { get; }
		}

		// Token: 0x0200110E RID: 4366
		public sealed class SettingsNameFormat : TreeOidWrapper
		{
			// Token: 0x170012B5 RID: 4789
			// (get) Token: 0x060023CE RID: 9166
			public extern PropertyString Intersection { get; }

			// Token: 0x170012B4 RID: 4788
			// (get) Token: 0x060023CF RID: 9167
			public extern PropertyString IntersectionQuadrant { get; }

			// Token: 0x170012B3 RID: 4787
			// (get) Token: 0x060023D0 RID: 9168
			public extern PropertyString OffsetAlignment { get; }

			// Token: 0x170012B2 RID: 4786
			// (get) Token: 0x060023D1 RID: 9169
			public extern PropertyString CurbReturnAlignment { get; }

			// Token: 0x170012B1 RID: 4785
			// (get) Token: 0x060023D2 RID: 9170
			public extern PropertyString OffsetProfile { get; }

			// Token: 0x170012B0 RID: 4784
			// (get) Token: 0x060023D3 RID: 9171
			public extern PropertyString CurbReturnProfile { get; }

			// Token: 0x170012AF RID: 4783
			// (get) Token: 0x060023D4 RID: 9172
			public extern PropertyString CorridorRegion { get; }
		}
	}
}
