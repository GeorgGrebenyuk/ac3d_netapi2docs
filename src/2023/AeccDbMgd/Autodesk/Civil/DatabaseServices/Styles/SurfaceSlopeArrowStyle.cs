using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F86 RID: 3974
	public sealed class SurfaceSlopeArrowStyle : SurfaceBaseStyle
	{
		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x06001ED0 RID: 7888
		// (set) Token: 0x06001ED1 RID: 7889
		public extern SurfaceGroupValuesByType GroupValuesBy { get; set; }

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x06001ED2 RID: 7890
		// (set) Token: 0x06001ED3 RID: 7891
		public extern int NumberOfRanges { get; set; }

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x06001ED4 RID: 7892
		// (set) Token: 0x06001ED5 RID: 7893
		public extern PrecisionRangeType RangePrecision { get; set; }

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x06001ED6 RID: 7894
		// (set) Token: 0x06001ED7 RID: 7895
		public extern SlopeArrowType ArrowType { get; set; }

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x06001ED8 RID: 7896
		// (set) Token: 0x06001ED9 RID: 7897
		public extern double ArrowScale { get; set; }

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x06001EDA RID: 7898
		// (set) Token: 0x06001EDB RID: 7899
		public extern ColorSchemeType ColorScheme { get; set; }

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x06001EDC RID: 7900
		// (set) Token: 0x06001EDD RID: 7901
		public extern ObjectId LegendStyleId { get; set; }

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x06001EDE RID: 7902
		// (set) Token: 0x06001EDF RID: 7903
		public extern string LegendStyleName { get; set; }
	}
}
