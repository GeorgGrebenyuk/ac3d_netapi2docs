using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001113 RID: 4371
	public sealed class BaselineCollection : CivilWrapper<AeccDbCorridor>, IEnumerable<Baseline>
	{
		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x060023DF RID: 9183
		public extern ObjectId CorridorId { get; }

		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x060023E0 RID: 9184
		public extern int Count { get; }

		// Token: 0x170012C0 RID: 4800
		public extern Baseline this[Guid baselineGUID]
		{
			get;
		}

		// Token: 0x170012C1 RID: 4801
		public extern Baseline this[string baselineName]
		{
			get;
		}

		// Token: 0x170012C2 RID: 4802
		public extern Baseline this[int index]
		{
			get;
		}

		// Token: 0x060023E4 RID: 9188
		public extern Baseline Add(string baselineName, ObjectId alignmentId, ObjectId profileId);

		// Token: 0x060023E5 RID: 9189
		public extern Baseline Add(string baselineName, string alignmentName, string profileName);

		// Token: 0x060023E6 RID: 9190
		public extern Baseline AddGUIDBaseline(string baselineName, ObjectId alignmentId, ObjectId profileId);

		// Token: 0x060023E7 RID: 9191
		public extern IEnumerator<Baseline> GetEnumerator();

		// Token: 0x060023E8 RID: 9192
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x060023E9 RID: 9193
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(Baseline baseline);

		// Token: 0x060023EA RID: 9194
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(string baselineName);

		// Token: 0x060023EB RID: 9195
		public extern void RemoveAt(int index);
	}
}
