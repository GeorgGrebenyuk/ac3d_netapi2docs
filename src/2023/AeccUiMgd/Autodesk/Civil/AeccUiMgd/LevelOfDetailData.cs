using System;
using System.ComponentModel;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.AeccUiMgd
{
	// Token: 0x0200000A RID: 10
	public class LevelOfDetailData : INotifyPropertyChanged, IDisposable
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3
		public static extern LevelOfDetailData CurrentData { get; }

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000004 RID: 4
		// (remove) Token: 0x06000005 RID: 5
		public virtual extern event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000007 RID: 7
		// (set) Token: 0x06000008 RID: 8
		public extern bool Enabled { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x06000009 RID: 9
		public extern void DestroyUnmanagedDataObserver();

		// Token: 0x0600000A RID: 10
		[HandleProcessCorruptedStateExceptions]
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x0600000B RID: 11
		public sealed extern void Dispose();

		// Token: 0x0600000C RID: 12
		protected override extern void Finalize();

		// Token: 0x04000045 RID: 69
		private int <SyntheticNonEmptyStructMarker>;
	}
}
