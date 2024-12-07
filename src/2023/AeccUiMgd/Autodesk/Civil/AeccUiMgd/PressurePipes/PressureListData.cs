using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.AeccUiMgd.PressurePipes
{
	// Token: 0x02000094 RID: 148
	public struct PressureListData : IEquatable<PressureListData>
	{
		// Token: 0x0600001B RID: 27
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Equals(PressureListData rhs);

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001C RID: 28
		// (set) Token: 0x0600001D RID: 29
		public extern string Name { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001E RID: 30
		// (set) Token: 0x0600001F RID: 31
		public extern IntPtr Icon { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000020 RID: 32
		// (set) Token: 0x06000021 RID: 33
		public extern bool IsEnabled { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x040000B4 RID: 180
		private string <backing_store>Name;

		// Token: 0x040000B5 RID: 181
		private IntPtr <backing_store>Icon;

		// Token: 0x040000B6 RID: 182
		private bool <backing_store>IsEnabled;

		// Token: 0x040000B7 RID: 183
		private ObjectId <backing_store>Oid;
	}
}
