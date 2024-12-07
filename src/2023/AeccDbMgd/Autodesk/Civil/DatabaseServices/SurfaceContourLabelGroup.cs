using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000138 RID: 312
	[Wrapper("AeccDbSurfaceContourLabeling")]
	public class SurfaceContourLabelGroup : AutoFeatureLabelGroup
	{
		// Token: 0x06000D1B RID: 3355
		[DeprecatedVersion(CivilVersion.Civil2013)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.SurfaceContourLabelGroup.GetAvailableLabelGroupIds instead.", false)]
		public static extern ObjectIdCollection GetAvailableLabelGroups(ObjectId surfaceId);

		// Token: 0x06000D1C RID: 3356
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId surfaceId);

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06000D1D RID: 3357
		// (set) Token: 0x06000D1E RID: 3358
		public extern bool IsLabelLineVisible { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06000D1F RID: 3359
		// (set) Token: 0x06000D20 RID: 3360
		public extern bool IsMajorContourLabelVisible { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06000D21 RID: 3361
		// (set) Token: 0x06000D22 RID: 3362
		public extern bool IsMinorContourLabelVisible { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06000D23 RID: 3363
		// (set) Token: 0x06000D24 RID: 3364
		public extern bool IsUserContourLabelVisible { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06000D25 RID: 3365
		// (set) Token: 0x06000D26 RID: 3366
		public extern ObjectId MajorContourLabelStyleId { get; set; }

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06000D27 RID: 3367
		// (set) Token: 0x06000D28 RID: 3368
		public extern ObjectId MinorContourLabelStyleId { get; set; }

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06000D29 RID: 3369
		// (set) Token: 0x06000D2A RID: 3370
		public extern ObjectId UserContourLabelStyleId { get; set; }

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06000D2B RID: 3371
		// (set) Token: 0x06000D2C RID: 3372
		public extern Point2dCollection LabelLinePoints { get; set; }

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06000D2D RID: 3373
		// (set) Token: 0x06000D2E RID: 3374
		public override extern double RangeEnd { get; set; }

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06000D2F RID: 3375
		// (set) Token: 0x06000D30 RID: 3376
		public override extern bool RangeEndFromFeature { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06000D31 RID: 3377
		// (set) Token: 0x06000D32 RID: 3378
		public override extern double RangeStart { get; set; }

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06000D33 RID: 3379
		// (set) Token: 0x06000D34 RID: 3380
		public override extern bool RangeStartFromFeature { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x06000D35 RID: 3381
		public extern Point2d GetLabelLinePoint(int index);

		// Token: 0x06000D36 RID: 3382
		public extern void SetLabelLinePoint(int index, Point2d __unnamed001);

		// Token: 0x06000D37 RID: 3383
		public static extern ObjectId Create(ObjectId surfaceId, Point2dCollection labelLinePoints, ObjectId majorContourlabelStyleId, ObjectId minorContourlabelStyleId, ObjectId userContourlabelStyleId);

		// Token: 0x06000D38 RID: 3384
		public static extern ObjectId Create(ObjectId surfaceId, Point2dCollection labelLinePoints);

		// Token: 0x06000D39 RID: 3385
		public static extern void CreateMultipleAtInterval(ObjectId surfaceId, Point2d labelLineStartPoint, Point2d labelLineEndPoint, double interval, SurfaceContourLabelGroupCreateOption options);

		// Token: 0x06000D3A RID: 3386
		public static extern void CreateMultipleAtInterval(ObjectId surfaceId, Point2d labelLineStartPoint, Point2d labelLineEndPoint, double interval);

		// Token: 0x06000D3B RID: 3387
		protected internal extern SurfaceContourLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
