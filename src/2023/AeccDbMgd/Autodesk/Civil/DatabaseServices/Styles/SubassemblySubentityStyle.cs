using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000E2 RID: 226
	public abstract class SubassemblySubentityStyle : StyleBase
	{
		// Token: 0x06000A32 RID: 2610
		protected internal extern SubassemblySubentityStyle(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000A33 RID: 2611
		public virtual extern SubassemblySubentityStyleType StyleType { get; }
	}
}
