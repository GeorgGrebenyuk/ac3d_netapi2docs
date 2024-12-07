using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil
{
	// Token: 0x02000FC3 RID: 4035
	public class ProfileDesignCheckRoot
	{
		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x06002002 RID: 8194
		public extern ProfileDesignCheckCollection LineDesignChecks { get; }

		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x06002003 RID: 8195
		public extern ProfileDesignCheckCollection CurveDesignChecks { get; }

		// Token: 0x06002004 RID: 8196
		public extern ProfileDesignCheckRoot(Database pDatabase);

		// Token: 0x0400187E RID: 6270
		private int <SyntheticNonEmptyStructMarker>;
	}
}
