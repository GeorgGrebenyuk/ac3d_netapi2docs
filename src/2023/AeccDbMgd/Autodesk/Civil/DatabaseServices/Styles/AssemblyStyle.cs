using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000E8 RID: 232
	[Wrapper("AeccDbAssemblyStyle")]
	public sealed class AssemblyStyle : StyleBase
	{
		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000A72 RID: 2674
		public extern ObjectId MarkerStyleAtAssemblyOriginId { get; }

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000A73 RID: 2675
		public extern ObjectId MarkerStyleAtMainBaselineId { get; }

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000A74 RID: 2676
		public extern ObjectId MarkerStyleAtMainBaselineOriginId { get; }

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000A75 RID: 2677
		public extern ObjectId MarkerStyleAtOffsetBaselineId { get; }

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000A76 RID: 2678
		public extern ObjectId MarkerStyleAtOffsetBaselineOriginId { get; }

		// Token: 0x06000A77 RID: 2679
		public extern DisplayStyle GetDisplayStylePlan(AssemblyDisplayStyleType type);

		// Token: 0x06000A78 RID: 2680
		public extern DisplayStyle GetDisplayStyleModel(AssemblyDisplayStyleType type);
	}
}
