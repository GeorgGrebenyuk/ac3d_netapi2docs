using System;
using System.Runtime.InteropServices;
using Autodesk.Aec.DatabaseServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F6A RID: 3946
	public class ProjectionSectionOptions : CivilWrapper<AeccDbProfileSectionEntityStyle>
	{
		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x06001E0F RID: 7695
		// (set) Token: 0x06001E10 RID: 7696
		public extern ProjectionEntityDisplayType AutoCADPointDisplayOptions { get; set; }

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x06001E11 RID: 7697
		// (set) Token: 0x06001E12 RID: 7698
		public extern ObjectId AutoCADPointMarkerStyleId { get; set; }

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x06001E13 RID: 7699
		// (set) Token: 0x06001E14 RID: 7700
		public extern string AutoCADPointMarkerStyleName { get; set; }

		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x06001E15 RID: 7701
		// (set) Token: 0x06001E16 RID: 7702
		public extern ProjectionEntityDisplayType AutoCADSolidDisplayOptions { get; set; }

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x06001E17 RID: 7703
		// (set) Token: 0x06001E18 RID: 7704
		public extern bool AutoCADSolidDisplayAsTrueSection { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x06001E19 RID: 7705
		// (set) Token: 0x06001E1A RID: 7706
		public extern ObjectId AutoCADSolidMarkerStyleId { get; set; }

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x06001E1B RID: 7707
		// (set) Token: 0x06001E1C RID: 7708
		public extern string AutoCADSolidMarkerStyleName { get; set; }

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x06001E1D RID: 7709
		// (set) Token: 0x06001E1E RID: 7710
		public extern bool VerticallyExaggerateSolids { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x06001E1F RID: 7711
		// (set) Token: 0x06001E20 RID: 7712
		public extern ObjectId AutoCAD3dPolylineCrossingMarkerStyleId { get; set; }

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x06001E21 RID: 7713
		// (set) Token: 0x06001E22 RID: 7714
		public extern string AutoCAD3dPolylineCrossingMarkerStyleName { get; set; }

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x06001E23 RID: 7715
		// (set) Token: 0x06001E24 RID: 7716
		public extern ProjectionBlockDisplayType AutoCADBlockDisplayOptions { get; set; }

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x06001E25 RID: 7717
		// (set) Token: 0x06001E26 RID: 7718
		public extern ObjectId AutoCADBlockMarkerStyleId { get; set; }

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x06001E27 RID: 7719
		// (set) Token: 0x06001E28 RID: 7720
		public extern string AutoCADBlockMarkerStyleName { get; set; }

		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x06001E29 RID: 7721
		// (set) Token: 0x06001E2A RID: 7722
		public extern ObjectId AutoCADBlockSymbolBlockId { get; set; }

		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x06001E2B RID: 7723
		// (set) Token: 0x06001E2C RID: 7724
		public extern string AutoCADBlockSymbolBlockName { get; set; }

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x06001E2D RID: 7725
		// (set) Token: 0x06001E2E RID: 7726
		public extern bool VerticallyExaggerateBlocks { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x06001E2F RID: 7727
		// (set) Token: 0x06001E30 RID: 7728
		public extern ProjectionBlockDisplayType MultiViewBlockDisplayOptions { get; set; }

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x06001E31 RID: 7729
		// (set) Token: 0x06001E32 RID: 7730
		public extern ObjectId MultiViewBlockMarkerStyleId { get; set; }

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x06001E33 RID: 7731
		// (set) Token: 0x06001E34 RID: 7732
		public extern string MultiViewBlockMarkerStyleName { get; set; }

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x06001E35 RID: 7733
		// (set) Token: 0x06001E36 RID: 7734
		public extern ObjectId MultiViewBlockDisplayRepresentationId { get; set; }

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x06001E37 RID: 7735
		// (set) Token: 0x06001E38 RID: 7736
		public extern string MultiViewBlockDisplayRepresentationName { get; set; }

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x06001E39 RID: 7737
		// (set) Token: 0x06001E3A RID: 7738
		public extern ViewDirection MultiViewBlockDirection { get; set; }

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x06001E3B RID: 7739
		// (set) Token: 0x06001E3C RID: 7740
		public extern ObjectId MultiViewBlockSymbolBlockId { get; set; }

		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x06001E3D RID: 7741
		// (set) Token: 0x06001E3E RID: 7742
		public extern string MultiViewBlockSymbolBlockName { get; set; }

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x06001E3F RID: 7743
		// (set) Token: 0x06001E40 RID: 7744
		public extern bool VerticallyExaggerateMultiViewBlocks { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x04001848 RID: 6216
		private int <SyntheticNonEmptyStructMarker>;
	}
}
