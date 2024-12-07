using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020008E5 RID: 2277
	public sealed class StructureOverride : GraphOverride
	{
		// Token: 0x17000724 RID: 1828
		// (set) Token: 0x06001172 RID: 4466
		public override extern bool Draw { [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06001173 RID: 4467
		public extern ObjectId StructId { get; }

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06001174 RID: 4468
		public extern string StructName { get; }

		// Token: 0x17000721 RID: 1825
		// (set) Token: 0x06001175 RID: 4469
		public override extern string OverrideStyleName { set; }

		// Token: 0x17000720 RID: 1824
		// (set) Token: 0x06001176 RID: 4470
		public override extern ObjectId OverrideStyleId { set; }
	}
}
