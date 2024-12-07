using System;
using System.Collections;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000DF4 RID: 3572
	public sealed class DesignSpeedCollection : CivilWrapper<AeccDbAlignment>, IEnumerable<DesignSpeed>
	{
		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x06001A56 RID: 6742
		public extern int Count { get; }

		// Token: 0x17000D2D RID: 3373
		public extern DesignSpeed this[int index]
		{
			get;
		}

		// Token: 0x06001A58 RID: 6744
		public extern DesignSpeed GetDesignSpeed(double rawStation);

		// Token: 0x06001A59 RID: 6745
		public extern DesignSpeed Add(double station, double speed);

		// Token: 0x06001A5A RID: 6746
		public extern void Remove(double rawStation);

		// Token: 0x06001A5B RID: 6747
		public extern void Remove(int Index);

		// Token: 0x06001A5C RID: 6748
		public extern IEnumerator<DesignSpeed> GetEnumerator();

		// Token: 0x06001A5D RID: 6749
		public extern IEnumerator GetObjectEnumerator();
	}
}
