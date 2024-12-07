using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001128 RID: 4392
	public sealed class BaselineRegionCollection : CivilWrapper<AeccDbCorridor>, IEnumerable<BaselineRegion>
	{
		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x0600241B RID: 9243
		public extern ObjectId CorridorId { get; }

		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x0600241C RID: 9244
		public extern int Count { get; }

		// Token: 0x170012DB RID: 4827
		public extern BaselineRegion this[Guid regionGUID]
		{
			get;
		}

		// Token: 0x170012DC RID: 4828
		public extern BaselineRegion this[string regionName]
		{
			get;
		}

		// Token: 0x170012DD RID: 4829
		public extern BaselineRegion this[int index]
		{
			get;
		}

		// Token: 0x06002420 RID: 9248
		[Obsolete("Use Autodesk.Civil.DatabaseServices.BaselineRegionCollection.Add instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2014)]
		public extern BaselineRegion AddRegion(string regionName, ObjectId assemblyId);

		// Token: 0x06002421 RID: 9249
		[Obsolete("Use Autodesk.Civil.DatabaseServices.BaselineRegionCollection.Add instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2014)]
		public extern BaselineRegion AddRegion(string regionName, string assemblyName);

		// Token: 0x06002422 RID: 9250
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(BaselineRegion region);

		// Token: 0x06002423 RID: 9251
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(string regionName);

		// Token: 0x06002424 RID: 9252
		public extern void RemoveAt(int index);

		// Token: 0x06002425 RID: 9253
		public extern BaselineRegion Add(string regionName, ObjectId assemblyId, double startStation, double endStation);

		// Token: 0x06002426 RID: 9254
		public extern BaselineRegion Add(string regionName, string assemblyName, double startStation, double endStation);

		// Token: 0x06002427 RID: 9255
		public extern BaselineRegion Add(string regionName, ObjectId assemblyId);

		// Token: 0x06002428 RID: 9256
		public extern BaselineRegion Add(string regionName, string assemblyName);

		// Token: 0x06002429 RID: 9257
		public extern int IndexOf(BaselineRegion region);

		// Token: 0x0600242A RID: 9258
		public extern IEnumerator<BaselineRegion> GetEnumerator();

		// Token: 0x0600242B RID: 9259
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x04001A80 RID: 6784
		private int <SyntheticNonEmptyStructMarker>;
	}
}
