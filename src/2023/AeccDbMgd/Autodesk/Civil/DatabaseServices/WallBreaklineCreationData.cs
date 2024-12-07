using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A20 RID: 2592
	public struct WallBreaklineCreationData
	{
		// Token: 0x0400140B RID: 5131
		public ObjectId SourceId;

		// Token: 0x0400140C RID: 5132
		public bool IsRightSideOffset;

		// Token: 0x0400140D RID: 5133
		public double Elevation;
	}
}
