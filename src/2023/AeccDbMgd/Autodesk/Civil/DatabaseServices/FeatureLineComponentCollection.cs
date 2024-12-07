using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200116D RID: 4461
	public sealed class FeatureLineComponentCollection : CivilWrapper<AeccDbCorridor>, IEnumerable<FeatureLineComponent>
	{
		// Token: 0x17001352 RID: 4946
		// (get) Token: 0x06002510 RID: 9488
		public extern ObjectId CorridorId { get; }

		// Token: 0x17001351 RID: 4945
		// (get) Token: 0x06002511 RID: 9489
		public extern int Count { get; }

		// Token: 0x17001350 RID: 4944
		public extern FeatureLineComponent this[int index]
		{
			get;
		}

		// Token: 0x06002513 RID: 9491
		public extern FeatureLineComponent Add(CorridorFeatureLine featureLine);

		// Token: 0x06002514 RID: 9492
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(FeatureLineComponent featureLineComponent);

		// Token: 0x06002515 RID: 9493
		public extern void RemoveAt(int index);

		// Token: 0x06002516 RID: 9494
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Validate();

		// Token: 0x06002517 RID: 9495
		public extern IEnumerator<FeatureLineComponent> GetEnumerator();

		// Token: 0x06002518 RID: 9496
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x06002519 RID: 9497
		public extern void SwapAt(int index1, int index2);

		// Token: 0x0600251A RID: 9498
		public extern void Swap(FeatureLineComponent component1, FeatureLineComponent component2);

		// Token: 0x04001ABC RID: 6844
		private int <SyntheticNonEmptyStructMarker>;
	}
}
