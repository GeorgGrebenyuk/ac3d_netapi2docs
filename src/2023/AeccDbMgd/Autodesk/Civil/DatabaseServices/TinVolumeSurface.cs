using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020006E7 RID: 1767
	[Wrapper("AeccDbSurfaceTin")]
	public sealed class TinVolumeSurface : Surface, ITinSurface, IVolumeSurface
	{
		// Token: 0x06000E0F RID: 3599
		public static extern ObjectId Create(string surfaceName, ObjectId baseSurfaceId, ObjectId comparisonSurfaceId, ObjectId styleId);

		// Token: 0x06000E10 RID: 3600
		public static extern ObjectId Create(string surfaceName, ObjectId baseSurfaceId, ObjectId comparisonSurfaceId);

		// Token: 0x06000E11 RID: 3601
		public extern TinSurfaceProperties GetTinProperties();

		// Token: 0x06000E12 RID: 3602
		public extern VolumeSurfaceProperties GetVolumeProperties();

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06000E13 RID: 3603
		// (set) Token: 0x06000E14 RID: 3604
		public extern double CutFactor { get; set; }

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06000E15 RID: 3605
		// (set) Token: 0x06000E16 RID: 3606
		public extern double FillFactor { get; set; }
	}
}
