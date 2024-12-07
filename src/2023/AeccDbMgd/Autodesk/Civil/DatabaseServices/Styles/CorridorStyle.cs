using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000B6 RID: 182
	[Wrapper("AeccDbCorridorStyle")]
	public sealed class CorridorStyle : StyleBase
	{
		// Token: 0x060007E1 RID: 2017
		public extern DisplayStyle GetDisplayStylePlan(CorridorDisplayStyleType type);

		// Token: 0x060007E2 RID: 2018
		public extern DisplayStyle GetDisplayStyleModel(CorridorDisplayStyleType type);
	}
}
