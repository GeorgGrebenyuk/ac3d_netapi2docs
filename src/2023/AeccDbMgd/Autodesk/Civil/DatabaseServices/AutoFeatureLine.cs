using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000075 RID: 117
	[Wrapper("AeccDbAutoFeatureLine")]
	public sealed class AutoFeatureLine : FeatureLine
	{
		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x0600055F RID: 1375
		// (set) Token: 0x06000560 RID: 1376
		public extern ObjectId ProfileId { get; set; }

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000561 RID: 1377
		public extern ObjectId AlignmentId { get; }

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000562 RID: 1378
		public extern ObjectId SourceObjectId { get; }

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000563 RID: 1379
		public extern string SourceObjectName { get; }

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000564 RID: 1380
		// (set) Token: 0x06000565 RID: 1381
		public extern double VerticalDeviation { get; set; }

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000566 RID: 1382
		// (set) Token: 0x06000567 RID: 1383
		public extern double SpiralTessellation { get; set; }

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000568 RID: 1384
		// (set) Token: 0x06000569 RID: 1385
		public extern bool AutomaticUpdate { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x0600056A RID: 1386
		public extern void DetachAlignment();

		// Token: 0x0600056B RID: 1387
		public extern void ReAttachAlignment();
	}
}
