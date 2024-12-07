using System;
using System.Collections;
using System.Collections.Generic;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000BF0 RID: 3056
	public class SubassemblyTargetInfoCollection : DisposableWrapper, IEnumerable<SubassemblyTargetInfo>
	{
		// Token: 0x17000A13 RID: 2579
		public extern SubassemblyTargetInfo this[int index]
		{
			get;
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06001710 RID: 5904
		public extern int Count { get; }

		// Token: 0x06001711 RID: 5905
		public virtual extern IEnumerator<SubassemblyTargetInfo> GetEnumerator();

		// Token: 0x06001712 RID: 5906
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x06001713 RID: 5907
		protected override extern void DeleteUnmanagedObject();

		// Token: 0x04001575 RID: 5493
		private int <SyntheticNonEmptyStructMarker>;
	}
}
