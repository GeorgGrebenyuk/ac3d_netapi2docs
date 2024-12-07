using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000708 RID: 1800
	public abstract class BandSetItemCollection : IDisposable
	{
		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06000E22 RID: 3618
		public extern BandLocationType Location { get; }

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06000E23 RID: 3619
		public extern int Count { get; }

		// Token: 0x06000E24 RID: 3620
		public extern void RemoveAt(int index);

		// Token: 0x06000E25 RID: 3621
		public extern void RemoveAll();

		// Token: 0x06000E26 RID: 3622
		public extern void Swap(int index1, int index2);

		// Token: 0x06000E27 RID: 3623
		public extern void Add(ObjectId bandStyleId);

		// Token: 0x06000E28 RID: 3624
		public extern BandSetItemCollection(BandLocationType location);

		// Token: 0x06000E29 RID: 3625
		protected unsafe abstract AeccDbBandStyleSetData* getInitializedAeccDbBandStyleSetData(AcDbObjectId oidBandStyle);

		// Token: 0x06000E2A RID: 3626
		[return: MarshalAs(UnmanagedType.U1)]
		protected abstract bool checkBandStyleIdByType(AcDbObjectId oidBandStyle);

		// Token: 0x06000E2B RID: 3627
		[HandleProcessCorruptedStateExceptions]
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x06000E2C RID: 3628
		public sealed extern void Dispose();

		// Token: 0x06000E2D RID: 3629
		protected override extern void Finalize();

		// Token: 0x04001107 RID: 4359
		private int <SyntheticNonEmptyStructMarker>;
	}
}
