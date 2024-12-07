using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001177 RID: 4471
	public sealed class CorridorSurfaceMask : CorridorSurfaceBaseMask
	{
		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x0600255F RID: 9567
		// (set) Token: 0x06002560 RID: 9568
		public extern ObjectId RenderMaterialId { get; set; }
	}
}
