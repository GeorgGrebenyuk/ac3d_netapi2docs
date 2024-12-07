using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x020005CD RID: 1485
[NativeCppClass]
[StructLayout(LayoutKind.Sequential, Size = 16)]
internal struct AeccFilename
{
	// Token: 0x06000DE5 RID: 3557
	public unsafe static extern void <MarshalCopy>(AeccFilename* A_0, AeccFilename* A_1);

	// Token: 0x06000DE6 RID: 3558
	public unsafe static extern void <MarshalDestroy>(AeccFilename* A_0);

	// Token: 0x04000FF1 RID: 4081
	private long <alignment\u0020member>;

	// Token: 0x020005CE RID: 1486
	[CLSCompliant(false)]
	[NativeCppClass]
	public enum FS_BUILTINS
	{

	}

	// Token: 0x020005CF RID: 1487
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum AeccFilenameFlags
	{

	}
}
