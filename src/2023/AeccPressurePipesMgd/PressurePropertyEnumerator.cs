using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.Civil.DatabaseServices;

// Token: 0x0200012E RID: 302
internal sealed class PressurePropertyEnumerator : IEnumerator<PressurePartProperty>
{
	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x06000162 RID: 354
	public extern object CurrentObject { get; }

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x06000163 RID: 355
	public extern PressurePartProperty Current { get; }

	// Token: 0x06000164 RID: 356
	[return: MarshalAs(UnmanagedType.U1)]
	public extern bool MoveNext();

	// Token: 0x06000165 RID: 357
	public extern void Reset();

	// Token: 0x06000166 RID: 358
	public sealed extern void Dispose();

	// Token: 0x040001B2 RID: 434
	private int <SyntheticNonEmptyStructMarker>;
}
