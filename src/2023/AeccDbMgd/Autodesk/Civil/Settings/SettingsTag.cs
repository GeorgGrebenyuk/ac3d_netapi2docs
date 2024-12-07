using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x0200107A RID: 4218
	public class SettingsTag : TreeOidWrapper
	{
		// Token: 0x170010FD RID: 4349
		// (get) Token: 0x060021BE RID: 8638
		public extern SettingsTag.SettingsCreation Creation { get; }

		// Token: 0x170010FC RID: 4348
		// (get) Token: 0x060021BF RID: 8639
		public extern SettingsTag.SettingsRenumbering Renumbering { get; }

		// Token: 0x020010D5 RID: 4309
		public sealed class SettingsCreation : TreeOidWrapper
		{
			// Token: 0x170011B0 RID: 4528
			// (get) Token: 0x060022BE RID: 8894
			// (set) Token: 0x060022BF RID: 8895
			public extern int LinesStartingNumber { get; set; }

			// Token: 0x170011AF RID: 4527
			// (get) Token: 0x060022C0 RID: 8896
			// (set) Token: 0x060022C1 RID: 8897
			public extern int LinesIncrement { get; set; }

			// Token: 0x170011AE RID: 4526
			// (get) Token: 0x060022C2 RID: 8898
			// (set) Token: 0x060022C3 RID: 8899
			public extern int CurvesStartingNumber { get; set; }

			// Token: 0x170011AD RID: 4525
			// (get) Token: 0x060022C4 RID: 8900
			// (set) Token: 0x060022C5 RID: 8901
			public extern int CurvesIncrement { get; set; }

			// Token: 0x170011AC RID: 4524
			// (get) Token: 0x060022C6 RID: 8902
			// (set) Token: 0x060022C7 RID: 8903
			public extern int SpiralsStartingNumber { get; set; }

			// Token: 0x170011AB RID: 4523
			// (get) Token: 0x060022C8 RID: 8904
			// (set) Token: 0x060022C9 RID: 8905
			public extern int SpiralsIncrement { get; set; }
		}

		// Token: 0x020010D6 RID: 4310
		public sealed class SettingsRenumbering : TreeOidWrapper
		{
			// Token: 0x170011B6 RID: 4534
			// (get) Token: 0x060022CA RID: 8906
			// (set) Token: 0x060022CB RID: 8907
			public extern int LinesStartingNumber { get; set; }

			// Token: 0x170011B5 RID: 4533
			// (get) Token: 0x060022CC RID: 8908
			// (set) Token: 0x060022CD RID: 8909
			public extern int LinesIncrement { get; set; }

			// Token: 0x170011B4 RID: 4532
			// (get) Token: 0x060022CE RID: 8910
			// (set) Token: 0x060022CF RID: 8911
			public extern int CurvesStartingNumber { get; set; }

			// Token: 0x170011B3 RID: 4531
			// (get) Token: 0x060022D0 RID: 8912
			// (set) Token: 0x060022D1 RID: 8913
			public extern int CurvesIncrement { get; set; }

			// Token: 0x170011B2 RID: 4530
			// (get) Token: 0x060022D2 RID: 8914
			// (set) Token: 0x060022D3 RID: 8915
			public extern int SpiralsStartingNumber { get; set; }

			// Token: 0x170011B1 RID: 4529
			// (get) Token: 0x060022D4 RID: 8916
			// (set) Token: 0x060022D5 RID: 8917
			public extern int SpiralsIncrement { get; set; }
		}
	}
}
