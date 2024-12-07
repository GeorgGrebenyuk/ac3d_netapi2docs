using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200090C RID: 2316
	public class SectionViewGroupCollection : IEnumerable<SectionViewGroup>
	{
		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x060011CD RID: 4557
		public extern int Count { get; }

		// Token: 0x17000750 RID: 1872
		public extern SectionViewGroup this[int index]
		{
			get;
		}

		// Token: 0x060011CF RID: 4559
		public extern void RemoveAt(int index);

		// Token: 0x060011D0 RID: 4560
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(SectionViewGroup sectionViewGroup);

		// Token: 0x060011D1 RID: 4561
		public extern SectionViewGroup Add(Point3d insertPosition, double startStation, double endStation, SectionViewGroupCreationRangeOptions rangeOptions, SectionViewGroupCreationPlacementOptions placementOptions, SectionDisplayOptionCollection sectionDisplayOptions, ObjectId sectionViewStyleId, ObjectId sectionViewBandSetStyleId);

		// Token: 0x060011D2 RID: 4562
		public extern SectionViewGroup Add(Point3d insertPosition, double startStation, double endStation, SectionViewGroupCreationRangeOptions rangeOptions, SectionViewGroupCreationPlacementOptions placementOptions);

		// Token: 0x060011D3 RID: 4563
		public extern SectionViewGroup Add(Point3d insertPosition);

		// Token: 0x060011D4 RID: 4564
		public virtual extern IEnumerator<SectionViewGroup> GetEnumerator();

		// Token: 0x060011D5 RID: 4565
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x04001314 RID: 4884
		private int <SyntheticNonEmptyStructMarker>;
	}
}
