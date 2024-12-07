using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000CEA RID: 3306
	public sealed class SettingsCmdAddSurfaceContours : SettingsSurface
	{
		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06001780 RID: 6016
		public extern SettingsCmdAddSurfaceContours.SettingsCmdAddDataOptions AddDataOptions { get; }

		// Token: 0x02000CEB RID: 3307
		public sealed class SettingsCmdAddDataOptions : TreeOidWrapper
		{
			// Token: 0x17000A7E RID: 2686
			// (get) Token: 0x06001781 RID: 6017
			public extern PropertyDouble WeedingDistance { get; }

			// Token: 0x17000A7D RID: 2685
			// (get) Token: 0x06001782 RID: 6018
			public extern PropertyDouble WeedingAngle { get; }

			// Token: 0x17000A7C RID: 2684
			// (get) Token: 0x06001783 RID: 6019
			public extern PropertyDouble SupplementingDistance { get; }

			// Token: 0x17000A7B RID: 2683
			// (get) Token: 0x06001784 RID: 6020
			public extern PropertyDouble MidOrdinateDistance { get; }

			// Token: 0x17000A7A RID: 2682
			// (get) Token: 0x06001785 RID: 6021
			public extern PropertyBoolean FillGapsInContourData { get; }

			// Token: 0x17000A79 RID: 2681
			// (get) Token: 0x06001786 RID: 6022
			public extern PropertyBoolean SwapEdges { get; }

			// Token: 0x17000A78 RID: 2680
			// (get) Token: 0x06001787 RID: 6023
			public extern PropertyBoolean AddPointsToFlatTriangles { get; }

			// Token: 0x17000A77 RID: 2679
			// (get) Token: 0x06001788 RID: 6024
			public extern PropertyBoolean AddPointsToFlatEdges { get; }
		}
	}
}
