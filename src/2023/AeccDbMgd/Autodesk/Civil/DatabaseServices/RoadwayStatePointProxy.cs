using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020011CA RID: 4554
	internal sealed class RoadwayStatePointProxy : IPointProxy
	{
		// Token: 0x06002651 RID: 9809
		public unsafe extern RoadwayStatePointProxy(AeccDbRoadwayState* pRwState, int index);

		// Token: 0x06002652 RID: 9810
		public extern double GetStation();

		// Token: 0x06002653 RID: 9811
		public extern double GetOffset();

		// Token: 0x06002654 RID: 9812
		public extern void SetOffset(double value);

		// Token: 0x06002655 RID: 9813
		public extern double GetElevation();

		// Token: 0x06002656 RID: 9814
		public extern void SetElevation(double value);

		// Token: 0x06002657 RID: 9815
		public extern void GetXYZ(ref double x, ref double y, ref double z);

		// Token: 0x06002658 RID: 9816
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool GetIsLoopPoint();

		// Token: 0x06002659 RID: 9817
		public extern void SetIsLoopPoint([MarshalAs(UnmanagedType.U1)] bool bUseForcedLoopPoint);

		// Token: 0x0600265A RID: 9818
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool GetIsHidden();

		// Token: 0x0600265B RID: 9819
		public extern void SetIsHidden([MarshalAs(UnmanagedType.U1)] bool newValue);

		// Token: 0x04001B0F RID: 6927
		private int <SyntheticNonEmptyStructMarker>;
	}
}
