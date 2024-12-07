using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020006E8 RID: 1768
	[Wrapper("AeccDbSurfaceGrid")]
	public sealed class GridVolumeSurface : Surface, IGridSurface, IVolumeSurface
	{
		// Token: 0x06000E17 RID: 3607
		public static extern ObjectId Create(string surfaceName, ObjectId baseSurfaceId, ObjectId comparisonSurfaceId, double spacingX, double spacingY, double orientation, ObjectId styleId);

		// Token: 0x06000E18 RID: 3608
		public static extern ObjectId Create(string surfaceName, ObjectId baseSurfaceId, ObjectId comparisonSurfaceId, double spacingX, double spacingY, double orientation);

		// Token: 0x06000E19 RID: 3609
		public extern GridSurfaceProperties GetGridProperties();

		// Token: 0x06000E1A RID: 3610
		public extern VolumeSurfaceProperties GetVolumeProperties();

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06000E1B RID: 3611
		// (set) Token: 0x06000E1C RID: 3612
		public extern double CutFactor { get; set; }

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06000E1D RID: 3613
		// (set) Token: 0x06000E1E RID: 3614
		public extern double FillFactor { get; set; }
	}
}
