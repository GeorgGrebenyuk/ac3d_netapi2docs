using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Autodesk.Aec.Content
{
	// Token: 0x02000047 RID: 71
	public class CaMgdReferenceDataSet : IDisposable
	{
		// Token: 0x06000101 RID: 257
		public extern CaMgdReferenceDataSet(CaMgdPartAttributeDefinitionCollection columnDef);

		// Token: 0x06000102 RID: 258
		public unsafe extern CaMgdReferenceDataSet(CaReferenceDataSet* referenceDataSet);

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000103 RID: 259
		public unsafe extern CaReferenceDataSet* Value { get; }

		// Token: 0x06000104 RID: 260
		public extern void AddReferenceData(List<CaMgdContentValue> A_0);

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000105 RID: 261
		public extern List<List<CaMgdContentValue>> ReferenceData { get; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000106 RID: 262
		public extern CaMgdPartAttributeDefinitionCollection Definition { get; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000107 RID: 263
		public extern string TableName { get; }

		// Token: 0x06000108 RID: 264
		public extern List<CaMgdContentValue> CreateReferenceData();

		// Token: 0x06000109 RID: 265
		[HandleProcessCorruptedStateExceptions]
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x0600010A RID: 266
		public sealed extern void Dispose();

		// Token: 0x0600010B RID: 267
		protected override extern void Finalize();

		// Token: 0x04000467 RID: 1127
		private int <SyntheticNonEmptyStructMarker>;
	}
}
