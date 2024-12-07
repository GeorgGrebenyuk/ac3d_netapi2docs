using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.Internal
{
	// Token: 0x02000006 RID: 6
	public class AdpWaypoint : IDisposable
	{
		// Token: 0x06000003 RID: 3
		public extern AdpWaypoint(string wpName);

		// Token: 0x06000004 RID: 4
		public extern void addAttribute(string name, int value);

		// Token: 0x06000005 RID: 5
		public extern void addAttribute(string name, [MarshalAs(UnmanagedType.U1)] bool value);

		// Token: 0x06000006 RID: 6
		public extern void addAttribute(string name, string value, [MarshalAs(UnmanagedType.U1)] bool fullName);

		// Token: 0x06000007 RID: 7
		public extern void reached();

		// Token: 0x06000008 RID: 8
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x06000009 RID: 9
		public sealed extern void Dispose();

		// Token: 0x04000009 RID: 9
		private int <SyntheticNonEmptyStructMarker>;
	}
}
