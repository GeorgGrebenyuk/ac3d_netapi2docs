using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000BBF RID: 3007
	public sealed class CorridorSlopePatternCollection : CivilWrapper<AeccDbCorridor>, IEnumerable<CorridorSlopePattern>
	{
		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x060016BD RID: 5821
		public extern ObjectId CorridorId { get; }

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x060016BE RID: 5822
		public extern int Count { get; }

		// Token: 0x170009EF RID: 2543
		public extern CorridorSlopePattern this[int index]
		{
			get;
		}

		// Token: 0x060016C0 RID: 5824
		public extern CorridorSlopePattern Add(CorridorFeatureLine featureLine1, CorridorFeatureLine featureLine2, ObjectId slopePatternStyleId);

		// Token: 0x060016C1 RID: 5825
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(CorridorSlopePattern slopePattern);

		// Token: 0x060016C2 RID: 5826
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool RemoveAt(int index);

		// Token: 0x060016C3 RID: 5827
		public extern IEnumerator<CorridorSlopePattern> GetEnumerator();

		// Token: 0x060016C4 RID: 5828
		public extern IEnumerator GetObjectEnumerator();
	}
}
