using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F94 RID: 3988
	public sealed class SurfaceWatershedStyle : SurfaceBaseStyle
	{
		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x06001F15 RID: 7957
		// (set) Token: 0x06001F16 RID: 7958
		public extern double PointUnits { get; set; }

		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x06001F17 RID: 7959
		// (set) Token: 0x06001F18 RID: 7960
		public extern ScalingMethodType PointScalingMethod { get; set; }

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x06001F19 RID: 7961
		// (set) Token: 0x06001F1A RID: 7962
		public extern string LegendStyleName { get; set; }

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06001F1B RID: 7963
		// (set) Token: 0x06001F1C RID: 7964
		public extern ObjectId LegendStyleId { get; set; }

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x06001F1D RID: 7965
		// (set) Token: 0x06001F1E RID: 7966
		public extern string LabelStyleName { get; set; }

		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x06001F1F RID: 7967
		// (set) Token: 0x06001F20 RID: 7968
		public extern ObjectId LabelStyleId { get; set; }

		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x06001F21 RID: 7969
		public extern WatershedBoundaryPointStyle BoundaryPointStyle { get; }

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x06001F22 RID: 7970
		public extern WatershedBoundarySegmentStyle BoundarySegmentStyle { get; }

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x06001F23 RID: 7971
		public extern WatershedDepressionStyle DepressionStyle { get; }

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x06001F24 RID: 7972
		public extern WatershedFlatAreaStyle FlatAreaStyle { get; }

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x06001F25 RID: 7973
		public extern WatershedMultipleDrainStyle MultipleDrainStyle { get; }

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x06001F26 RID: 7974
		public extern WatershedMultipleDrainNotchStyle MultipleDrainNotchStyle { get; }
	}
}
