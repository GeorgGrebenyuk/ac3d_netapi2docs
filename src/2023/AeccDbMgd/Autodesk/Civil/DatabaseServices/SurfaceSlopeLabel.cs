using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200013A RID: 314
	[Wrapper("AeccDbSurfaceSlopeLabel")]
	public class SurfaceSlopeLabel : FeatureLabel
	{
		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06000D43 RID: 3395
		public extern SurfaceSlopeLabelType SlopeLabelType { get; }

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06000D44 RID: 3396
		// (set) Token: 0x06000D45 RID: 3397
		public extern Point2d Location { get; set; }

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06000D46 RID: 3398
		// (set) Token: 0x06000D47 RID: 3399
		public extern Point2d Location2 { get; set; }

		// Token: 0x06000D48 RID: 3400
		public static extern ObjectId Create(ObjectId surfaceId, Point2d point1, Point2d point2, ObjectId labelStyleId);

		// Token: 0x06000D49 RID: 3401
		public static extern ObjectId Create(ObjectId surfaceId, Point2d point1, Point2d point2);

		// Token: 0x06000D4A RID: 3402
		public static extern ObjectId Create(ObjectId surfaceId, Point2d location, ObjectId labelStyleId);

		// Token: 0x06000D4B RID: 3403
		public static extern ObjectId Create(ObjectId surfaceId, Point2d location);

		// Token: 0x06000D4C RID: 3404
		[DeprecatedVersion(CivilVersion.Civil2013)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.SurfaceElevationLabel.GetAvailableSurfaceElevationLabelIds instead.", false)]
		public static extern ObjectIdCollection GetAvailableSurfaceSlopeLabels(ObjectId surfaceId);

		// Token: 0x06000D4D RID: 3405
		public static extern ObjectIdCollection GetAvailableSurfaceSlopeLabelIds(ObjectId surfaceId);

		// Token: 0x06000D4E RID: 3406
		protected internal extern SurfaceSlopeLabel(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
