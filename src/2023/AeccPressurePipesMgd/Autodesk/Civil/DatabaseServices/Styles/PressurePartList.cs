using System;
using System.Collections.Generic;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x0200000B RID: 11
	[Wrapper("AeccDbPressurePartList")]
	public sealed class PressurePartList : StyleBase
	{
		// Token: 0x060000D8 RID: 216
		public static extern ObjectIdCollection GetAvailablePartLists(Database database);

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060000D9 RID: 217
		public extern string CatalogGuid { get; }

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060000DA RID: 218
		public extern PressurePartCatalog Catalog { get; }

		// Token: 0x060000DB RID: 219
		public extern PressurePartSize GetPart(string guid);

		// Token: 0x060000DC RID: 220
		public extern void AddPart(PressurePartSize part);

		// Token: 0x060000DD RID: 221
		public extern void UpdatePart(PressurePartSize part);

		// Token: 0x060000DE RID: 222
		public extern void RemovePart(PressurePartSize part);

		// Token: 0x060000DF RID: 223
		public extern List<PressurePartSize> GetParts(PressurePartType type);

		// Token: 0x060000E0 RID: 224
		public extern List<PressurePartSize> GetParts(PressurePartDomainType domain);

		// Token: 0x060000E1 RID: 225
		public extern Dictionary<string, List<PressurePartSize>> GetPartCategories(PressurePartType type, PressurePartContextType context);

		// Token: 0x060000E2 RID: 226
		public extern Dictionary<string, List<PressurePartSize>> GetPartCategories(PressurePartDomainType domain, PressurePartContextType context);

		// Token: 0x060000E3 RID: 227
		public extern List<string> GetCategories(PressurePartDomainType domain);

		// Token: 0x060000E4 RID: 228
		public extern List<PressurePartType> GetPartTypes(PressurePartDomainType domain);
	}
}
