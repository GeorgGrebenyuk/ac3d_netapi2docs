using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000B63 RID: 2915
	public class QTOSectionalResult : CivilWrapper<AeccQuantityTakeoffResult::SECTIONAL_RESULT>
	{
		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x060015A2 RID: 5538
		public extern QTOAreaResult AreaResult { get; }

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x060015A3 RID: 5539
		public extern QTOVolumeResult VolumeResult { get; }

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x060015A4 RID: 5540
		public extern double Station { get; }

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x060015A5 RID: 5541
		public extern string SampleLineName { get; }

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x060015A6 RID: 5542
		public extern ObjectId SampleLineId { get; }
	}
}
