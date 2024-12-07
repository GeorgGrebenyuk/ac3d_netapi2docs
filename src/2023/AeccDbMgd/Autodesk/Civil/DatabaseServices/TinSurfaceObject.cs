using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000AA3 RID: 2723
	public abstract class TinSurfaceObject : IDisposable
	{
		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x0600147B RID: 5243
		public virtual extern bool IsValid { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x0600147C RID: 5244
		public virtual extern TinSurface Surface { get; }

		// Token: 0x0600147D RID: 5245
		[return: MarshalAs(UnmanagedType.U1)]
		public override extern bool Equals(object rhs);

		// Token: 0x0600147E RID: 5246
		public override extern int GetHashCode();

		// Token: 0x0600147F RID: 5247
		protected unsafe extern AeccSurfaceTin* GetAeccSurfaceTin();

		// Token: 0x06001480 RID: 5248
		protected virtual extern void CheckValid();

		// Token: 0x06001481 RID: 5249
		[HandleProcessCorruptedStateExceptions]
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x06001482 RID: 5250
		public sealed extern void Dispose();

		// Token: 0x06001483 RID: 5251
		protected override extern void Finalize();

		// Token: 0x0400146B RID: 5227
		protected unsafe AeccSurfaceAPITinObject* m_pSurfaceAPIObject;
	}
}
