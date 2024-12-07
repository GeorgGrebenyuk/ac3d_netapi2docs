using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001165 RID: 4453
	public sealed class FeatureLineCodeInfo : CivilWrapper<AeccDbCorridor>
	{
		// Token: 0x17001334 RID: 4916
		// (get) Token: 0x060024D9 RID: 9433
		public extern ObjectId CorridorId { get; }

		// Token: 0x17001333 RID: 4915
		// (get) Token: 0x060024DA RID: 9434
		public extern string CodeName { get; }

		// Token: 0x17001332 RID: 4914
		// (get) Token: 0x060024DB RID: 9435
		[DeprecatedVersion(CivilVersion.Civil2014)]
		[Obsolete("Functionality has been removed.", false)]
		public extern bool IsDraw { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17001331 RID: 4913
		// (get) Token: 0x060024DC RID: 9436
		// (set) Token: 0x060024DD RID: 9437
		[Obsolete("Use Autodesk.Civil.DatabaseServices.FeatureLineCodeInfo.IsConnected instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2014)]
		public extern bool IsConnect { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17001330 RID: 4912
		// (get) Token: 0x060024DE RID: 9438
		// (set) Token: 0x060024DF RID: 9439
		public extern bool IsConnected { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700132F RID: 4911
		// (get) Token: 0x060024E0 RID: 9440
		// (set) Token: 0x060024E1 RID: 9441
		public extern string[] PayItems { get; set; }

		// Token: 0x04001AB4 RID: 6836
		private int <SyntheticNonEmptyStructMarker>;
	}
}
