using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000BA RID: 186
	[Wrapper("AeccDbMassHaulLineStyle")]
	public sealed class MassHaulLineStyle : StyleBase
	{
		// Token: 0x17000355 RID: 853
		// (get) Token: 0x0600082D RID: 2093
		// (set) Token: 0x0600082E RID: 2094
		public extern FreeHaulDisplayType FreeHaulOption { get; set; }

		// Token: 0x0600082F RID: 2095
		public extern DisplayStyle GetDisplayStyleProfile(MassHaulLineDisplayStyleType type);

		// Token: 0x06000830 RID: 2096
		public extern HatchDisplayStyle GetHatchDisplayStyleProfile(MassHaulLineHatchDisplayStyleType type);
	}
}
