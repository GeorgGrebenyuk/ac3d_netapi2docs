using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x0200003F RID: 63
	public abstract class SurfaceBaseStyle : CivilWrapper<AeccDbSurfaceStyle>
	{
		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000176 RID: 374
		// (set) Token: 0x06000177 RID: 375
		public extern SurfaceDisplay3dType DisplayMode { get; set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000178 RID: 376
		// (set) Token: 0x06000179 RID: 377
		public extern double FlattenToElevationBy { get; set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600017A RID: 378
		// (set) Token: 0x0600017B RID: 379
		public extern double ExaggerateElevationBy { get; set; }

		// Token: 0x0600017C RID: 380
		protected abstract uint GetDisplayModeAttributeId();

		// Token: 0x0600017D RID: 381
		protected abstract uint GetFlattenToElevationByAttributeId();

		// Token: 0x0600017E RID: 382
		protected abstract uint GetExaggerateElevationByAttributeId();
	}
}
