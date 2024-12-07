using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A27 RID: 2599
	public class SurfaceOperationAddContour : SurfaceOperation
	{
		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x0600139E RID: 5022
		// (set) Token: 0x0600139F RID: 5023
		public extern string Description { get; set; }

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x060013A0 RID: 5024
		public extern string Summary { get; }

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x060013A1 RID: 5025
		public extern double MidOrdinateDistance { get; }

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x060013A2 RID: 5026
		public extern double MaximumDistance { get; }

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x060013A3 RID: 5027
		public extern double WeedingDistance { get; }

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x060013A4 RID: 5028
		public extern double WeedingAngle { get; }

		// Token: 0x060013A5 RID: 5029
		public extern ObjectIdCollection InsertIntoDrawing();
	}
}
