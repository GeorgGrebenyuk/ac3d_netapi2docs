using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Autodesk.Civil
{
	// Token: 0x0200002F RID: 47
	public class PropertyArrowhead : PropertyString
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000129 RID: 297
		// (set) Token: 0x0600012A RID: 298
		public override extern string Value { get; set; }

		// Token: 0x0600012B RID: 299
		[HandleProcessCorruptedStateExceptions]
		protected override extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x040002E2 RID: 738
		private int <SyntheticNonEmptyStructMarker>;
	}
}
