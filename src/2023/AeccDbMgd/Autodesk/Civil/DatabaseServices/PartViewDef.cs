using System;
using Autodesk.Aec.DatabaseServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000D2 RID: 210
	[Wrapper("AeccNetworkPartViewDef")]
	public class PartViewDef : ImpObject
	{
		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x060009C8 RID: 2504
		public extern ObjectId PartBodyGraphicsBlockId { get; }

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x060009C9 RID: 2505
		public extern string PartBodyGraphicsBlockName { get; }

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x060009CA RID: 2506
		public extern ObjectId BoundingBodyBlockId { get; }

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x060009CB RID: 2507
		public extern string BoundingBodyBlockName { get; }

		// Token: 0x04000309 RID: 777
		private int <SyntheticNonEmptyStructMarker>;
	}
}
