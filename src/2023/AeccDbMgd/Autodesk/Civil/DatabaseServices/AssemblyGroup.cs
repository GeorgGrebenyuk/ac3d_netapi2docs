using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using std;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000B72 RID: 2930
	public abstract class AssemblyGroup
	{
		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x060015D0 RID: 5584
		// (set) Token: 0x060015D1 RID: 5585
		public extern string Name { get; set; }

		// Token: 0x060015D2 RID: 5586
		public extern ObjectIdCollection GetSubassemblyIds();

		// Token: 0x060015D3 RID: 5587
		protected unsafe extern AeccDbAssembly* GetImpObj();

		// Token: 0x060015D4 RID: 5588
		protected unsafe abstract AecRmCString* getAssemblyGroupName(AecRmCString*);

		// Token: 0x060015D5 RID: 5589
		[return: MarshalAs(UnmanagedType.U1)]
		protected unsafe abstract bool generateGroupName(AecRmCString* strOldGroupName, AecRmCString* strNewGroupName);

		// Token: 0x060015D6 RID: 5590
		[return: MarshalAs(UnmanagedType.U1)]
		protected unsafe abstract bool renameGroup(AecRmCString* strNewGroupName);

		// Token: 0x060015D7 RID: 5591
		protected unsafe abstract void getSubassemblyIds(vector<AcDbObjectId,std::allocator<AcDbObjectId>\u0020>* subassemblies);

		// Token: 0x04001501 RID: 5377
		private int <SyntheticNonEmptyStructMarker>;
	}
}
