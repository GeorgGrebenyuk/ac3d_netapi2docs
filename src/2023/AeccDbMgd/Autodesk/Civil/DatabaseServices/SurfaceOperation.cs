using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000049 RID: 73
	public class SurfaceOperation : IDisposable
	{
		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000223 RID: 547
		// (set) Token: 0x06000224 RID: 548
		public virtual extern bool Enabled { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x06000225 RID: 549
		public virtual extern void MoveUp();

		// Token: 0x06000226 RID: 550
		public virtual extern void MoveDown();

		// Token: 0x06000227 RID: 551
		public virtual extern void MoveToTop();

		// Token: 0x06000228 RID: 552
		public virtual extern void MoveToBottom();

		// Token: 0x06000229 RID: 553
		[HandleProcessCorruptedStateExceptions]
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x0600022A RID: 554
		public sealed extern void Dispose();

		// Token: 0x0600022B RID: 555
		protected override extern void Finalize();

		// Token: 0x040002EB RID: 747
		private int <SyntheticNonEmptyStructMarker>;
	}
}
