using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000041 RID: 65
	public sealed class SurfaceContourStyle : SurfaceBaseStyle
	{
		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600018C RID: 396
		// (set) Token: 0x0600018D RID: 397
		public extern string LegendStyleName { get; set; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600018E RID: 398
		// (set) Token: 0x0600018F RID: 399
		public extern ObjectId LegendStyleId { get; set; }

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000190 RID: 400
		// (set) Token: 0x06000191 RID: 401
		public extern double BaseElevationInterval { get; set; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000192 RID: 402
		// (set) Token: 0x06000193 RID: 403
		public extern double MajorContourInterval { get; set; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000194 RID: 404
		// (set) Token: 0x06000195 RID: 405
		public extern double MinorContourInterval { get; set; }

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000196 RID: 406
		// (set) Token: 0x06000197 RID: 407
		public extern SurfaceGroupValuesByType GroupRangeValuesBy { get; set; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000198 RID: 408
		// (set) Token: 0x06000199 RID: 409
		public extern int NumberOfRanges { get; set; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600019A RID: 410
		// (set) Token: 0x0600019B RID: 411
		public extern PrecisionRangeType RangePrecision { get; set; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600019C RID: 412
		// (set) Token: 0x0600019D RID: 413
		public extern bool UseColorScheme { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600019E RID: 414
		// (set) Token: 0x0600019F RID: 415
		public extern ColorSchemeType MajorContourColorScheme { get; set; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001A0 RID: 416
		// (set) Token: 0x060001A1 RID: 417
		public extern ColorSchemeType MinorContourColorScheme { get; set; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001A2 RID: 418
		// (set) Token: 0x060001A3 RID: 419
		public extern bool DisplayDepressions { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001A4 RID: 420
		// (set) Token: 0x060001A5 RID: 421
		public extern double DepressionTickMarkInterval { get; set; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001A6 RID: 422
		// (set) Token: 0x060001A7 RID: 423
		public extern double DepressionTickMarkLength { get; set; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001A8 RID: 424
		// (set) Token: 0x060001A9 RID: 425
		public extern bool SmoothContours { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001AA RID: 426
		// (set) Token: 0x060001AB RID: 427
		public extern ContourSmoothingType SmoothingType { get; set; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001AC RID: 428
		// (set) Token: 0x060001AD RID: 429
		public extern int SmoothingFactor { get; set; }

		// Token: 0x060001AE RID: 430
		public extern ContourValues[] GetContourValues();

		// Token: 0x060001AF RID: 431
		public extern void SetContourValues(ContourValues[] contourValuesArray);
	}
}
