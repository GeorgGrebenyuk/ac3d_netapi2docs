using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020009E4 RID: 2532
	public abstract class GridSurfaceObject : IDisposable
	{
		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x060012C9 RID: 4809
		public virtual extern bool IsValid { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x060012CA RID: 4810
		public virtual extern GridSurface Surface { get; }

		// Token: 0x060012CB RID: 4811
		protected unsafe extern AeccSurfaceGrid* getAeccSurfaceGrid();

		// Token: 0x060012CC RID: 4812
		[HandleProcessCorruptedStateExceptions]
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x060012CD RID: 4813
		public sealed extern void Dispose();

		// Token: 0x060012CE RID: 4814
		protected override extern void Finalize();

		// Token: 0x040013D1 RID: 5073
		protected unsafe AeccSurfaceAPIGridObject* m_pSurfaceAPIObject;
	}
}
