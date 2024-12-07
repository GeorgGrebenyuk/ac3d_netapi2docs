using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A58 RID: 2648
	public sealed class SurfaceMask : IDisposable
	{
		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x060013EE RID: 5102
		public extern ObjectId ObjectId { get; }

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x060013EF RID: 5103
		// (set) Token: 0x060013F0 RID: 5104
		public extern string Name { get; set; }

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x060013F1 RID: 5105
		// (set) Token: 0x060013F2 RID: 5106
		public extern string Description { get; set; }

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x060013F3 RID: 5107
		public extern ObjectId SurfaceId { get; }

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x060013F4 RID: 5108
		// (set) Token: 0x060013F5 RID: 5109
		public extern double MidOrdinateDistance { get; set; }

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x060013F6 RID: 5110
		// (set) Token: 0x060013F7 RID: 5111
		public extern ObjectId MaterialId { get; set; }

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x060013F8 RID: 5112
		public extern ObjectIdCollection Linkages { get; }

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x060013F9 RID: 5113
		// (set) Token: 0x060013FA RID: 5114
		public extern SurfaceMaskType Type { get; set; }

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x060013FB RID: 5115
		// (set) Token: 0x060013FC RID: 5116
		public extern bool IsRenderOnly { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x060013FD RID: 5117
		public sealed extern void Dispose();

		// Token: 0x04001433 RID: 5171
		private int <SyntheticNonEmptyStructMarker>;
	}
}
