using System;
using System.Collections;
using System.Collections.Generic;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000EA1 RID: 3745
	public sealed class ProfileHatchAreaCollection : CivilWrapper<AeccDbGraphProfile>, IEnumerable<ProfileHatchArea>
	{
		// Token: 0x17000E41 RID: 3649
		public extern ProfileHatchArea this[string name]
		{
			get;
		}

		// Token: 0x17000E42 RID: 3650
		public extern ProfileHatchArea this[int index]
		{
			get;
		}

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x06001C6B RID: 7275
		public extern int Count { get; }

		// Token: 0x06001C6C RID: 7276
		public extern void Add(string hatchAreaName, ObjectId upperProfileId, ObjectId lowerProfileId, ObjectId shapeStyleId);

		// Token: 0x06001C6D RID: 7277
		public extern void Remove(string hatchAreaName);

		// Token: 0x06001C6E RID: 7278
		public extern IEnumerator<ProfileHatchArea> GetEnumerator();

		// Token: 0x06001C6F RID: 7279
		public extern IEnumerator GetObjectEnumerator();
	}
}
