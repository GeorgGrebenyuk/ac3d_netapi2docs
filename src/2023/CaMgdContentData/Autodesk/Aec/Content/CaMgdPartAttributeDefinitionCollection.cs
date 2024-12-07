using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Autodesk.Aec.Content
{
	// Token: 0x02000044 RID: 68
	public class CaMgdPartAttributeDefinitionCollection : IDisposable
	{
		// Token: 0x1700002F RID: 47
		public extern CaMgdPartAttributeDefinition this[int A_0]
		{
			get;
		}

		// Token: 0x17000030 RID: 48
		public extern CaMgdPartAttributeDefinition this[string A_0]
		{
			get;
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000DF RID: 223
		public extern int PropertyIndex { get; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000E0 RID: 224
		public extern int Size { get; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000E1 RID: 225
		public unsafe extern CaPartAttributeDefinitionCollection* Value { get; }

		// Token: 0x060000E2 RID: 226
		public unsafe extern CaMgdPartAttributeDefinitionCollection(CaPartAttributeDefinitionCollection* caPartAttributeDefinitionCollection);

		// Token: 0x060000E3 RID: 227
		[HandleProcessCorruptedStateExceptions]
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x060000E4 RID: 228
		public sealed extern void Dispose();

		// Token: 0x060000E5 RID: 229
		protected override extern void Finalize();

		// Token: 0x04000464 RID: 1124
		private int <SyntheticNonEmptyStructMarker>;
	}
}
