using System;
using Autodesk.AutoCAD.Colors;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000982 RID: 2434
	public class PointCloudPointStyle
	{
		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06001257 RID: 4695
		// (set) Token: 0x06001258 RID: 4696
		public extern int SizeInPixels { get; set; }

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06001259 RID: 4697
		// (set) Token: 0x0600125A RID: 4698
		public extern PointCouldColorSchemeType PointsColorScheme { get; set; }

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x0600125B RID: 4699
		// (set) Token: 0x0600125C RID: 4700
		public extern PointCloudRangeColorSchemeType ScaledColorIntensityScheme { get; set; }

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x0600125D RID: 4701
		// (set) Token: 0x0600125E RID: 4702
		public extern double IntensityRangeMinimum { get; set; }

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x0600125F RID: 4703
		// (set) Token: 0x06001260 RID: 4704
		public extern double IntensityRangeMaximum { get; set; }

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06001261 RID: 4705
		// (set) Token: 0x06001262 RID: 4706
		public extern Color SingleColor { get; set; }

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06001263 RID: 4707
		// (set) Token: 0x06001264 RID: 4708
		public extern PointCloudElevationRangeCreationType ElevatinoRangeCreationType { get; set; }

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06001265 RID: 4709
		// (set) Token: 0x06001266 RID: 4710
		public extern PointCloudRangeColorSchemeType RangesColorScheme { get; set; }

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06001267 RID: 4711
		// (set) Token: 0x06001268 RID: 4712
		public extern int NumberOfElevationRanges { get; set; }

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06001269 RID: 4713
		// (set) Token: 0x0600126A RID: 4714
		public extern double ElevationRangeInterval { get; set; }

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x0600126B RID: 4715
		// (set) Token: 0x0600126C RID: 4716
		public extern PointDisplay3dType Display3dType { get; set; }

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x0600126D RID: 4717
		// (set) Token: 0x0600126E RID: 4718
		public extern double PointElevation { get; set; }

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x0600126F RID: 4719
		// (set) Token: 0x06001270 RID: 4720
		public extern double ScaleFactor { get; set; }

		// Token: 0x04001385 RID: 4997
		private int <SyntheticNonEmptyStructMarker>;
	}
}
