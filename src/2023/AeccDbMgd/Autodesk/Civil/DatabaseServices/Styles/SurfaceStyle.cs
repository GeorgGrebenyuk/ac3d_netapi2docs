using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000093 RID: 147
	[Wrapper("AeccDbSurfaceStyle")]
	public sealed class SurfaceStyle : StyleBase
	{
		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000666 RID: 1638
		public extern SurfaceBoundaryStyle BoundaryStyle { get; }

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000667 RID: 1639
		public extern SurfaceContourStyle ContourStyle { get; }

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000668 RID: 1640
		public extern SurfaceDirectionStyle DirectionStyle { get; }

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000669 RID: 1641
		public extern SurfaceElevationStyle ElevationStyle { get; }

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x0600066A RID: 1642
		public extern SurfaceGridStyle GridStyle { get; }

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x0600066B RID: 1643
		public extern SurfacePointStyle PointStyle { get; }

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x0600066C RID: 1644
		public extern SurfaceSlopeArrowStyle SlopeArrowStyle { get; }

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x0600066D RID: 1645
		public extern SurfaceSlopeStyle SlopeStyle { get; }

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x0600066E RID: 1646
		public extern SurfaceWatershedStyle WatershedStyle { get; }

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x0600066F RID: 1647
		public extern SurfaceTriangleStyle TriangleStyle { get; }

		// Token: 0x06000670 RID: 1648
		public extern DisplayStyle GetDisplayStylePlan(SurfaceDisplayStyleType type);

		// Token: 0x06000671 RID: 1649
		public extern DisplayStyle GetDisplayStyleModel(SurfaceDisplayStyleType type);

		// Token: 0x06000672 RID: 1650
		public extern DisplayStyle GetDisplayStyleSection();
	}
}
