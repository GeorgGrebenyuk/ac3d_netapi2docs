using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001166 RID: 4454
	public sealed class FeatureLineCollection : CivilWrapper<AeccDbCorridor>, IEnumerable<CorridorFeatureLine>
	{
		// Token: 0x1700133A RID: 4922
		// (get) Token: 0x060024E2 RID: 9442
		public extern ObjectId CorridorId { get; }

		// Token: 0x17001339 RID: 4921
		// (get) Token: 0x060024E3 RID: 9443
		public extern int Count { get; }

		// Token: 0x17001338 RID: 4920
		public extern CorridorFeatureLine this[int index]
		{
			get;
		}

		// Token: 0x17001337 RID: 4919
		// (get) Token: 0x060024E5 RID: 9445
		public extern FeatureLineCodeInfo FeatureLineCodeInfo { get; }

		// Token: 0x17001336 RID: 4918
		// (get) Token: 0x060024E6 RID: 9446
		// (set) Token: 0x060024E7 RID: 9447
		public extern bool IsConnectExtraPoints { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17001335 RID: 4917
		// (get) Token: 0x060024E8 RID: 9448
		// (set) Token: 0x060024E9 RID: 9449
		public extern FeatureLineConnectDirectionType ConnectDirection { get; set; }

		// Token: 0x060024EA RID: 9450
		public extern IEnumerator<CorridorFeatureLine> GetEnumerator();

		// Token: 0x060024EB RID: 9451
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x04001AB5 RID: 6837
		private int <SyntheticNonEmptyStructMarker>;
	}
}
