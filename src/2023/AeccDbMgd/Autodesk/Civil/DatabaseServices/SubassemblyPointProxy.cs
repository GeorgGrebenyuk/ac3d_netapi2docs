using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020011CB RID: 4555
	internal sealed class SubassemblyPointProxy : IPointProxy
	{
		// Token: 0x0600265C RID: 9820
		public unsafe extern SubassemblyPointProxy(AeccDbSubassembly* pSubassembly, int index);

		// Token: 0x0600265D RID: 9821
		public extern double GetStation();

		// Token: 0x0600265E RID: 9822
		public extern double GetOffset();

		// Token: 0x0600265F RID: 9823
		public extern void SetOffset(double value);

		// Token: 0x06002660 RID: 9824
		public extern double GetElevation();

		// Token: 0x06002661 RID: 9825
		public extern void SetElevation(double value);

		// Token: 0x06002662 RID: 9826
		public extern void GetXYZ(ref double x, ref double y, ref double z);

		// Token: 0x06002663 RID: 9827
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool GetIsLoopPoint();

		// Token: 0x06002664 RID: 9828
		public extern void SetIsLoopPoint([MarshalAs(UnmanagedType.U1)] bool bUseForcedLoopPoint);

		// Token: 0x06002665 RID: 9829
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool GetIsHidden();

		// Token: 0x06002666 RID: 9830
		public extern void SetIsHidden([MarshalAs(UnmanagedType.U1)] bool newValue);

		// Token: 0x04001B10 RID: 6928
		private int <SyntheticNonEmptyStructMarker>;
	}
}
