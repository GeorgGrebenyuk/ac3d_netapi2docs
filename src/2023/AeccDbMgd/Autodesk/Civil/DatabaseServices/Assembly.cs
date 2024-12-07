using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000EF RID: 239
	[Wrapper("AeccDbAssembly")]
	public sealed class Assembly : GeoEntity
	{
		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000ADF RID: 2783
		// (set) Token: 0x06000AE0 RID: 2784
		public extern string CodeSetStyleName { get; set; }

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000AE1 RID: 2785
		// (set) Token: 0x06000AE2 RID: 2786
		public extern ObjectId CodeSetStyleId { get; set; }

		// Token: 0x170004BA RID: 1210
		// (set) Token: 0x06000AE3 RID: 2787
		public override extern string StyleName { set; }

		// Token: 0x170004B9 RID: 1209
		// (set) Token: 0x06000AE4 RID: 2788
		public override extern ObjectId StyleId { set; }

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000AE5 RID: 2789
		// (set) Token: 0x06000AE6 RID: 2790
		public extern AssemblyType Type { get; set; }

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000AE7 RID: 2791
		// (set) Token: 0x06000AE8 RID: 2792
		public extern Point3d Location { get; set; }

		// Token: 0x06000AE9 RID: 2793
		public extern string[] GetOffsetBaselineNames();

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000AEA RID: 2794
		public extern OffsetAssemblyCollection OffsetAssemblies { get; }

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000AEB RID: 2795
		public extern AssemblyGroupCollection Groups { get; }

		// Token: 0x06000AEC RID: 2796
		public extern void AddSubassembly(ObjectId subassemblyId, Point pointHookTo);

		// Token: 0x06000AED RID: 2797
		public extern AssemblyGroup AddSubassembly(ObjectId subassemblyId);

		// Token: 0x06000AEE RID: 2798
		public extern void ReplaceSubassembly(ObjectId subassemblyId, ObjectId targetSubassemblyId);

		// Token: 0x06000AEF RID: 2799
		public extern void InsertSubassemblyBefore(ObjectId subassemblyId, ObjectId targetSubassemblyId);

		// Token: 0x06000AF0 RID: 2800
		public extern void InsertSubassemblyAfter(ObjectId subassemblyId, Point pointHookTo);

		// Token: 0x06000AF1 RID: 2801
		public extern ObjectId CopySubassembly(ObjectId subassemblyIdFrom, Point pointHookTo);

		// Token: 0x06000AF2 RID: 2802
		public extern AssemblyGroup CopySubassembly(ObjectId subassemblyIdFrom);

		// Token: 0x06000AF3 RID: 2803
		public extern ObjectId MirrorSubassembly(ObjectId subassemblyIdFrom, Point pointHookTo);

		// Token: 0x06000AF4 RID: 2804
		public extern AssemblyGroup MirrorSubassembly(ObjectId subassemblyIdFrom);

		// Token: 0x04000318 RID: 792
		private int <SyntheticNonEmptyStructMarker>;
	}
}
