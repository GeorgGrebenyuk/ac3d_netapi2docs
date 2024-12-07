using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000BC RID: 188
	[Wrapper("AeccDbBuildingSiteStyle")]
	public sealed class BuildingSiteStyle : StyleBase
	{
		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000834 RID: 2100
		// (set) Token: 0x06000835 RID: 2101
		public extern ObjectId MarkerStyleId { get; set; }

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000836 RID: 2102
		// (set) Token: 0x06000837 RID: 2103
		public extern string MarkerStyleName { get; set; }

		// Token: 0x06000838 RID: 2104
		public extern DisplayStyle GetDisplayStylePlan(BuildingSiteDisplayStyleType type);

		// Token: 0x06000839 RID: 2105
		public extern DisplayStyle GetDisplayStyleModel(BuildingSiteDisplayStyleType type);
	}
}
