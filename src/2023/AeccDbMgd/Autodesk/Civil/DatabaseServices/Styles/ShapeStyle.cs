using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000E3 RID: 227
	[Wrapper("AeccDbRoadwayShapeStyle")]
	public sealed class ShapeStyle : SubassemblySubentityStyle
	{
		// Token: 0x06000A34 RID: 2612
		public extern DisplayStyle GetDisplayStylePlan(ShapeDisplayStyleType type);

		// Token: 0x06000A35 RID: 2613
		public extern DisplayStyle GetDisplayStyleModel(ShapeDisplayStyleType type);

		// Token: 0x06000A36 RID: 2614
		public extern DisplayStyle GetDisplayStyleProfile(ShapeDisplayStyleType type);

		// Token: 0x06000A37 RID: 2615
		public extern DisplayStyle GetDisplayStyleSection(ShapeDisplayStyleType type);

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000A38 RID: 2616
		public override extern SubassemblySubentityStyleType StyleType { get; }

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000A39 RID: 2617
		[DeprecatedVersion(CivilVersion.Civil2010)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.ShapeStyle.GetAreaFillHatchDisplayStylePlan instead.", false)]
		public extern HatchDisplayStyle AreaFillHatchDisplayStylePlan { get; }

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000A3A RID: 2618
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.ShapeStyle.GetAreaFillHatchDisplayStyleModel instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2010)]
		public extern HatchDisplayStyle AreaFillHatchDisplayStyleModel { get; }

		// Token: 0x06000A3B RID: 2619
		public extern HatchDisplayStyle GetHatchDisplayStylePlan();

		// Token: 0x06000A3C RID: 2620
		public extern HatchDisplayStyle GetHatchDisplayStyleModel();

		// Token: 0x06000A3D RID: 2621
		public extern HatchDisplayStyle GetHatchDisplayStyleProfile();

		// Token: 0x06000A3E RID: 2622
		public extern HatchDisplayStyle GetHatchDisplayStyleSection();
	}
}
