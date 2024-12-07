using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020008DA RID: 2266
	public sealed class PipeOverride : GraphOverride
	{
		// Token: 0x1700071C RID: 1820
		// (set) Token: 0x06001165 RID: 4453
		public override extern bool Draw { [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06001166 RID: 4454
		public extern ObjectId PipeId { get; }

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06001167 RID: 4455
		public extern string PipeName { get; }

		// Token: 0x17000719 RID: 1817
		// (set) Token: 0x06001168 RID: 4456
		public override extern string OverrideStyleName { set; }

		// Token: 0x17000718 RID: 1816
		// (set) Token: 0x06001169 RID: 4457
		public override extern ObjectId OverrideStyleId { set; }
	}
}
