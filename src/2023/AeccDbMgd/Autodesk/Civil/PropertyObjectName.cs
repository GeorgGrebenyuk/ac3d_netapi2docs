using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Autodesk.Civil
{
	// Token: 0x02000027 RID: 39
	public class PropertyObjectName : PropertyString
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000107 RID: 263
		// (set) Token: 0x06000108 RID: 264
		public override extern string Value { get; set; }

		// Token: 0x06000109 RID: 265
		[HandleProcessCorruptedStateExceptions]
		protected override extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x040002DE RID: 734
		private int <SyntheticNonEmptyStructMarker>;
	}
}
