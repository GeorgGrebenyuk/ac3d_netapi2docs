using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000008 RID: 8
	[Wrapper("AeccDbFitting")]
	public sealed class PressureFitting : PressurePart
	{
		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060000C6 RID: 198
		// (set) Token: 0x060000C7 RID: 199
		public extern Point3d Location { get; set; }

		// Token: 0x17000083 RID: 131
		// (set) Token: 0x060000C8 RID: 200
		public override extern ObjectId StyleId { set; }

		// Token: 0x17000082 RID: 130
		// (set) Token: 0x060000C9 RID: 201
		public override extern string StyleName { set; }

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060000CA RID: 202
		public extern double InsertionPointStation { get; }

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060000CB RID: 203
		public extern double InsertionPointOffset { get; }

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060000CC RID: 204
		public extern double ResultantHorizontalAngle { get; }

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060000CD RID: 205
		public extern double ResultantVerticalAngle { get; }

		// Token: 0x060000CE RID: 206
		public extern void ConnectToPipe(int portIndex, ObjectId pipeId, int pipePortIndex);
	}
}
