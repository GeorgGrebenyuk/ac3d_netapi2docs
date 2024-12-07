using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A1F RID: 2591
	public struct WallBreaklineCreationDataEx
	{
		// Token: 0x04001408 RID: 5128
		public ObjectId SourceId;

		// Token: 0x04001409 RID: 5129
		public bool IsRightSideOffset;

		// Token: 0x0400140A RID: 5130
		public double[] Elevations;
	}
}
