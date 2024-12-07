using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020011F5 RID: 4597
	[Wrapper("AeccDbQuantityTakeoffCriteria")]
	public sealed class QuantityTakeoffCriteriaData : CivilWrapper<AeccDbQuantityTakeoffCriteria>
	{
		// Token: 0x170013D9 RID: 5081
		// (get) Token: 0x060026D6 RID: 9942
		public extern string Name { get; }

		// Token: 0x170013D8 RID: 5080
		// (get) Token: 0x060026D7 RID: 9943
		// (set) Token: 0x060026D8 RID: 9944
		public extern MaterialConditionType Condition { get; set; }

		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x060026D9 RID: 9945
		public extern MaterialItemType ItemType { get; }

		// Token: 0x04001B30 RID: 6960
		private int <SyntheticNonEmptyStructMarker>;
	}
}
