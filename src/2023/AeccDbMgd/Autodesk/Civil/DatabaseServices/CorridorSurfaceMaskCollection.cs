using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001170 RID: 4464
	public sealed class CorridorSurfaceMaskCollection : CivilWrapper<AeccDbCorridor>, IEnumerable<CorridorSurfaceMask>
	{
		// Token: 0x1700135C RID: 4956
		// (get) Token: 0x0600252F RID: 9519
		public extern ObjectId CorridorId { get; }

		// Token: 0x1700135B RID: 4955
		// (get) Token: 0x06002530 RID: 9520
		public extern int Count { get; }

		// Token: 0x17001359 RID: 4953
		public extern CorridorSurfaceMask this[string maskName]
		{
			get;
		}

		// Token: 0x1700135A RID: 4954
		public extern CorridorSurfaceMask this[int index]
		{
			get;
		}

		// Token: 0x06002533 RID: 9523
		public extern CorridorSurfaceMask Add(string maskName, Point3dCollection points);

		// Token: 0x06002534 RID: 9524
		public extern CorridorSurfaceMask Add(string maskName, ObjectId polylineId);

		// Token: 0x06002535 RID: 9525
		public extern CorridorSurfaceMask Add(string maskName, string featureLineCode);

		// Token: 0x06002536 RID: 9526
		public extern CorridorSurfaceMask Add(string maskName);

		// Token: 0x06002537 RID: 9527
		public extern string[] MaskNames();

		// Token: 0x06002538 RID: 9528
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(CorridorSurfaceMask mask);

		// Token: 0x06002539 RID: 9529
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(string maskName);

		// Token: 0x0600253A RID: 9530
		public extern void RemoveAt(int index);

		// Token: 0x0600253B RID: 9531
		public extern IEnumerator<CorridorSurfaceMask> GetEnumerator();

		// Token: 0x0600253C RID: 9532
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x04001ABF RID: 6847
		private int <SyntheticNonEmptyStructMarker>;
	}
}
