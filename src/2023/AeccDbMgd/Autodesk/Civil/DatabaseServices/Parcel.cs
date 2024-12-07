using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020006E5 RID: 1765
	[Wrapper("AeccDbFace")]
	public sealed class Parcel : Entity
	{
		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06000DEA RID: 3562
		// (set) Token: 0x06000DEB RID: 3563
		public extern int Number { get; set; }

		// Token: 0x06000DEC RID: 3564
		public extern ObjectIdCollection GetAvailableParcelAreaLabelIds();

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06000DED RID: 3565
		// (set) Token: 0x06000DEE RID: 3566
		public extern ObjectId AreaSelectionLabelStyleId { get; set; }

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06000DEF RID: 3567
		// (set) Token: 0x06000DF0 RID: 3568
		public extern Point3d AreaSelectionLabelLocation { get; set; }

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06000DF1 RID: 3569
		// (set) Token: 0x06000DF2 RID: 3570
		public extern Point3d AreaLocation { get; set; }

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06000DF3 RID: 3571
		public extern Point3d Centroid { get; }

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06000DF4 RID: 3572
		// (set) Token: 0x06000DF5 RID: 3573
		public extern bool IsAreaSelectionLabelPinned { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06000DF6 RID: 3574
		// (set) Token: 0x06000DF7 RID: 3575
		public extern int TaxId { get; set; }

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06000DF8 RID: 3576
		// (set) Token: 0x06000DF9 RID: 3577
		public extern string Address { get; set; }

		// Token: 0x06000DFA RID: 3578
		public extern void ResetAreaSelectionLabel();

		// Token: 0x06000DFB RID: 3579
		public extern void SetUDPValue(UDPEnumeration udp, string value);

		// Token: 0x06000DFC RID: 3580
		public extern void SetUDPValue(UDPBoolean udp, [MarshalAs(UnmanagedType.U1)] bool value);

		// Token: 0x06000DFD RID: 3581
		public extern void SetUDPValue(UDPInteger udp, int value);

		// Token: 0x06000DFE RID: 3582
		public extern void SetUDPValue(UDPString udp, string value);

		// Token: 0x06000DFF RID: 3583
		public extern void SetUDPValue(UDPDouble udp, double value);

		// Token: 0x06000E00 RID: 3584
		public extern string GetUDPValue(UDPEnumeration udp);

		// Token: 0x06000E01 RID: 3585
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool GetUDPValue(UDPBoolean udp);

		// Token: 0x06000E02 RID: 3586
		public extern int GetUDPValue(UDPInteger udp);

		// Token: 0x06000E03 RID: 3587
		public extern string GetUDPValue(UDPString udp);

		// Token: 0x06000E04 RID: 3588
		public extern double GetUDPValue(UDPDouble udp);
	}
}
