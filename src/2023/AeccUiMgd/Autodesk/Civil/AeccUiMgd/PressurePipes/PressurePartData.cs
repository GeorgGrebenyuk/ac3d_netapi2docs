using System;
using System.Runtime.InteropServices;
using Autodesk.Civil.DatabaseServices.Styles;

namespace Autodesk.Civil.AeccUiMgd.PressurePipes
{
	// Token: 0x02000095 RID: 149
	public struct PressurePartData : IEquatable<PressurePartData>
	{
		// Token: 0x06000022 RID: 34
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Equals(PressurePartData rhs);

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000023 RID: 35
		// (set) Token: 0x06000024 RID: 36
		public extern string Text { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000025 RID: 37
		// (set) Token: 0x06000026 RID: 38
		public extern string IndentText { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000027 RID: 39
		// (set) Token: 0x06000028 RID: 40
		public extern bool IsEnabled { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x040000B8 RID: 184
		private string <backing_store>Text;

		// Token: 0x040000B9 RID: 185
		private string <backing_store>IndentText;

		// Token: 0x040000BA RID: 186
		private bool <backing_store>IsEnabled;

		// Token: 0x040000BB RID: 187
		private PressurePartSize <backing_store>PartObject;
	}
}
