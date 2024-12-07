using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000B6E RID: 2926
	internal abstract class AssemblyEditor
	{
		// Token: 0x060015AF RID: 5551
		public extern void AddSubassembly(ObjectId subassemblyId, Point pointHookTo);

		// Token: 0x060015B0 RID: 5552
		public extern AssemblyGroup AddSubassembly(ObjectId subassemblyId);

		// Token: 0x060015B1 RID: 5553
		public extern void ReplaceSubassembly(ObjectId subassemblyId, ObjectId targetSubassemblyId);

		// Token: 0x060015B2 RID: 5554
		public extern void InsertSubassemblyBefore(ObjectId subassemblyId, ObjectId targetSubassemblyId);

		// Token: 0x060015B3 RID: 5555
		public extern void InsertSubassemblyAfter(ObjectId subassemblyId, Point pointHookTo);

		// Token: 0x060015B4 RID: 5556
		public extern ObjectId CopySubassembly(ObjectId subassemblyIdFrom, Point pointHookTo);

		// Token: 0x060015B5 RID: 5557
		public extern AssemblyGroup CopySubassembly(ObjectId subassemblyIdFrom);

		// Token: 0x060015B6 RID: 5558
		public extern ObjectId MirrorSubassembly(ObjectId subassemblyIdFrom, Point pointHookTo);

		// Token: 0x060015B7 RID: 5559
		public extern AssemblyGroup MirrorSubassembly(ObjectId subassemblyIdFrom);

		// Token: 0x060015B8 RID: 5560
		protected unsafe extern void checkSubassemblyToBeAdded(AcDbObjectId* oidSubassembly);

		// Token: 0x060015B9 RID: 5561
		protected unsafe extern void checkSubassemblyInAssembly(AcDbObjectId* oidSubassembly);

		// Token: 0x060015BA RID: 5562
		protected extern void checkPointToBeHookedTo(Point pointHookTo);

		// Token: 0x060015BB RID: 5563
		protected unsafe extern AecRmCString* getDefaultGroupName(AecRmCString*);

		// Token: 0x060015BC RID: 5564
		protected unsafe abstract AecRmCString* addSubassembly(AecRmCString*, AcDbObjectId* oidSubassembly);

		// Token: 0x060015BD RID: 5565
		protected unsafe abstract AssemblyGroup createAssemblyGroup(AecRmCString* groupName);

		// Token: 0x060015BE RID: 5566
		[return: MarshalAs(UnmanagedType.U1)]
		protected unsafe abstract bool isSubassemblyAttachedToCorrectAssembly(AcDbObjectId* oidSubassembly);

		// Token: 0x040014FE RID: 5374
		private int <SyntheticNonEmptyStructMarker>;
	}
}
