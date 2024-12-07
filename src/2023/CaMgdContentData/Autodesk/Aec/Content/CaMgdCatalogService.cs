using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Autodesk.Aec.Content
{
	// Token: 0x0200003D RID: 61
	public class CaMgdCatalogService : IDisposable
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000051 RID: 81
		public static extern CaMgdCatalogService Instance { get; }

		// Token: 0x06000052 RID: 82
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool SetCatalogLocation(string folderName);

		// Token: 0x06000053 RID: 83
		public extern string GetCatalogLocation();

		// Token: 0x06000054 RID: 84
		public extern List<string> GetAvailableCatalogFiles();

		// Token: 0x06000055 RID: 85
		public extern CaMgdCatalog LoadCatalog(string fileName, [MarshalAs(UnmanagedType.U1)] bool bReadonly);

		// Token: 0x06000056 RID: 86
		public extern CaMgdCatalog CloneCatalog(string destFile, CaMgdCatalog pCatalog);

		// Token: 0x06000057 RID: 87
		public extern void ReleaseCatalog(CaMgdCatalog pCatalog);

		// Token: 0x06000058 RID: 88
		[HandleProcessCorruptedStateExceptions]
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x06000059 RID: 89
		public sealed extern void Dispose();

		// Token: 0x0600005A RID: 90
		protected override extern void Finalize();

		// Token: 0x0400045E RID: 1118
		private int <SyntheticNonEmptyStructMarker>;
	}
}
