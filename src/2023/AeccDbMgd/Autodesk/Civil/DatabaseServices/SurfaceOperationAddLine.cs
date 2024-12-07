using System;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A74 RID: 2676
	public class SurfaceOperationAddLine : SurfaceOperation
	{
		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06001425 RID: 5157
		public extern Point2d StartLocation { get; }

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06001426 RID: 5158
		public extern Point2d EndLocation { get; }
	}
}
