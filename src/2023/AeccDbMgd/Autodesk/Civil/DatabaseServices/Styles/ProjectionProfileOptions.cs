using System;
using System.Runtime.InteropServices;
using Autodesk.Aec.DatabaseServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F69 RID: 3945
	public class ProjectionProfileOptions : CivilWrapper<AeccDbProfileSectionEntityStyle>
	{
		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x06001DD7 RID: 7639
		// (set) Token: 0x06001DD8 RID: 7640
		public extern ProjectionEntityDisplayType AutoCADPointDisplayOptions { get; set; }

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x06001DD9 RID: 7641
		// (set) Token: 0x06001DDA RID: 7642
		public extern ObjectId AutoCADPointMarkerStyleId { get; set; }

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x06001DDB RID: 7643
		// (set) Token: 0x06001DDC RID: 7644
		public extern string AutoCADPointMarkerStyleName { get; set; }

		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x06001DDD RID: 7645
		// (set) Token: 0x06001DDE RID: 7646
		public extern ProjectionEntityDisplayType AutoCADSolidDisplayOptions { get; set; }

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x06001DDF RID: 7647
		// (set) Token: 0x06001DE0 RID: 7648
		public extern ObjectId AutoCADSolidMarkerStyleId { get; set; }

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x06001DE1 RID: 7649
		// (set) Token: 0x06001DE2 RID: 7650
		public extern string AutoCADSolidMarkerStyleName { get; set; }

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x06001DE3 RID: 7651
		// (set) Token: 0x06001DE4 RID: 7652
		public extern bool VerticallyExaggerateSolids { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x06001DE5 RID: 7653
		// (set) Token: 0x06001DE6 RID: 7654
		public extern ObjectId AutoCAD3dPolylineBeginVertexMarkerStyleId { get; set; }

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x06001DE7 RID: 7655
		// (set) Token: 0x06001DE8 RID: 7656
		public extern string AutoCAD3dPolylineBeginVertexMarkerStyleName { get; set; }

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x06001DE9 RID: 7657
		// (set) Token: 0x06001DEA RID: 7658
		public extern ObjectId AutoCAD3dPolylineInternalVertexMarkerStyleId { get; set; }

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x06001DEB RID: 7659
		// (set) Token: 0x06001DEC RID: 7660
		public extern string AutoCAD3dPolylineInternalVertexMarkerStyleName { get; set; }

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x06001DED RID: 7661
		// (set) Token: 0x06001DEE RID: 7662
		public extern ObjectId AutoCAD3dPolylineEndVertexMarkerStyleId { get; set; }

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x06001DEF RID: 7663
		// (set) Token: 0x06001DF0 RID: 7664
		public extern string AutoCAD3dPolylineEndVertexMarkerStyleName { get; set; }

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x06001DF1 RID: 7665
		// (set) Token: 0x06001DF2 RID: 7666
		public extern ProjectionBlockDisplayType AutoCADBlockDisplayOptions { get; set; }

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x06001DF3 RID: 7667
		// (set) Token: 0x06001DF4 RID: 7668
		public extern ObjectId AutoCADBlockMarkerStyleId { get; set; }

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x06001DF5 RID: 7669
		// (set) Token: 0x06001DF6 RID: 7670
		public extern string AutoCADBlockMarkerStyleName { get; set; }

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x06001DF7 RID: 7671
		// (set) Token: 0x06001DF8 RID: 7672
		public extern ObjectId AutoCADBlockSymbolBlockId { get; set; }

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x06001DF9 RID: 7673
		// (set) Token: 0x06001DFA RID: 7674
		public extern string AutoCADBlockSymbolBlockName { get; set; }

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x06001DFB RID: 7675
		// (set) Token: 0x06001DFC RID: 7676
		public extern bool VerticallyExaggerateBlocks { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x06001DFD RID: 7677
		// (set) Token: 0x06001DFE RID: 7678
		public extern ProjectionBlockDisplayType MultiViewBlockDisplayOptions { get; set; }

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x06001DFF RID: 7679
		// (set) Token: 0x06001E00 RID: 7680
		public extern ObjectId MultiViewBlockMarkerStyleId { get; set; }

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x06001E01 RID: 7681
		// (set) Token: 0x06001E02 RID: 7682
		public extern string MultiViewBlockMarkerStyleName { get; set; }

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x06001E03 RID: 7683
		// (set) Token: 0x06001E04 RID: 7684
		public extern ObjectId MultiViewBlockDisplayRepresentationId { get; set; }

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x06001E05 RID: 7685
		// (set) Token: 0x06001E06 RID: 7686
		public extern string MultiViewBlockDisplayRepresentationName { get; set; }

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x06001E07 RID: 7687
		// (set) Token: 0x06001E08 RID: 7688
		public extern ViewDirection MultiViewBlockDirection { get; set; }

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x06001E09 RID: 7689
		// (set) Token: 0x06001E0A RID: 7690
		public extern ObjectId MultiViewBlockSymbolBlockId { get; set; }

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x06001E0B RID: 7691
		// (set) Token: 0x06001E0C RID: 7692
		public extern string MultiViewBlockSymbolBlockName { get; set; }

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x06001E0D RID: 7693
		// (set) Token: 0x06001E0E RID: 7694
		public extern bool VerticallyExaggerateMultiViewBlocks { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x04001847 RID: 6215
		private int <SyntheticNonEmptyStructMarker>;
	}
}
