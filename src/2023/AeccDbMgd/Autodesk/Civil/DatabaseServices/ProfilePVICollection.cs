using System;
using System.Collections;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000F02 RID: 3842
	public sealed class ProfilePVICollection : CivilWrapper<AeccDbVAlignment>, IEnumerable<ProfilePVI>
	{
		// Token: 0x17000E77 RID: 3703
		public extern ProfilePVI this[int index]
		{
			get;
		}

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x06001D04 RID: 7428
		public extern int Count { get; }

		// Token: 0x06001D05 RID: 7429
		public extern ProfilePVI GetPVIAt(double station, double elevation);

		// Token: 0x06001D06 RID: 7430
		public extern void RemoveAt(double station, double elevation);

		// Token: 0x06001D07 RID: 7431
		public extern void RemoveAt(int index);

		// Token: 0x06001D08 RID: 7432
		public extern void Remove(ProfilePVI profilePVI);

		// Token: 0x06001D09 RID: 7433
		public extern ProfilePVI AddPVI(double station, double elevation);

		// Token: 0x06001D0A RID: 7434
		public extern ProfilePVI AddPVIArc(double station, double elevation, double radius);

		// Token: 0x06001D0B RID: 7435
		public extern ProfilePVI AddPVISymParabola(double station, double elevation, double curveLength);

		// Token: 0x06001D0C RID: 7436
		public extern ProfilePVI AddPVIAsymParabola(double station, double elevation, double tangentLen1, double tangentLen2);

		// Token: 0x06001D0D RID: 7437
		public extern IEnumerator<ProfilePVI> GetEnumerator();

		// Token: 0x06001D0E RID: 7438
		public extern IEnumerator GetObjectEnumerator();
	}
}
