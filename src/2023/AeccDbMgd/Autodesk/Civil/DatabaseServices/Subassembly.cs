using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using Autodesk.Civil.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000EE RID: 238
	[Wrapper("AeccDbSubassembly")]
	public sealed class Subassembly : GeoEntity
	{
		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000AAE RID: 2734
		public override extern string StyleName { get; }

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000AAF RID: 2735
		// (set) Token: 0x06000AB0 RID: 2736
		public extern SubassemblyGenerator GeometryGenerator { get; set; }

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000AB1 RID: 2737
		public extern ParamBoolCollection ParamsBool { get; }

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000AB2 RID: 2738
		public extern ParamLongCollection ParamsLong { get; }

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000AB3 RID: 2739
		public extern ParamDoubleCollection ParamsDouble { get; }

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000AB4 RID: 2740
		public extern ParamStringCollection ParamsString { get; }

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000AB5 RID: 2741
		public extern PointCollection Points { get; }

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000AB6 RID: 2742
		public extern LinkCollection Links { get; }

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000AB7 RID: 2743
		public extern ShapeCollection Shapes { get; }

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000AB8 RID: 2744
		// (set) Token: 0x06000AB9 RID: 2745
		public extern double DefaultLoopOffsetInLayoutMode { get; set; }

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000ABA RID: 2746
		// (set) Token: 0x06000ABB RID: 2747
		public extern bool DefaultLoopInLayoutMode { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000ABC RID: 2748
		public extern bool IsDynamic { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000ABD RID: 2749
		// (set) Token: 0x06000ABE RID: 2750
		public extern string CodeSetStyleName { get; set; }

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000ABF RID: 2751
		// (set) Token: 0x06000AC0 RID: 2752
		public extern bool UseEmbeddedProject { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000AC1 RID: 2753
		// (set) Token: 0x06000AC2 RID: 2754
		public extern string HelpFile { get; set; }

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000AC3 RID: 2755
		// (set) Token: 0x06000AC4 RID: 2756
		public extern string HelpCommand { get; set; }

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000AC5 RID: 2757
		// (set) Token: 0x06000AC6 RID: 2758
		public extern string HelpData { get; set; }

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000AC7 RID: 2759
		// (set) Token: 0x06000AC8 RID: 2760
		public extern string ResourceModule { get; set; }

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000AC9 RID: 2761
		public extern ObjectId AssemblyId { get; }

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000ACA RID: 2762
		public extern bool HasParentAssembly { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000ACB RID: 2763
		public extern ObjectId SubassemblyHookTo { get; }

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000ACC RID: 2764
		// (set) Token: 0x06000ACD RID: 2765
		public extern int PointIndexHookTo { get; set; }

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000ACE RID: 2766
		public extern bool AttachedToOffsetAssembly { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000ACF RID: 2767
		public extern string OffsetAssemblyName { get; }

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000AD0 RID: 2768
		// (set) Token: 0x06000AD1 RID: 2769
		public extern Vector2d OffsetToAssembly { get; set; }

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000AD2 RID: 2770
		[DeprecatedVersion(CivilVersion.Civil2014)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Subassembly.OffsetToParentAssembly instead.", false)]
		public extern Vector2d OffsetToBaseline { get; }

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000AD3 RID: 2771
		// (set) Token: 0x06000AD4 RID: 2772
		public extern Vector2d OffsetToParentAssembly { get; set; }

		// Token: 0x06000AD5 RID: 2773
		public extern void Run();

		// Token: 0x06000AD6 RID: 2774
		public extern void EraseAllParams();

		// Token: 0x06000AD7 RID: 2775
		public extern void ShowHelp();

		// Token: 0x06000AD8 RID: 2776
		public extern string GetResourceString(string resourceId);

		// Token: 0x06000AD9 RID: 2777
		public extern string GetResourceString(uint resourceId);

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000ADA RID: 2778
		public extern bool HasSide { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000ADB RID: 2779
		// (set) Token: 0x06000ADC RID: 2780
		public extern SubassemblySideType Side { get; set; }

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000ADD RID: 2781
		// (set) Token: 0x06000ADE RID: 2782
		public extern Point3d Origin { get; set; }

		// Token: 0x04000317 RID: 791
		private int <SyntheticNonEmptyStructMarker>;
	}
}
