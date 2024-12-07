using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020009D9 RID: 2521
	public abstract class SurfaceDefinitionBase<T>
	{
		// Token: 0x170007C1 RID: 1985
		public extern T this[int index]
		{
			get;
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x060012AF RID: 4783
		public extern int Count { get; }

		// Token: 0x060012B0 RID: 4784
		public extern SurfaceDefinitionBase(Surface surface);

		// Token: 0x060012B1 RID: 4785
		public extern void RemoveAt(int index);

		// Token: 0x060012B2 RID: 4786
		[return: MarshalAs(UnmanagedType.U1)]
		protected unsafe abstract bool IsCorrectOperation(AeccSurfaceOp* pOp);

		// Token: 0x060012B3 RID: 4787
		protected unsafe static extern AcArray<void\u0020*,AcArrayMemCopyReallocator<void\u0020*>\u0020>* ToAcGeVoidPointerArray(AcArray<void\u0020*,AcArrayMemCopyReallocator<void\u0020*>\u0020>*, Point3dCollection cliPoints);

		// Token: 0x040013CF RID: 5071
		protected Surface m_pSurface;
	}
}
