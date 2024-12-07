using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200007E RID: 126
	[Wrapper("AeccDbSampleLineGroup")]
	public sealed class SampleLineGroup : GeoEntity
	{
		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060005A5 RID: 1445
		public extern ObjectId ParentAlignmentId { get; }

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060005A6 RID: 1446
		public extern SectionViewGroupCollection SectionViewGroups { get; }

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060005A7 RID: 1447
		public extern SectionViewGroup IndividualSectionViewGroup { get; }

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060005A8 RID: 1448
		public extern QTOMaterialListCollection MaterialLists { get; }

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060005A9 RID: 1449
		// (set) Token: 0x060005AA RID: 1450
		public extern ObjectId DefaultSamplineStyleId { get; set; }

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060005AB RID: 1451
		// (set) Token: 0x060005AC RID: 1452
		public extern ObjectId DefaultSamplineLabelStyleId { get; set; }

		// Token: 0x060005AD RID: 1453
		public extern ObjectIdCollection GetSampleLineIds(double station, double tolerance);

		// Token: 0x060005AE RID: 1454
		public extern ObjectIdCollection GetSampleLineIds();

		// Token: 0x060005AF RID: 1455
		public extern ObjectIdCollection GetMassHaulViewIds();

		// Token: 0x060005B0 RID: 1456
		public extern string[] GetQTOMappingNames();

		// Token: 0x060005B1 RID: 1457
		public extern Guid GetMappingGuid(string mappingName);

		// Token: 0x060005B2 RID: 1458
		public extern string[] GetMaterialNamesInMapping(Guid mappingGuid);

		// Token: 0x060005B3 RID: 1459
		public extern Guid GetMaterialGuid(Guid mappingGuid, string materialName);

		// Token: 0x060005B4 RID: 1460
		public extern QuantityTakeoffResult GetTotalVolumeResultDataForMaterialList(Guid mappingGuid);

		// Token: 0x060005B5 RID: 1461
		public extern ObjectIdCollection GetAvailableSampleLineLabelGroupIds();

		// Token: 0x060005B6 RID: 1462
		public extern SectionSourceCollection GetSectionSources();

		// Token: 0x060005B7 RID: 1463
		public extern MaterialSectionSourceCollection GetMaterialSectionSources();

		// Token: 0x060005B8 RID: 1464
		public static extern ObjectId Create(string groupName, ObjectId alignmentId);

		// Token: 0x060005B9 RID: 1465
		public static extern void ReportQuantities(ObjectId sampleLineGroupId, string materialList, string reportFile, string styleSheetFile);
	}
}
