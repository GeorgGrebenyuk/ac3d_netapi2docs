using System;
using System.Reflection;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000790 RID: 1936
	[DefaultMember("Item")]
	public abstract class AlignmentCurve : AlignmentEntity
	{
		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06000EED RID: 3821
		// (set) Token: 0x06000EEE RID: 3822
		public virtual extern double Length { get; set; }

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06000EEF RID: 3823
		public virtual extern Point2d StartPoint { get; }

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06000EF0 RID: 3824
		public virtual extern Point2d EndPoint { get; }

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06000EF1 RID: 3825
		public virtual extern double StartStation { get; }

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06000EF2 RID: 3826
		public virtual extern double EndStation { get; }

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06000EF3 RID: 3827
		public virtual extern double HighestDesignSpeed { get; }
	}
}
