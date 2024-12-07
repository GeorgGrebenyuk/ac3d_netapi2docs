using System;

namespace Autodesk.Civil.ApplicationServices
{
	// Token: 0x020007F5 RID: 2037
	public sealed class CivilApplication
	{
		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06000F70 RID: 3952
		public static extern CivilDocument ActiveDocument { get; }

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06000F71 RID: 3953
		public static extern ProductType ActiveProduct { get; }

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06000F72 RID: 3954
		public static extern SurveyProjectCollection SurveyProjects { get; }
	}
}
