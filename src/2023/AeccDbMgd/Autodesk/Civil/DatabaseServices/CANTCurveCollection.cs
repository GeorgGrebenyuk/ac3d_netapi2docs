using System;
using System.Collections;
using System.Collections.Generic;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000E03 RID: 3587
	public sealed class CANTCurveCollection : IEnumerable<CANTCurve>
	{
		// Token: 0x17000DA6 RID: 3494
		public extern CANTCurve this[string name]
		{
			get;
		}

		// Token: 0x17000DA7 RID: 3495
		public extern CANTCurve this[int index]
		{
			get;
		}

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x06001B47 RID: 6983
		public extern int Count { get; }

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x06001B48 RID: 6984
		public extern ObjectId ParentAlignmentId { get; }

		// Token: 0x06001B49 RID: 6985
		public extern CANTCurve AddUserDefinedCurve(AlignmentSubEntity startSubEntity, AlignmentSubEntity endSubEntity);

		// Token: 0x06001B4A RID: 6986
		public extern IEnumerator<CANTCurve> GetEnumerator();

		// Token: 0x06001B4B RID: 6987
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x040016AA RID: 5802
		private int <SyntheticNonEmptyStructMarker>;
	}
}
