using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.AeccUiMgd.PressurePipes
{
	// Token: 0x020000A4 RID: 164
	public abstract class LayoutListData : INotifyPropertyChanged, IDisposable
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600004C RID: 76
		// (remove) Token: 0x0600004D RID: 77
		public virtual extern event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600004F RID: 79
		public extern ObservableCollection<PressureListData> SurfaceList { get; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000050 RID: 80
		public extern bool HasSurface { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000051 RID: 81
		public extern ObservableCollection<PressureListData> AlignmentList { get; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000052 RID: 82
		public extern bool HasAlignment { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000053 RID: 83
		public extern ObservableCollection<PressureListData> PartLists { get; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000054 RID: 84
		public extern ObservableCollection<PressurePartData> PressurePipeList { get; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000055 RID: 85
		public extern ObservableCollection<PressurePartData> FittingList { get; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000056 RID: 86
		public extern ObservableCollection<PressurePartData> AppurtenanceList { get; }

		// Token: 0x06000057 RID: 87
		public virtual extern void NotifyPropertyChanged(string propertyName);

		// Token: 0x06000058 RID: 88
		protected extern LayoutListData();

		// Token: 0x06000059 RID: 89
		[HandleProcessCorruptedStateExceptions]
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x0600005A RID: 90
		public sealed extern void Dispose();

		// Token: 0x0600005B RID: 91
		protected override extern void Finalize();

		// Token: 0x040000C8 RID: 200
		private int <SyntheticNonEmptyStructMarker>;
	}
}
