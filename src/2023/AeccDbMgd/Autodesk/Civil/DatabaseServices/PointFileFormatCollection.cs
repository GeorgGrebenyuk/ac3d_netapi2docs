using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020008C4 RID: 2244
	public class PointFileFormatCollection : IEnumerable<PointFileFormat>, IDisposable
	{
		// Token: 0x17000710 RID: 1808
		public extern PointFileFormat this[string name]
		{
			get;
		}

		// Token: 0x17000711 RID: 1809
		public extern PointFileFormat this[int index]
		{
			get;
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x0600114D RID: 4429
		public extern int Count { get; }

		// Token: 0x0600114E RID: 4430
		public static extern PointFileFormatCollection GetPointFileFormats(Database pDatabase);

		// Token: 0x0600114F RID: 4431
		public virtual extern IEnumerator<PointFileFormat> GetEnumerator();

		// Token: 0x06001150 RID: 4432
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x06001151 RID: 4433
		[HandleProcessCorruptedStateExceptions]
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x06001152 RID: 4434
		public sealed extern void Dispose();

		// Token: 0x06001153 RID: 4435
		protected override extern void Finalize();

		// Token: 0x040012D5 RID: 4821
		private int <SyntheticNonEmptyStructMarker>;
	}
}
