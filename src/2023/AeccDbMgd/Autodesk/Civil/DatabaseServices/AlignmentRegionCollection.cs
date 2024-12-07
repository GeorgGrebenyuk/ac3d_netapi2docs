using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000DF8 RID: 3576
	public sealed class AlignmentRegionCollection : CivilWrapper<AeccDbAlignment>, IEnumerable<AlignmentRegion>
	{
		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x06001A6D RID: 6765
		public extern int Count { get; }

		// Token: 0x17000D35 RID: 3381
		public extern AlignmentRegion this[int index]
		{
			get;
		}

		// Token: 0x06001A6F RID: 6767
		public extern void Remove(int index);

		// Token: 0x06001A70 RID: 6768
		[DeprecatedVersion(CivilVersion.Civil2010)]
		[Obsolete("Functionality has been removed.", false)]
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool MergeToNeighborRegion(int index, [MarshalAs(UnmanagedType.U1)] bool preRegion);

		// Token: 0x06001A71 RID: 6769
		public extern IEnumerator<AlignmentRegion> GetEnumerator();

		// Token: 0x06001A72 RID: 6770
		public extern IEnumerator GetObjectEnumerator();
	}
}
