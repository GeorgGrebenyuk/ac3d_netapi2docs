using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil
{
	// Token: 0x0200001D RID: 29
	public interface IProperty
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000C8 RID: 200
		// (set) Token: 0x060000C9 RID: 201
		bool Locked { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000CA RID: 202
		// (set) Token: 0x060000CB RID: 203
		bool Overridden { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000CC RID: 204
		bool IsOverridable { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060000CD RID: 205
		// (set) Token: 0x060000CE RID: 206
		object Value { get; set; }
	}
}
