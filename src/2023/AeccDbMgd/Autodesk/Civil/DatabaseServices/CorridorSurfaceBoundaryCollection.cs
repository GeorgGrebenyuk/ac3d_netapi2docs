using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200116F RID: 4463
	public sealed class CorridorSurfaceBoundaryCollection : CivilWrapper<AeccDbCorridor>, IEnumerable<CorridorSurfaceBoundary>
	{
		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x06002520 RID: 9504
		public extern ObjectId CorridorId { get; }

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x06002521 RID: 9505
		public extern int Count { get; }

		// Token: 0x17001355 RID: 4949
		public extern CorridorSurfaceBoundary this[string boundaryName]
		{
			get;
		}

		// Token: 0x17001356 RID: 4950
		public extern CorridorSurfaceBoundary this[int index]
		{
			get;
		}

		// Token: 0x06002524 RID: 9508
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(CorridorSurfaceBoundary boundary);

		// Token: 0x06002525 RID: 9509
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(string boundaryName);

		// Token: 0x06002526 RID: 9510
		public extern void RemoveAt(int index);

		// Token: 0x06002527 RID: 9511
		public extern CorridorSurfaceBoundary AddCorridorExtentsBoundary(string boundaryName);

		// Token: 0x06002528 RID: 9512
		public extern CorridorSurfaceBoundary Add(string boundaryName, Point3dCollection points);

		// Token: 0x06002529 RID: 9513
		public extern CorridorSurfaceBoundary Add(string boundaryName, ObjectId polylineId);

		// Token: 0x0600252A RID: 9514
		public extern CorridorSurfaceBoundary Add(string boundaryName, string featureLineCode);

		// Token: 0x0600252B RID: 9515
		public extern CorridorSurfaceBoundary Add(string boundaryName);

		// Token: 0x0600252C RID: 9516
		public extern string[] BoundaryNames();

		// Token: 0x0600252D RID: 9517
		public extern IEnumerator<CorridorSurfaceBoundary> GetEnumerator();

		// Token: 0x0600252E RID: 9518
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x04001ABE RID: 6846
		private int <SyntheticNonEmptyStructMarker>;
	}
}
