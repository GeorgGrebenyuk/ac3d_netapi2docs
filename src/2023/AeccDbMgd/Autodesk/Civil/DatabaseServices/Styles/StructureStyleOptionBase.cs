using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02001053 RID: 4179
	public abstract class StructureStyleOptionBase : CivilWrapper<AeccDbStructureStyle>
	{
		// Token: 0x170010D1 RID: 4305
		// (get) Token: 0x06002155 RID: 8533
		// (set) Token: 0x06002156 RID: 8534
		public extern StructureViewType ViewOptions { get; set; }

		// Token: 0x170010D0 RID: 4304
		// (get) Token: 0x06002157 RID: 8535
		// (set) Token: 0x06002158 RID: 8536
		public extern StructureSizeOptionsType SizeType { get; set; }

		// Token: 0x170010CF RID: 4303
		// (get) Token: 0x06002159 RID: 8537
		// (set) Token: 0x0600215A RID: 8538
		public extern StructureInsertionLocation BlockInsertLocation { get; set; }

		// Token: 0x170010CE RID: 4302
		// (get) Token: 0x0600215B RID: 8539
		// (set) Token: 0x0600215C RID: 8540
		public extern string SymbolBlockName { get; set; }

		// Token: 0x170010CD RID: 4301
		// (get) Token: 0x0600215D RID: 8541
		// (set) Token: 0x0600215E RID: 8542
		public extern double SymbolBlockXScale { get; set; }

		// Token: 0x170010CC RID: 4300
		// (get) Token: 0x0600215F RID: 8543
		// (set) Token: 0x06002160 RID: 8544
		public extern double SymbolBlockYScale { get; set; }

		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x06002161 RID: 8545
		// (set) Token: 0x06002162 RID: 8546
		public extern double SymbolBlockZScale { get; set; }

		// Token: 0x170010CA RID: 4298
		// (get) Token: 0x06002163 RID: 8547
		// (set) Token: 0x06002164 RID: 8548
		public extern double XSize { get; set; }

		// Token: 0x170010C9 RID: 4297
		// (get) Token: 0x06002165 RID: 8549
		// (set) Token: 0x06002166 RID: 8550
		public extern double XSizePercent { get; set; }

		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x06002167 RID: 8551
		// (set) Token: 0x06002168 RID: 8552
		public extern double YSize { get; set; }

		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x06002169 RID: 8553
		// (set) Token: 0x0600216A RID: 8554
		public extern double YSizePercent { get; set; }

		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x0600216B RID: 8555
		// (set) Token: 0x0600216C RID: 8556
		public extern bool MaskConnectedObjects { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
	}
}
