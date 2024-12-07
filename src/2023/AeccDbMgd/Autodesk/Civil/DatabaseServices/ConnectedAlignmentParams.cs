using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200004F RID: 79
	public class ConnectedAlignmentParams
	{
		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002B4 RID: 692
		// (set) Token: 0x060002B5 RID: 693
		public extern ObjectId IncomingParentAlignmentId { get; set; }

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002B6 RID: 694
		// (set) Token: 0x060002B7 RID: 695
		public extern double IncomingParentAlignmentStation { get; set; }

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002B8 RID: 696
		// (set) Token: 0x060002B9 RID: 697
		public extern double OffsetIn { get; set; }

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002BA RID: 698
		// (set) Token: 0x060002BB RID: 699
		public extern double ConnectionOverlapLengthIn { get; set; }

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002BC RID: 700
		// (set) Token: 0x060002BD RID: 701
		public extern ObjectId OutgoingParentAlignmentId { get; set; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002BE RID: 702
		// (set) Token: 0x060002BF RID: 703
		public extern double OutgoingParentAlignmentStation { get; set; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002C0 RID: 704
		// (set) Token: 0x060002C1 RID: 705
		public extern double OffsetOut { get; set; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002C2 RID: 706
		// (set) Token: 0x060002C3 RID: 707
		public extern double ConnectionOverlapLengthOut { get; set; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002C4 RID: 708
		// (set) Token: 0x060002C5 RID: 709
		public extern CurbReturnCurveGroupType CurveGroupType { get; set; }

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002C6 RID: 710
		// (set) Token: 0x060002C7 RID: 711
		public extern bool GreaterThan180 { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002C8 RID: 712
		// (set) Token: 0x060002C9 RID: 713
		public extern double CurveRadius { get; set; }

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002CA RID: 714
		// (set) Token: 0x060002CB RID: 715
		public extern SpiralType SpiralDefinition { get; set; }

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002CC RID: 716
		// (set) Token: 0x060002CD RID: 717
		public extern double SpiralInLength { get; set; }

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002CE RID: 718
		// (set) Token: 0x060002CF RID: 719
		public extern double ReverseSpiralInLength { get; set; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002D0 RID: 720
		// (set) Token: 0x060002D1 RID: 721
		public extern double SpiralOutLength { get; set; }

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002D2 RID: 722
		// (set) Token: 0x060002D3 RID: 723
		public extern double ReverseSpiralOutLength { get; set; }

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002D4 RID: 724
		// (set) Token: 0x060002D5 RID: 725
		public extern double ArcInRadius { get; set; }

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002D6 RID: 726
		// (set) Token: 0x060002D7 RID: 727
		public extern double ArcInLength { get; set; }

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002D8 RID: 728
		// (set) Token: 0x060002D9 RID: 729
		public extern double ArcMiddleRadius { get; set; }

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002DA RID: 730
		// (set) Token: 0x060002DB RID: 731
		public extern double ArcOutRadius { get; set; }

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002DC RID: 732
		// (set) Token: 0x060002DD RID: 733
		public extern double ArcOutLength { get; set; }

		// Token: 0x060002DE RID: 734
		public extern ConnectedAlignmentParams();

		// Token: 0x040002F2 RID: 754
		private int <SyntheticNonEmptyStructMarker>;
	}
}
