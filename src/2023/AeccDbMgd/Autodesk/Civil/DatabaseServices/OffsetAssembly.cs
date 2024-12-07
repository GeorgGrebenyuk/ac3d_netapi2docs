using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000B71 RID: 2929
	public sealed class OffsetAssembly : IDisposable
	{
		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x060015C0 RID: 5568
		// (set) Token: 0x060015C1 RID: 5569
		public extern string Name { get; set; }

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x060015C2 RID: 5570
		// (set) Token: 0x060015C3 RID: 5571
		public extern Vector2d Offset { get; set; }

		// Token: 0x060015C4 RID: 5572
		public extern void AddSubassembly(ObjectId subassemblyId, Point pointHookTo);

		// Token: 0x060015C5 RID: 5573
		public extern AssemblyGroup AddSubassembly(ObjectId subassemblyId);

		// Token: 0x060015C6 RID: 5574
		public extern void ReplaceSubassembly(ObjectId subassemblyId, ObjectId targetSubassemblyId);

		// Token: 0x060015C7 RID: 5575
		public extern void InsertSubassemblyBefore(ObjectId subassemblyId, ObjectId targetSubassemblyId);

		// Token: 0x060015C8 RID: 5576
		public extern void InsertSubassemblyAfter(ObjectId subassemblyId, Point pointHookTo);

		// Token: 0x060015C9 RID: 5577
		public extern ObjectId CopySubassembly(ObjectId subassemblyIdFrom, Point pointHookTo);

		// Token: 0x060015CA RID: 5578
		public extern AssemblyGroup CopySubassembly(ObjectId subassemblyIdFrom);

		// Token: 0x060015CB RID: 5579
		public extern ObjectId MirrorSubassembly(ObjectId subassemblyIdFrom, Point pointHookTo);

		// Token: 0x060015CC RID: 5580
		public extern AssemblyGroup MirrorSubassembly(ObjectId subassemblyIdFrom);

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x060015CD RID: 5581
		public extern AssemblyGroupCollection Groups { get; }

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x060015CE RID: 5582
		public extern ObjectId AssemblyId { get; }

		// Token: 0x060015CF RID: 5583
		public sealed extern void Dispose();

		// Token: 0x04001500 RID: 5376
		private int <SyntheticNonEmptyStructMarker>;
	}
}
