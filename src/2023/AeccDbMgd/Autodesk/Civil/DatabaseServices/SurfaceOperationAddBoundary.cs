using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020009CF RID: 2511
	public class SurfaceOperationAddBoundary : SurfaceOperation, IEnumerable<SurfaceBoundary>
	{
		// Token: 0x170007A3 RID: 1955
		public extern SurfaceBoundary this[int index]
		{
			get;
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06001284 RID: 4740
		public extern int Count { get; }

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06001285 RID: 4741
		// (set) Token: 0x06001286 RID: 4742
		public extern string Name { get; set; }

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06001287 RID: 4743
		public extern SurfaceBoundaryType BoundaryType { get; }

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06001288 RID: 4744
		public extern bool IsTrimmed { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06001289 RID: 4745
		public extern double MidOrdinateDistance { get; }

		// Token: 0x0600128A RID: 4746
		public extern ObjectIdCollection InsertIntoDrawing();

		// Token: 0x0600128B RID: 4747
		public virtual extern IEnumerator<SurfaceBoundary> GetEnumerator();

		// Token: 0x0600128C RID: 4748
		public extern IEnumerator GetObjectEnumerator();
	}
}
