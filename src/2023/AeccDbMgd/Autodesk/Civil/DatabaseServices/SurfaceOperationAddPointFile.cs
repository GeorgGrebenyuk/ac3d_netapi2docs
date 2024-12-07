using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A3C RID: 2620
	public class SurfaceOperationAddPointFile : SurfaceOperation
	{
		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x060013C8 RID: 5064
		public extern PointFileFormat FileFormat { get; }

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x060013C9 RID: 5065
		// (set) Token: 0x060013CA RID: 5066
		public extern string PointFileName { get; set; }

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x060013CB RID: 5067
		public extern bool UseAdjustedElevation { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x060013CC RID: 5068
		public extern bool ShouldTransformPointCoordinates { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x060013CD RID: 5069
		public extern bool ShouldExpandCoordinateData { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x060013CE RID: 5070
		[HandleProcessCorruptedStateExceptions]
		protected override extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x04001421 RID: 5153
		private int <SyntheticNonEmptyStructMarker>;
	}
}
