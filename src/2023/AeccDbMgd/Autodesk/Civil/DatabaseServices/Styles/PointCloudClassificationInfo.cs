using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Colors;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000972 RID: 2418
	public class PointCloudClassificationInfo : IDisposable
	{
		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06001243 RID: 4675
		// (set) Token: 0x06001244 RID: 4676
		public extern bool Selected { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06001245 RID: 4677
		// (set) Token: 0x06001246 RID: 4678
		public extern Color Color { get; set; }

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06001247 RID: 4679
		// (set) Token: 0x06001248 RID: 4680
		public extern ObjectId LayerId { get; set; }

		// Token: 0x06001249 RID: 4681
		[HandleProcessCorruptedStateExceptions]
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x0600124A RID: 4682
		public sealed extern void Dispose();

		// Token: 0x0600124B RID: 4683
		protected override extern void Finalize();

		// Token: 0x04001376 RID: 4982
		private int <SyntheticNonEmptyStructMarker>;
	}
}
