using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200112E RID: 4398
	public sealed class CalculatedPointCollection : CivilWrapper<AeccDbCorridor>, IEnumerable<CalculatedPoint>
	{
		// Token: 0x170012F3 RID: 4851
		// (get) Token: 0x0600244D RID: 9293
		public extern ObjectId CorridorId { get; }

		// Token: 0x170012F2 RID: 4850
		// (get) Token: 0x0600244E RID: 9294
		public extern int Count { get; }

		// Token: 0x170012F1 RID: 4849
		public extern CalculatedPoint this[int index]
		{
			get;
		}

		// Token: 0x06002450 RID: 9296
		public extern CalculatedPoint Add(CalculatedLink link, string code);

		// Token: 0x06002451 RID: 9297
		public extern void RemoveAt(int index);

		// Token: 0x06002452 RID: 9298
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(CalculatedPoint point);

		// Token: 0x06002453 RID: 9299
		public extern IEnumerator<CalculatedPoint> GetEnumerator();

		// Token: 0x06002454 RID: 9300
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x04001A85 RID: 6789
		private int <SyntheticNonEmptyStructMarker>;
	}
}
