using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000FA RID: 250
	[Wrapper("AeccDbStaOffsetLabel")]
	public class StationOffsetLabel : FeatureLabel
	{
		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000B6A RID: 2922
		// (set) Token: 0x06000B6B RID: 2923
		public extern bool AnchorAtXY { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000B6C RID: 2924
		// (set) Token: 0x06000B6D RID: 2925
		public extern Point2d Location { get; set; }

		// Token: 0x06000B6E RID: 2926
		public static extern ObjectId Create(ObjectId alignmentId, ObjectId labelStyleId, ObjectId markerStyleId, Point2d location);

		// Token: 0x06000B6F RID: 2927
		protected internal extern StationOffsetLabel(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
