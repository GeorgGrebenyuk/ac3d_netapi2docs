using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A8C RID: 2700
	public class SurfaceSimplifyOptions
	{
		// Token: 0x06001447 RID: 5191
		[return: MarshalAs(UnmanagedType.U1)]
		public override extern bool Equals(object right);

		// Token: 0x06001448 RID: 5192
		public extern SurfaceSimplifyOptions(SurfaceSimplifyOptions options);

		// Token: 0x06001449 RID: 5193
		public extern SurfaceSimplifyOptions(SurfaceSimplifyType simplifyMethod);

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x0600144A RID: 5194
		// (set) Token: 0x0600144B RID: 5195
		public extern SurfaceSimplifyType SimplifyMethod { get; set; }

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x0600144C RID: 5196
		public extern SurfaceSimplifyRegionType RegionOption { get; }

		// Token: 0x0600144D RID: 5197
		public extern void SetSurfaceBorderAsRegion();

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x0600144E RID: 5198
		// (set) Token: 0x0600144F RID: 5199
		public extern Point3dCollection UserSpecifiedPolygonRegion { get; set; }

		// Token: 0x06001450 RID: 5200
		public extern void SetUserSpecifiedPolygonRegionByEntityId(ObjectId entityId, double midOrdinate);

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06001451 RID: 5201
		// (set) Token: 0x06001452 RID: 5202
		public extern bool UsePercentageToRemove { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06001453 RID: 5203
		// (set) Token: 0x06001454 RID: 5204
		public extern double PercentageToRemove { get; set; }

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06001455 RID: 5205
		// (set) Token: 0x06001456 RID: 5206
		public extern bool UseMaximumChangeInElevation { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06001457 RID: 5207
		// (set) Token: 0x06001458 RID: 5208
		public extern double MaximumChangeInElevation { get; set; }

		// Token: 0x04001453 RID: 5203
		private int <SyntheticNonEmptyStructMarker>;
	}
}
