using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000ED RID: 237
	public class SubassemblyGenerator
	{
		// Token: 0x06000AA7 RID: 2727
		public extern SubassemblyGenerator(SubassemblyGeometryGenerateMode mode, string projectOrAssemblyName, string macroOrClassName);

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000AA8 RID: 2728
		// (set) Token: 0x06000AA9 RID: 2729
		public extern SubassemblyGeometryGenerateMode GeometryGenerateMode { get; set; }

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000AAA RID: 2730
		// (set) Token: 0x06000AAB RID: 2731
		public extern string ProjectOrAssemblyName { get; set; }

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000AAC RID: 2732
		// (set) Token: 0x06000AAD RID: 2733
		public extern string MacroOrClassName { get; set; }

		// Token: 0x04000316 RID: 790
		private int <SyntheticNonEmptyStructMarker>;
	}
}
