using System;
using System.ComponentModel;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.AeccUiMgd.PressurePipes
{
	// Token: 0x02000098 RID: 152
	public class LayoutCommandStates : INotifyPropertyChanged, IDisposable
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600002B RID: 43
		// (remove) Token: 0x0600002C RID: 44
		public virtual extern event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600002E RID: 46
		// (set) Token: 0x0600002F RID: 47
		public extern bool IsPipesAndBendsActive { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000030 RID: 48
		// (set) Token: 0x06000031 RID: 49
		public extern bool IsPipesOnlyActive { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000032 RID: 50
		// (set) Token: 0x06000033 RID: 51
		public extern bool IsAddFittingActive { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000034 RID: 52
		// (set) Token: 0x06000035 RID: 53
		public extern bool IsAddAppurtenanceActive { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000036 RID: 54
		// (set) Token: 0x06000037 RID: 55
		public extern bool IsProfilePipesAndBendsActive { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000038 RID: 56
		// (set) Token: 0x06000039 RID: 57
		public extern bool IsProfileAddPressurePipeActive { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003A RID: 58
		// (set) Token: 0x0600003B RID: 59
		public extern bool IsProfileAddBendActive { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003C RID: 60
		// (set) Token: 0x0600003D RID: 61
		public extern bool IsProfileAddAppurtenanceActive { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003E RID: 62
		// (set) Token: 0x0600003F RID: 63
		public extern bool IsAddBranchFittingActive { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000040 RID: 64
		// (set) Token: 0x06000041 RID: 65
		public extern bool IsAddPipeRunBendActive { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000042 RID: 66
		// (set) Token: 0x06000043 RID: 67
		public extern bool IsRemovePipeRunPIActive { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000044 RID: 68
		// (set) Token: 0x06000045 RID: 69
		public extern bool IsAddPipeRunVBendActive { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000046 RID: 70
		// (set) Token: 0x06000047 RID: 71
		public extern bool IsRemovePipeRunPVIActive { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x06000048 RID: 72
		[HandleProcessCorruptedStateExceptions]
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x06000049 RID: 73
		public sealed extern void Dispose();

		// Token: 0x0600004A RID: 74
		protected override extern void Finalize();

		// Token: 0x040000BD RID: 189
		private int <SyntheticNonEmptyStructMarker>;
	}
}
