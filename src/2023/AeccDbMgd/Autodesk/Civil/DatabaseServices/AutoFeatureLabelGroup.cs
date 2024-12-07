using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000071 RID: 113
	[Wrapper("AeccDbAutoFeatureLabeling")]
	public class AutoFeatureLabelGroup : LabelGroup
	{
		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060004CA RID: 1226
		// (set) Token: 0x060004CB RID: 1227
		public virtual extern double RangeEnd { get; set; }

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060004CC RID: 1228
		// (set) Token: 0x060004CD RID: 1229
		public virtual extern bool RangeEndFromFeature { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060004CE RID: 1230
		// (set) Token: 0x060004CF RID: 1231
		public virtual extern double RangeStart { get; set; }

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060004D0 RID: 1232
		// (set) Token: 0x060004D1 RID: 1233
		public virtual extern bool RangeStartFromFeature { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x060004D2 RID: 1234
		public virtual extern void SetRange(double rangeStart, double rangeEnd);

		// Token: 0x060004D3 RID: 1235
		protected virtual extern double GetFeatureStartStation();

		// Token: 0x060004D4 RID: 1236
		protected virtual extern double GetFeatureEndStation();

		// Token: 0x060004D5 RID: 1237
		protected internal extern AutoFeatureLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
