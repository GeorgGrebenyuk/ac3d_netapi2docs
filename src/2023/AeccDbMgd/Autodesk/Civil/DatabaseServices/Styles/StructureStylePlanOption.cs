using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02001054 RID: 4180
	public sealed class StructureStylePlanOption : CivilWrapper<AeccDbStructureStyle>
	{
		// Token: 0x170010DA RID: 4314
		// (get) Token: 0x0600216D RID: 8557
		// (set) Token: 0x0600216E RID: 8558
		public extern StructurePlanViewType PlanViewOptions { get; set; }

		// Token: 0x170010D9 RID: 4313
		// (get) Token: 0x0600216F RID: 8559
		// (set) Token: 0x06002170 RID: 8560
		public extern StructureSizeOptionsType SizeType { get; set; }

		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x06002171 RID: 8561
		// (set) Token: 0x06002172 RID: 8562
		public extern string SymbolBlockName { get; set; }

		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x06002173 RID: 8563
		// (set) Token: 0x06002174 RID: 8564
		public extern double SymbolBlockXScale { get; set; }

		// Token: 0x170010D6 RID: 4310
		// (get) Token: 0x06002175 RID: 8565
		// (set) Token: 0x06002176 RID: 8566
		public extern double SymbolBlockYScale { get; set; }

		// Token: 0x170010D5 RID: 4309
		// (get) Token: 0x06002177 RID: 8567
		// (set) Token: 0x06002178 RID: 8568
		public extern double SymbolBlockZScale { get; set; }

		// Token: 0x170010D4 RID: 4308
		// (get) Token: 0x06002179 RID: 8569
		// (set) Token: 0x0600217A RID: 8570
		public extern bool MaskConnectedObjects { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170010D3 RID: 4307
		// (get) Token: 0x0600217B RID: 8571
		// (set) Token: 0x0600217C RID: 8572
		public extern double Size { get; set; }

		// Token: 0x170010D2 RID: 4306
		// (get) Token: 0x0600217D RID: 8573
		// (set) Token: 0x0600217E RID: 8574
		public extern double SizePercent { get; set; }
	}
}
