using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000B8B RID: 2955
	public sealed class OffsetAssemblyCollection : IEnumerable<OffsetAssembly>
	{
		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06001607 RID: 5639
		public extern int Count { get; }

		// Token: 0x17000998 RID: 2456
		public extern OffsetAssembly this[string offsetAssemblyName]
		{
			get;
		}

		// Token: 0x17000999 RID: 2457
		public extern OffsetAssembly this[int index]
		{
			get;
		}

		// Token: 0x0600160A RID: 5642
		public extern OffsetAssembly Add(string offsetAssemblyName, Vector2d offset);

		// Token: 0x0600160B RID: 5643
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(OffsetAssembly offsetAssembly);

		// Token: 0x0600160C RID: 5644
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(string offsetAssemblyName);

		// Token: 0x0600160D RID: 5645
		public extern void RemoveAt(int index);

		// Token: 0x0600160E RID: 5646
		public extern IEnumerator<OffsetAssembly> GetEnumerator();

		// Token: 0x0600160F RID: 5647
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x04001517 RID: 5399
		private int <SyntheticNonEmptyStructMarker>;
	}
}
