using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000A4 RID: 164
	[Wrapper("AeccDbViewFrameStyle")]
	public sealed class ViewFrameStyle : StyleBase
	{
		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000735 RID: 1845
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.ViewFrameStyle.GetViewFrameBoundaryDisplayStylePlan instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2010)]
		public extern DisplayStyle ViewFrameBoundaryDisplayStylePlan { get; }

		// Token: 0x06000736 RID: 1846
		public extern DisplayStyle GetViewFrameBoundaryDisplayStylePlan();
	}
}
