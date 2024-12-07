using System;
using System.ComponentModel;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.AeccUiMgd.PressurePipes
{
	// Token: 0x020000A6 RID: 166
	public class PanoramaStates : INotifyPropertyChanged, IDisposable
	{
		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000086 RID: 134
		// (remove) Token: 0x06000087 RID: 135
		public virtual extern event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000089 RID: 137
		// (set) Token: 0x0600008A RID: 138
		public extern bool IsPanoramaActive { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x0600008B RID: 139
		[HandleProcessCorruptedStateExceptions]
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x0600008C RID: 140
		public sealed extern void Dispose();

		// Token: 0x0600008D RID: 141
		protected override extern void Finalize();

		// Token: 0x040000CB RID: 203
		private int <SyntheticNonEmptyStructMarker>;
	}
}
