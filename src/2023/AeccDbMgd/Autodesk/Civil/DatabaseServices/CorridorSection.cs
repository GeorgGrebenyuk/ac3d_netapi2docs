using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200005F RID: 95
	[Wrapper("AeccDbSectionCorridor")]
	public sealed class CorridorSection : Section
	{
		// Token: 0x0600042B RID: 1067
		public extern ObjectId GetCorridor();

		// Token: 0x0600042C RID: 1068
		public extern void SetCorridor(string corridorName);

		// Token: 0x0600042D RID: 1069
		public extern void SetCorridor(ObjectId corridorId);

		// Token: 0x0600042E RID: 1070
		public extern string[] GetPointCodes();

		// Token: 0x0600042F RID: 1071
		public extern string[] GetLinkCodes();

		// Token: 0x06000430 RID: 1072
		public extern string[] GetShapeCodes();

		// Token: 0x17000155 RID: 341
		// (set) Token: 0x06000431 RID: 1073
		public override extern ObjectId StyleId { set; }

		// Token: 0x17000154 RID: 340
		// (set) Token: 0x06000432 RID: 1074
		public override extern string StyleName { set; }
	}
}
