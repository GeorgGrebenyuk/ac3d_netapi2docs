using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000E02 RID: 3586
	public sealed class SuperelevationCurveCollection : IEnumerable<SuperelevationCurve>
	{
		// Token: 0x17000DA2 RID: 3490
		public extern SuperelevationCurve this[string name]
		{
			get;
		}

		// Token: 0x17000DA3 RID: 3491
		public extern SuperelevationCurve this[int index]
		{
			get;
		}

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x06001B3F RID: 6975
		public extern int Count { get; }

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x06001B40 RID: 6976
		public extern ObjectId ParentAlignmentId { get; }

		// Token: 0x06001B41 RID: 6977
		public extern SuperelevationCurve AddUserDefinedCurve(AlignmentSubEntity startSubEntity, AlignmentSubEntity endSubEntity);

		// Token: 0x06001B42 RID: 6978
		public static extern void ImportSuperelevationDataFromFile(string fileName, ObjectId alignmentId, [MarshalAs(UnmanagedType.U1)] bool acceptGarbage);

		// Token: 0x06001B43 RID: 6979
		public extern IEnumerator<SuperelevationCurve> GetEnumerator();

		// Token: 0x06001B44 RID: 6980
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x040016A9 RID: 5801
		private int <SyntheticNonEmptyStructMarker>;
	}
}
