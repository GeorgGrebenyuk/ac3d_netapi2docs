using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200004E RID: 78
	public struct PolylineOptions : IEquatable<PolylineOptions>
	{
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002A9 RID: 681
		// (set) Token: 0x060002AA RID: 682
		public extern ObjectId PlineId { get; set; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002AB RID: 683
		// (set) Token: 0x060002AC RID: 684
		public extern bool AddCurvesBetweenTangents { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002AD RID: 685
		// (set) Token: 0x060002AE RID: 686
		public extern bool EraseExistingEntities { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x060002AF RID: 687
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Equals(PolylineOptions other);

		// Token: 0x060002B0 RID: 688
		[return: MarshalAs(UnmanagedType.U1)]
		public sealed override extern bool Equals(object obj);

		// Token: 0x060002B1 RID: 689
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool operator ==(PolylineOptions option1, PolylineOptions option2);

		// Token: 0x060002B2 RID: 690
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool operator !=(PolylineOptions option1, PolylineOptions option2);

		// Token: 0x060002B3 RID: 691
		public sealed override extern int GetHashCode();

		// Token: 0x040002EF RID: 751
		private ObjectId <backing_store>PlineId;

		// Token: 0x040002F0 RID: 752
		private bool <backing_store>AddCurvesBetweenTangents;

		// Token: 0x040002F1 RID: 753
		private bool <backing_store>EraseExistingEntities;
	}
}
