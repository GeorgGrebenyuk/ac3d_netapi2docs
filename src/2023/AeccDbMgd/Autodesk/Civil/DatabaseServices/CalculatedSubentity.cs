using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200117A RID: 4474
	public abstract class CalculatedSubentity : CivilWrapper<AeccDbCorridor>
	{
		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x06002572 RID: 9586
		public extern ObjectId CorridorId { get; }

		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x06002573 RID: 9587
		public abstract CorridorCodeCollection CorridorCodes { get; }

		// Token: 0x17001373 RID: 4979
		// (get) Token: 0x06002574 RID: 9588
		public extern AppliedSubassembly SubassemblyBelongedTo { get; }

		// Token: 0x06002575 RID: 9589
		[HandleProcessCorruptedStateExceptions]
		protected override extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x04001AC9 RID: 6857
		private int <SyntheticNonEmptyStructMarker>;
	}
}
