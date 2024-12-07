using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000047 RID: 71
	public interface IVolumeSurface
	{
		// Token: 0x06000215 RID: 533
		VolumeSurfaceProperties GetVolumeProperties();

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000216 RID: 534
		// (set) Token: 0x06000217 RID: 535
		double CutFactor { get; set; }

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000218 RID: 536
		// (set) Token: 0x06000219 RID: 537
		double FillFactor { get; set; }
	}
}
