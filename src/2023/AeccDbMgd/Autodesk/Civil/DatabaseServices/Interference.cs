using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000C8 RID: 200
	[Wrapper("AeccDbInterference")]
	public sealed class Interference : GeoEntity
	{
		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x0600096E RID: 2414
		public extern ObjectId Network1Id { get; }

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x0600096F RID: 2415
		public extern ObjectId Network2Id { get; }
	}
}
