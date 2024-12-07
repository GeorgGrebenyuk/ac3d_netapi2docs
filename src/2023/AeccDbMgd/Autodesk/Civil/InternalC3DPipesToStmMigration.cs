using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil
{
	// Token: 0x0200072F RID: 1839
	public sealed class InternalC3DPipesToStmMigration
	{
		// Token: 0x06000E5B RID: 3675
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool Migrate(Database pDwgDb, string stmFileName, ObjectIdCollection pipeNetworkIds);

		// Token: 0x06000E5C RID: 3676
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool Migrate(Database pDwgDb, string stmFileName, List<string> selectedNames);

		// Token: 0x06000E5D RID: 3677
		public extern InternalC3DPipesToStmMigration();
	}
}
