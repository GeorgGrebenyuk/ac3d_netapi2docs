using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A90 RID: 2704
	public class SurfaceOperationCreatedFromCorridor : SurfaceOperation
	{
		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x0600145F RID: 5215
		public extern ObjectId CorridorId { get; }

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06001460 RID: 5216
		public extern string CorridorSurfaceName { get; }
	}
}
