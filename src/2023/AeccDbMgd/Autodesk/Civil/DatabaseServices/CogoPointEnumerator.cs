using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200088D RID: 2189
	public sealed class CogoPointEnumerator : IEnumerator<ObjectId>
	{
		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x060010E4 RID: 4324
		public extern object CurrentObject { get; }

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x060010E5 RID: 4325
		public extern ObjectId Current { get; }

		// Token: 0x060010E6 RID: 4326
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool MoveNext();

		// Token: 0x060010E7 RID: 4327
		public extern void Reset();

		// Token: 0x060010E8 RID: 4328
		public sealed extern void Dispose();

		// Token: 0x040012A3 RID: 4771
		private int <SyntheticNonEmptyStructMarker>;
	}
}
