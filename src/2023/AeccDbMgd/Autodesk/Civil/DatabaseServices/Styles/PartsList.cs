using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000D9 RID: 217
	[Wrapper("AeccDbPartList")]
	public sealed class PartsList : StyleBase
	{
		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x060009DF RID: 2527
		public extern int PartFamilyCount { get; }

		// Token: 0x17000438 RID: 1080
		public extern ObjectId this[string description]
		{
			get;
		}

		// Token: 0x17000439 RID: 1081
		public extern ObjectId this[int index]
		{
			get;
		}

		// Token: 0x060009E2 RID: 2530
		public extern ObjectIdCollection GetPartFamilyIdsByDomain(DomainType domain);

		// Token: 0x060009E3 RID: 2531
		public extern void AddPartFamilyByGuid(DomainType domain, string guid);

		// Token: 0x060009E4 RID: 2532
		public extern void AddPartFamilyByDescription(DomainType domain, string description);

		// Token: 0x060009E5 RID: 2533
		public extern void RemovePartFamily(ObjectId partFamilyId);

		// Token: 0x060009E6 RID: 2534
		public extern void RemovePartFamily(string description);

		// Token: 0x060009E7 RID: 2535
		public static extern DataPartFamily[] GetAvailablePartFamilies(DomainType domain);
	}
}
