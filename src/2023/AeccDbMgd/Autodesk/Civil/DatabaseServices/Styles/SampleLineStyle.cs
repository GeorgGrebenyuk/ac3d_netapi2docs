using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000A0 RID: 160
	[Wrapper("AeccDbSampleLineStyle")]
	public sealed class SampleLineStyle : StyleBase
	{
		// Token: 0x06000720 RID: 1824
		public extern DisplayStyle GetDisplayStylePlan(SampleLineDisplayStyleType type);

		// Token: 0x06000721 RID: 1825
		public extern DisplayStyle GetDisplayStyleModel(SampleLineDisplayStyleType type);
	}
}
