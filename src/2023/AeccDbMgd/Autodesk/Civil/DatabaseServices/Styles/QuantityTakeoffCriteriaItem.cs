using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020011F3 RID: 4595
	[Wrapper("AeccDbQuantityTakeoffCriteria")]
	public sealed class QuantityTakeoffCriteriaItem : CivilWrapper<AeccDbQuantityTakeoffCriteria>
	{
		// Token: 0x170013D6 RID: 5078
		// (get) Token: 0x060026C1 RID: 9921
		// (set) Token: 0x060026C2 RID: 9922
		public extern string MaterialName { get; set; }

		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x060026C3 RID: 9923
		// (set) Token: 0x060026C4 RID: 9924
		public extern MaterialQuantityType QuantityType { get; set; }

		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x060026C5 RID: 9925
		// (set) Token: 0x060026C6 RID: 9926
		public extern double CutFactor { get; set; }

		// Token: 0x170013D3 RID: 5075
		// (get) Token: 0x060026C7 RID: 9927
		// (set) Token: 0x060026C8 RID: 9928
		public extern double FillFactor { get; set; }

		// Token: 0x170013D2 RID: 5074
		// (get) Token: 0x060026C9 RID: 9929
		// (set) Token: 0x060026CA RID: 9930
		public extern double ReFillFactor { get; set; }

		// Token: 0x170013D1 RID: 5073
		// (get) Token: 0x060026CB RID: 9931
		// (set) Token: 0x060026CC RID: 9932
		public extern ObjectId ShapeStyleId { get; set; }

		// Token: 0x170013D0 RID: 5072
		// (get) Token: 0x060026CD RID: 9933
		// (set) Token: 0x060026CE RID: 9934
		public extern string ShapeStyleName { get; set; }

		// Token: 0x170013CF RID: 5071
		public extern QuantityTakeoffCriteriaData this[int index]
		{
			get;
		}

		// Token: 0x170013CE RID: 5070
		// (get) Token: 0x060026D0 RID: 9936
		public extern int Count { get; }

		// Token: 0x060026D1 RID: 9937
		public extern void AddCorridorShape(string shapeName);

		// Token: 0x060026D2 RID: 9938
		public extern void AddSurface(string surfaceName);

		// Token: 0x060026D3 RID: 9939
		public extern void RemoveCorridorShape(string shapeName);

		// Token: 0x060026D4 RID: 9940
		public extern void RemoveSurface(string surfaceName);

		// Token: 0x04001B2F RID: 6959
		private int <SyntheticNonEmptyStructMarker>;
	}
}
