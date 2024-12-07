using System;
using System.Collections;
using System.Collections.Generic;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020009D2 RID: 2514
	public class SurfaceOperationAddBreakline : SurfaceOperation, IEnumerable<SurfaceBreakline>
	{
		// Token: 0x170007AE RID: 1966
		public extern SurfaceBreakline this[int index]
		{
			get;
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06001292 RID: 4754
		// (set) Token: 0x06001293 RID: 4755
		public extern string Description { get; set; }

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06001294 RID: 4756
		public extern int Count { get; }

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06001295 RID: 4757
		public extern SurfaceBreaklineType BreaklineType { get; }

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06001296 RID: 4758
		public extern double MidOrdinateDistance { get; }

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06001297 RID: 4759
		public extern double MaximumDistance { get; }

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06001298 RID: 4760
		public extern double WeedingDistance { get; }

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06001299 RID: 4761
		public extern double WeedingAngle { get; }

		// Token: 0x0600129A RID: 4762
		public extern ObjectIdCollection InsertIntoDrawing();

		// Token: 0x0600129B RID: 4763
		public virtual extern IEnumerator<SurfaceBreakline> GetEnumerator();

		// Token: 0x0600129C RID: 4764
		public extern IEnumerator GetObjectEnumerator();
	}
}
