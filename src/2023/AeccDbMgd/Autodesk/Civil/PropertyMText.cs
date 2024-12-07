using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Autodesk.Civil
{
	// Token: 0x02000037 RID: 55
	public class PropertyMText : PropertyString
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000144 RID: 324
		// (set) Token: 0x06000143 RID: 323
		public override extern string Value { get; set; }

		// Token: 0x06000145 RID: 325
		[HandleProcessCorruptedStateExceptions]
		protected override extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x040002E4 RID: 740
		private int <SyntheticNonEmptyStructMarker>;
	}
}
