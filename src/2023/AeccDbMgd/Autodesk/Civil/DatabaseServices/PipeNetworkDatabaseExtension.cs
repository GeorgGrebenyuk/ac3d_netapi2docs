using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000B50 RID: 2896
	internal static class PipeNetworkDatabaseExtension
	{
		// Token: 0x0600157A RID: 5498
		public static extern ObjectIdCollection GetCivilPipeNetworkIds(this Database database);
	}
}
