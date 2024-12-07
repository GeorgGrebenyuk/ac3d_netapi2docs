using System;
using System.Collections;
using System.Collections.Generic;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001129 RID: 4393
	public sealed class CorridorCollection : CivilWrapper<AcDbDatabase>, IEnumerable<ObjectId>
	{
		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x0600242C RID: 9260
		public extern int Count { get; }

		// Token: 0x170012E0 RID: 4832
		public extern ObjectId this[string corridorName]
		{
			get;
		}

		// Token: 0x170012E1 RID: 4833
		public extern ObjectId this[int index]
		{
			get;
		}

		// Token: 0x0600242F RID: 9263
		public extern ObjectId Add(string corridorName, string baselineName, ObjectId alignmentId, ObjectId profileId, string baselineRegionName, ObjectId assemblyId);

		// Token: 0x06002430 RID: 9264
		public extern ObjectId Add(string corridorName, string baselineName, ObjectId alignmentId, ObjectId profileId);

		// Token: 0x06002431 RID: 9265
		public extern ObjectId Add(string corridorName);

		// Token: 0x06002432 RID: 9266
		public extern void RebuildAll();

		// Token: 0x06002433 RID: 9267
		public extern IEnumerator<ObjectId> GetEnumerator();

		// Token: 0x06002434 RID: 9268
		public extern IEnumerator GetObjectEnumerator();
	}
}
