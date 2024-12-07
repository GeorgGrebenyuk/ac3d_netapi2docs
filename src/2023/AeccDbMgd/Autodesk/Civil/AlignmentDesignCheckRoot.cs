using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil
{
	// Token: 0x02000FBF RID: 4031
	public class AlignmentDesignCheckRoot
	{
		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x06001FE7 RID: 8167
		public extern AlignmentDesignCheckCollection LineDesignChecks { get; }

		// Token: 0x17000FE9 RID: 4073
		// (get) Token: 0x06001FE8 RID: 8168
		public extern AlignmentDesignCheckCollection CurveDesignChecks { get; }

		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x06001FE9 RID: 8169
		public extern AlignmentDesignCheckCollection SpiralDesignChecks { get; }

		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x06001FEA RID: 8170
		public extern AlignmentDesignCheckCollection SuperelevationDesignChecks { get; }

		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x06001FEB RID: 8171
		public extern AlignmentDesignCheckCollection TangentIntersectionDesignChecks { get; }

		// Token: 0x06001FEC RID: 8172
		public extern AlignmentDesignCheckRoot(Database pDatabase);

		// Token: 0x0400187B RID: 6267
		private int <SyntheticNonEmptyStructMarker>;
	}
}
