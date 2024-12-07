using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000B65 RID: 2917
	public class QuantityTakeoffResult : CivilWrapper<AeccQuantityTakeoffResult>
	{
		// Token: 0x060015AA RID: 5546
		public extern QTOSectionalResult[] GetResultsAlongSampleLines();

		// Token: 0x060015AB RID: 5547
		public extern QTOSectionalResult GetResult(double sampleLineStation);

		// Token: 0x060015AC RID: 5548
		public extern QTOSectionalResult GetResult(double sampleLineStation, double tolerance);

		// Token: 0x060015AD RID: 5549
		public extern QTOSectionalResult GetResult(string sampleLineName);

		// Token: 0x060015AE RID: 5550
		public extern QTOSectionalResult GetResult(ObjectId sampleLineId);
	}
}
