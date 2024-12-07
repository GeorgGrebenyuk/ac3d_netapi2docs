using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02001052 RID: 4178
	public sealed class StructureStyleModelOption : CivilWrapper<AeccDbStructureStyle>
	{
		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x06002151 RID: 8529
		// (set) Token: 0x06002152 RID: 8530
		public extern StructureModelViewOptionType ModelViewOptions { get; set; }

		// Token: 0x170010C4 RID: 4292
		// (get) Token: 0x06002153 RID: 8531
		// (set) Token: 0x06002154 RID: 8532
		public extern StructureSimpleSolidType SimpleSolidType { get; set; }
	}
}
