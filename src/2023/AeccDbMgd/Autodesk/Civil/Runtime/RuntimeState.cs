using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.Runtime
{
	// Token: 0x02001234 RID: 4660
	[Wrapper("AeccDbRuntimeState")]
	public class RuntimeState : CivilWrapper<AeccDbRuntimeState>
	{
		// Token: 0x1700147B RID: 5243
		// (get) Token: 0x0600281F RID: 10271
		public extern string CurrentMacroProject { get; }

		// Token: 0x1700147A RID: 5242
		// (get) Token: 0x06002820 RID: 10272
		public extern string CurrentMacroName { get; }
	}
}
