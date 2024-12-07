using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000139 RID: 313
	[Wrapper("AeccDbSurfaceElevLabel")]
	public class SurfaceElevationLabel : FeatureLabel
	{
		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06000D3C RID: 3388
		// (set) Token: 0x06000D3D RID: 3389
		public extern Point2d Location { get; set; }

		// Token: 0x06000D3E RID: 3390
		public static extern ObjectId Create(ObjectId surfaceId, Point2d location, ObjectId labelStyleId, ObjectId markerStyleId);

		// Token: 0x06000D3F RID: 3391
		public static extern ObjectId Create(ObjectId surfaceId, Point2d location);

		// Token: 0x06000D40 RID: 3392
		[DeprecatedVersion(CivilVersion.Civil2013)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.SurfaceElevationLabel.GetAvailableSurfaceElevationLabelIds instead.", false)]
		public static extern ObjectIdCollection GetAvailableSurfaceElevationLabels(ObjectId surfaceId);

		// Token: 0x06000D41 RID: 3393
		public static extern ObjectIdCollection GetAvailableSurfaceElevationLabelIds(ObjectId surfaceId);

		// Token: 0x06000D42 RID: 3394
		protected internal extern SurfaceElevationLabel(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
