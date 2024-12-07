using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200112F RID: 4399
	public sealed class CalculatedLinkCollection : CivilWrapper<AeccDbCorridor>, IEnumerable<CalculatedLink>
	{
		// Token: 0x170012F6 RID: 4854
		// (get) Token: 0x06002455 RID: 9301
		public extern ObjectId CorridorId { get; }

		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x06002456 RID: 9302
		public extern int Count { get; }

		// Token: 0x170012F4 RID: 4852
		public extern CalculatedLink this[int index]
		{
			get;
		}

		// Token: 0x06002458 RID: 9304
		public extern CalculatedLink Add(CalculatedPoint point1, CalculatedPoint point2, string code);

		// Token: 0x06002459 RID: 9305
		public extern void RemoveAt(int index);

		// Token: 0x0600245A RID: 9306
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(CalculatedLink link);

		// Token: 0x0600245B RID: 9307
		public extern IEnumerator<CalculatedLink> GetEnumerator();

		// Token: 0x0600245C RID: 9308
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x04001A86 RID: 6790
		private int <SyntheticNonEmptyStructMarker>;
	}
}
