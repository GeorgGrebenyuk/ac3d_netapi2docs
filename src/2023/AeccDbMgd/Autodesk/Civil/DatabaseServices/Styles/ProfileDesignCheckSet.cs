using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000086 RID: 134
	[Wrapper("AeccDbVAlignmentDesignCheckSet")]
	public sealed class ProfileDesignCheckSet : AlignmentDesignCheckSet
	{
		// Token: 0x0600061B RID: 1563
		public new extern ProfileDesignCheck[] GetAllDesignChecks();

		// Token: 0x0600061C RID: 1564
		public new extern AlignmentDesignCheck AddDesignCheck(AlignmentDesignCheckType type, string name);

		// Token: 0x0600061D RID: 1565
		public extern ProfileDesignCheck AddDesignCheck(ProfileDesignCheckType type, string name);

		// Token: 0x0600061E RID: 1566
		public new extern void RemoveDesignCheck(AlignmentDesignCheck type);

		// Token: 0x0600061F RID: 1567
		public new extern void RemoveDesignCheck(AlignmentDesignCheckType type, string name);

		// Token: 0x06000620 RID: 1568
		public extern void RemoveDesignCheck(ProfileDesignCheck designCheck);

		// Token: 0x06000621 RID: 1569
		public extern void RemoveDesignCheck(ProfileDesignCheckType type, string name);

		// Token: 0x06000622 RID: 1570
		public new extern void RemoveAllDesignCheck();

		// Token: 0x06000623 RID: 1571
		public extern void SetCurveDesignCheckType(string name, ProfileDesignCheckCurveType type);

		// Token: 0x06000624 RID: 1572
		public extern ProfileDesignCheckCurveType GetCurveDesignCheckType(string name);
	}
}
