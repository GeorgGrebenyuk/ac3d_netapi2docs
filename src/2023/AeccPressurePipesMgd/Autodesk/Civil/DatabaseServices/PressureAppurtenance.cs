using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000009 RID: 9
	[Wrapper("AeccDbAppurtenance")]
	public class PressureAppurtenance : PressurePart
	{
		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060000CF RID: 207
		// (set) Token: 0x060000D0 RID: 208
		public extern Point3d Location { get; set; }

		// Token: 0x17000088 RID: 136
		// (set) Token: 0x060000D1 RID: 209
		public override extern ObjectId StyleId { set; }

		// Token: 0x17000087 RID: 135
		// (set) Token: 0x060000D2 RID: 210
		public override extern string StyleName { set; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060000D3 RID: 211
		public extern double InsertionPointStation { get; }

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060000D4 RID: 212
		public extern double InsertionPointOffset { get; }

		// Token: 0x060000D5 RID: 213
		public extern void ConnectToPipe(int portIndex, ObjectId pipeId, int pipePortIndex);

		// Token: 0x060000D6 RID: 214
		protected internal extern PressureAppurtenance(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
