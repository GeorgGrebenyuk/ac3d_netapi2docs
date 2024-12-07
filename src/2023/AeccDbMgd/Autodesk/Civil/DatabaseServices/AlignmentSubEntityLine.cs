using System;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000E3D RID: 3645
	public class AlignmentSubEntityLine : AlignmentSubEntity
	{
		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x06001B6E RID: 7022
		public override extern AlignmentSubEntityType SubEntityType { get; }

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x06001B6F RID: 7023
		public extern double Direction { get; }

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x06001B70 RID: 7024
		public extern Point2d MidPoint { get; }

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x06001B71 RID: 7025
		// (set) Token: 0x06001B72 RID: 7026
		public extern Point2d PassThroughPoint1 { get; set; }

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x06001B73 RID: 7027
		// (set) Token: 0x06001B74 RID: 7028
		public extern Point2d PassThroughPoint2 { get; set; }
	}
}
