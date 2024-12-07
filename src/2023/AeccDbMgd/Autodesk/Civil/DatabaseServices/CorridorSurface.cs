using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000AB2 RID: 2738
	public sealed class CorridorSurface : CivilWrapper<AeccDbCorridor>
	{
		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x060014A7 RID: 5287
		public extern ObjectId CorridorId { get; }

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x060014A8 RID: 5288
		public extern ObjectId SurfaceId { get; }

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x060014A9 RID: 5289
		// (set) Token: 0x060014AA RID: 5290
		public extern string Name { get; set; }

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x060014AB RID: 5291
		// (set) Token: 0x060014AC RID: 5292
		public extern string Description { get; set; }

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x060014AD RID: 5293
		// (set) Token: 0x060014AE RID: 5294
		public extern bool IsBuild { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x060014AF RID: 5295
		[Obsolete("Functionality has been removed.", false)]
		[DeprecatedVersion(CivilVersion.Civil2014)]
		public extern bool IsDraw { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x060014B0 RID: 5296
		// (set) Token: 0x060014B1 RID: 5297
		public extern ObjectId SurfaceStyleId { get; set; }

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x060014B2 RID: 5298
		[Obsolete("Functionality has been removed.", false)]
		[DeprecatedVersion(CivilVersion.Civil2014)]
		public extern ObjectId SectionStyleId { get; }

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x060014B3 RID: 5299
		// (set) Token: 0x060014B4 RID: 5300
		public extern OverhangCorrectionType OverhangCorrection { get; set; }

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x060014B5 RID: 5301
		// (set) Token: 0x060014B6 RID: 5302
		public extern ObjectId RenderMaterialId { get; set; }

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x060014B7 RID: 5303
		public extern CorridorSurfaceBoundaryCollection Boundaries { get; }

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x060014B8 RID: 5304
		public extern CorridorSurfaceMaskCollection Masks { get; }

		// Token: 0x060014B9 RID: 5305
		public extern string[] PointCodes();

		// Token: 0x060014BA RID: 5306
		public extern string[] LinkCodes();

		// Token: 0x060014BB RID: 5307
		public extern string[] FeatureLineCodes();

		// Token: 0x060014BC RID: 5308
		[Obsolete("Functionality has been removed.", false)]
		[DeprecatedVersion(CivilVersion.Civil2014)]
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool FeatureLineCodeIsBreak(string name);

		// Token: 0x060014BD RID: 5309
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool IsLinkCodeAsBreakLine(string codeName);

		// Token: 0x060014BE RID: 5310
		public extern void SetLinkCodeAsBreakLine(string codeName, [MarshalAs(UnmanagedType.U1)] bool asBreakLine);

		// Token: 0x060014BF RID: 5311
		public extern void AddLinkCode(string codeName, [MarshalAs(UnmanagedType.U1)] bool addAsBreakLine);

		// Token: 0x060014C0 RID: 5312
		public extern void AddFeatureLineCode(string codeName);

		// Token: 0x060014C1 RID: 5313
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool RemoveLinkCode(string codeName);

		// Token: 0x060014C2 RID: 5314
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool RemoveFeatureLineCode(string codeName);

		// Token: 0x060014C3 RID: 5315
		public extern double FindElevationAtXY(double x, double y);

		// Token: 0x060014C4 RID: 5316
		public extern Point3dCollection GetSampleElevations(double startX, double startY, double endX, double endY);

		// Token: 0x04001478 RID: 5240
		private int <SyntheticNonEmptyStructMarker>;
	}
}
