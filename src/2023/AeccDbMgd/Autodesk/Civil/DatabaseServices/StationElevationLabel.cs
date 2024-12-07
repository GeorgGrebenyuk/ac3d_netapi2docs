using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000FB RID: 251
	[Wrapper("AeccDbStaElevLabel")]
	public class StationElevationLabel : FeatureLabel
	{
		// Token: 0x06000B70 RID: 2928
		public static extern ObjectId Create(ObjectId profileViewId, ObjectId labelStyleId, ObjectId markerStyleId, double station, double elevation);

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000B71 RID: 2929
		public extern double Station { get; }

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000B72 RID: 2930
		public extern double Elevation { get; }

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000B73 RID: 2931
		// (set) Token: 0x06000B74 RID: 2932
		public extern ObjectId Profile1Id { get; set; }

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000B75 RID: 2933
		// (set) Token: 0x06000B76 RID: 2934
		public extern ObjectId Profile2Id { get; set; }

		// Token: 0x06000B77 RID: 2935
		protected internal extern StationElevationLabel(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
