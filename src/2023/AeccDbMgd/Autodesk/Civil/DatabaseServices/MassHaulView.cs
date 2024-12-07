using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000079 RID: 121
	[Wrapper("AeccDbGraphMassHaulView")]
	public sealed class MassHaulView : Graph
	{
		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000574 RID: 1396
		public extern ObjectId MassHaulLineId { get; }
	}
}
