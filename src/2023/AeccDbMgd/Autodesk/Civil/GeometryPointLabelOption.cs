using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil
{
	// Token: 0x02000119 RID: 281
	public class GeometryPointLabelOption<T> where T : Enum
	{
		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06000C5B RID: 3163
		// (set) Token: 0x06000C5C RID: 3164
		public extern T PointType { get; set; }

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06000C5D RID: 3165
		// (set) Token: 0x06000C5E RID: 3166
		public extern bool Selected { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x06000C5F RID: 3167
		public extern GeometryPointLabelOption();

		// Token: 0x0400031C RID: 796
		private int <SyntheticNonEmptyStructMarker>;
	}
}
