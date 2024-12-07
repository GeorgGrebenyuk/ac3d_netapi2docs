using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000DED RID: 3565
	public class SampleLineVertex : CivilWrapper<AeccDbSampleLine>
	{
		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x06001A49 RID: 6729
		// (set) Token: 0x06001A4A RID: 6730
		public extern Point3d Location { get; set; }

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x06001A4B RID: 6731
		public extern SampleLineVertexSideType Side { get; }

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x06001A4C RID: 6732
		public extern int OffsetIndex { get; }

		// Token: 0x06001A4D RID: 6733
		[HandleProcessCorruptedStateExceptions]
		protected override extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x04001698 RID: 5784
		private int <SyntheticNonEmptyStructMarker>;
	}
}
