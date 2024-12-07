using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Autodesk.Aec.Content
{
	// Token: 0x0200010C RID: 268
	public class CaMgdPartDefinition : IDisposable
	{
		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000133 RID: 307
		public extern string Industry { get; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000134 RID: 308
		public extern string Domain { get; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000135 RID: 309
		public extern string PartType { get; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000136 RID: 310
		public extern CaMgdPartAttributeDefinitionCollection EngineeringDefinition { get; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000137 RID: 311
		public extern CaMgdPartAttributeDefinitionCollection ConnectionPointDefinition { get; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000138 RID: 312
		public extern List<string> EngineeringAttributes { get; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000139 RID: 313
		public extern List<string> ConnectionPointAttributes { get; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600013A RID: 314
		public extern List<string> PrimaryKeys { get; }

		// Token: 0x0600013B RID: 315
		public extern CaMgdPartAttributeDefinition GetPropertyDefinition(string propertyName);

		// Token: 0x0600013C RID: 316
		public extern int GetEngineeringPropertyIndex(string propertyName);

		// Token: 0x0600013D RID: 317
		public extern int GetConnectionPointPropertyIndex(string propertyName);

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600013E RID: 318
		public extern int ConnectionPointPropertyCount { get; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600013F RID: 319
		public extern int EngineeringPropertyCount { get; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000140 RID: 320
		public unsafe extern CaPartDefinition* Value { get; }

		// Token: 0x06000141 RID: 321
		public unsafe extern CaMgdPartDefinition(CaPartDefinition* caPartDefinition);

		// Token: 0x06000142 RID: 322
		[HandleProcessCorruptedStateExceptions]
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x06000143 RID: 323
		public sealed extern void Dispose();

		// Token: 0x06000144 RID: 324
		protected override extern void Finalize();

		// Token: 0x040004FA RID: 1274
		private int <SyntheticNonEmptyStructMarker>;
	}
}
