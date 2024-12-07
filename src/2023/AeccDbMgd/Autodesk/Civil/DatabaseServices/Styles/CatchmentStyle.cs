using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000140 RID: 320
	[Wrapper("AeccDbCatchmentAreaStyle")]
	public sealed class CatchmentStyle : StyleBase
	{
		// Token: 0x06000DB9 RID: 3513
		public extern DisplayStyle GetDisplayStylePlan(CatchmentDisplayStylePlanType type);

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06000DBA RID: 3514
		// (set) Token: 0x06000DBB RID: 3515
		public extern ObjectId DischargePointMarkerStyle { get; set; }

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06000DBC RID: 3516
		// (set) Token: 0x06000DBD RID: 3517
		public extern ObjectId MostDistantPointMarkerStyle { get; set; }

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06000DBE RID: 3518
		// (set) Token: 0x06000DBF RID: 3519
		public extern ObjectId FlowSegmentStartPointMarkerStyle { get; set; }
	}
}
