using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020011C9 RID: 4553
	internal interface IPointProxy
	{
		// Token: 0x06002647 RID: 9799
		double GetStation();

		// Token: 0x06002648 RID: 9800
		double GetOffset();

		// Token: 0x06002649 RID: 9801
		void SetOffset(double value);

		// Token: 0x0600264A RID: 9802
		double GetElevation();

		// Token: 0x0600264B RID: 9803
		void SetElevation(double value);

		// Token: 0x0600264C RID: 9804
		void GetXYZ(ref double x, ref double y, ref double z);

		// Token: 0x0600264D RID: 9805
		[return: MarshalAs(UnmanagedType.U1)]
		bool GetIsLoopPoint();

		// Token: 0x0600264E RID: 9806
		void SetIsLoopPoint([MarshalAs(UnmanagedType.U1)] bool bUseForcedLoopPoint);

		// Token: 0x0600264F RID: 9807
		[return: MarshalAs(UnmanagedType.U1)]
		bool GetIsHidden();

		// Token: 0x06002650 RID: 9808
		void SetIsHidden([MarshalAs(UnmanagedType.U1)] bool newValue);
	}
}
