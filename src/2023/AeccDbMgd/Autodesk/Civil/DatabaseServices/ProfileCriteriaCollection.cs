using System;
using System.Collections;
using System.Collections.Generic;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000E92 RID: 3730
	public sealed class ProfileCriteriaCollection : CivilWrapper<AeccDbGraphProfile>, IEnumerable<ProfileCriteria>
	{
		// Token: 0x17000E36 RID: 3638
		public extern ProfileCriteria this[int index]
		{
			get;
		}

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x06001C53 RID: 7251
		public extern int Count { get; }

		// Token: 0x06001C54 RID: 7252
		public extern void Add(ObjectId profileId, HatchCriteriaBoundaryType type);

		// Token: 0x06001C55 RID: 7253
		public extern void RemoveAt(int index);

		// Token: 0x06001C56 RID: 7254
		public extern IEnumerator<ProfileCriteria> GetEnumerator();

		// Token: 0x06001C57 RID: 7255
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x04001770 RID: 6000
		private int <SyntheticNonEmptyStructMarker>;
	}
}
