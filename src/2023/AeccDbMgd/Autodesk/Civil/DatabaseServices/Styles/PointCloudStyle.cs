using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000DF RID: 223
	[Wrapper("AeccDbPointCloudStyle")]
	public sealed class PointCloudStyle : StyleBase
	{
		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000A10 RID: 2576
		public extern PointCloudPointStyle PointStyle { get; }

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000A11 RID: 2577
		public extern PointCloudClassificationInfoCollection ClassificationInfos { get; }

		// Token: 0x06000A12 RID: 2578
		public extern DisplayStyle GetDisplayStylePlan(PointCloudDisplayStyleType type);

		// Token: 0x06000A13 RID: 2579
		public extern DisplayStyle GetDisplayStyleModel(PointCloudDisplayStyleType type);
	}
}
