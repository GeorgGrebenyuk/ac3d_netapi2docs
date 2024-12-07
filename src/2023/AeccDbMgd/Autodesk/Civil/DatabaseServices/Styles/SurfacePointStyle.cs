using System;
using Autodesk.AutoCAD.Colors;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F84 RID: 3972
	public sealed class SurfacePointStyle : SurfaceBaseStyle
	{
		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x06001EC0 RID: 7872
		// (set) Token: 0x06001EC1 RID: 7873
		public extern ScaleType ScalingMethodType { get; set; }

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x06001EC2 RID: 7874
		// (set) Token: 0x06001EC3 RID: 7875
		public extern double Units { get; set; }

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x06001EC4 RID: 7876
		// (set) Token: 0x06001EC5 RID: 7877
		public extern PointSymbolType DataPointsSymbol { get; set; }

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x06001EC6 RID: 7878
		// (set) Token: 0x06001EC7 RID: 7879
		public extern Color DataPointsColor { get; set; }

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x06001EC8 RID: 7880
		// (set) Token: 0x06001EC9 RID: 7881
		public extern PointSymbolType DerivedPointsSymbol { get; set; }

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x06001ECA RID: 7882
		// (set) Token: 0x06001ECB RID: 7883
		public extern Color DerivedPointsColor { get; set; }

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x06001ECC RID: 7884
		// (set) Token: 0x06001ECD RID: 7885
		public extern PointSymbolType NondestructivePointsSymbol { get; set; }

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x06001ECE RID: 7886
		// (set) Token: 0x06001ECF RID: 7887
		public extern Color NondestructivePointsColor { get; set; }
	}
}
