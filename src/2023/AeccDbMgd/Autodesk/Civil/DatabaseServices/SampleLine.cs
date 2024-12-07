using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200007D RID: 125
	[Wrapper("AeccDbSampleLine")]
	public sealed class SampleLine : GeoEntity
	{
		// Token: 0x06000596 RID: 1430
		public static extern ObjectId Create(string sampleLineName, ObjectId sampleLineGroupId, Point2dCollection points);

		// Token: 0x06000597 RID: 1431
		public static extern ObjectId Create(string sampleLineName, ObjectId sampleLineGroupId, double station);

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000598 RID: 1432
		public extern ObjectId GroupId { get; }

		// Token: 0x17000206 RID: 518
		// (set) Token: 0x06000599 RID: 1433
		public override extern ObjectId StyleId { set; }

		// Token: 0x17000205 RID: 517
		// (set) Token: 0x0600059A RID: 1434
		public override extern string StyleName { set; }

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600059B RID: 1435
		public extern int Number { get; }

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600059C RID: 1436
		// (set) Token: 0x0600059D RID: 1437
		public extern bool LockToStation { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x0600059E RID: 1438
		public extern ObjectIdCollection GetSectionViewIds();

		// Token: 0x0600059F RID: 1439
		public extern ObjectIdCollection GetSectionIds();

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060005A0 RID: 1440
		// (set) Token: 0x060005A1 RID: 1441
		public extern double Station { get; set; }

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060005A2 RID: 1442
		public extern SampleLineVertexCollection Vertices { get; }

		// Token: 0x060005A3 RID: 1443
		public extern ObjectId GetSectionId(ObjectId sampledSourceId);

		// Token: 0x060005A4 RID: 1444
		public extern ObjectId GetMaterialSectionId(Guid materialListGuid, Guid materialGuid);
	}
}
