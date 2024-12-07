using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.Runtime
{
	// Token: 0x02000BF2 RID: 3058
	[Wrapper("AeccAttribute")]
	internal class CivilAttribute : DisposableWrapper
	{
		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06001719 RID: 5913
		public extern uint AttributeId { get; }

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x0600171A RID: 5914
		public extern string Name { get; }

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x0600171B RID: 5915
		public extern string NameLocalized { get; }

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x0600171C RID: 5916
		public extern string DisplayName { get; }

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x0600171D RID: 5917
		public extern string DisplayNameLocalized { get; }

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x0600171E RID: 5918
		public extern object Value { get; }

		// Token: 0x0600171F RID: 5919
		public extern CivilAttribute(uint attributeId);

		// Token: 0x06001720 RID: 5920
		protected override extern void DeleteUnmanagedObject();
	}
}
