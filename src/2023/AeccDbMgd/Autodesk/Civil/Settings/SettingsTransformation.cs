using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.Settings
{
	// Token: 0x020010CD RID: 4301
	public sealed class SettingsTransformation : TreeOidWrapper
	{
		// Token: 0x170011A3 RID: 4515
		// (get) Token: 0x06002299 RID: 8857
		// (set) Token: 0x0600229A RID: 8858
		public extern bool ApplySeaLevelScaleFactor { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170011A2 RID: 4514
		// (get) Token: 0x0600229B RID: 8859
		// (set) Token: 0x0600229C RID: 8860
		public extern double SeaLevelScaleElevation { get; set; }

		// Token: 0x170011A1 RID: 4513
		// (get) Token: 0x0600229D RID: 8861
		public extern double SpheroidRadius { get; }

		// Token: 0x170011A0 RID: 4512
		// (get) Token: 0x0600229E RID: 8862
		// (set) Token: 0x0600229F RID: 8863
		public extern GridScaleFactorType GridScaleFactorComputation { get; set; }

		// Token: 0x1700119F RID: 4511
		// (get) Token: 0x060022A0 RID: 8864
		// (set) Token: 0x060022A1 RID: 8865
		public extern double GridScaleFactor { get; set; }

		// Token: 0x1700119E RID: 4510
		// (get) Token: 0x060022A2 RID: 8866
		// (set) Token: 0x060022A3 RID: 8867
		public extern SpecifyRotationType SpecifyRotationType { get; set; }

		// Token: 0x1700119D RID: 4509
		// (get) Token: 0x060022A4 RID: 8868
		// (set) Token: 0x060022A5 RID: 8869
		public extern double RotationToGridNorth { get; set; }

		// Token: 0x1700119C RID: 4508
		// (get) Token: 0x060022A6 RID: 8870
		// (set) Token: 0x060022A7 RID: 8871
		public extern double RotationToGridAzimuth { get; set; }

		// Token: 0x1700119B RID: 4507
		// (get) Token: 0x060022A8 RID: 8872
		// (set) Token: 0x060022A9 RID: 8873
		public extern Point2d LocalReferencePoint { get; set; }

		// Token: 0x1700119A RID: 4506
		// (get) Token: 0x060022AA RID: 8874
		// (set) Token: 0x060022AB RID: 8875
		public extern Point2d GridReferencePoint { get; set; }

		// Token: 0x17001199 RID: 4505
		// (get) Token: 0x060022AC RID: 8876
		// (set) Token: 0x060022AD RID: 8877
		public extern Point2d LocalRotationPoint { get; set; }

		// Token: 0x17001198 RID: 4504
		// (get) Token: 0x060022AE RID: 8878
		// (set) Token: 0x060022AF RID: 8879
		public extern Point2d GridRotationPoint { get; set; }
	}
}
