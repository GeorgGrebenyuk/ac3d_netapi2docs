using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000062 RID: 98
	[Wrapper("AeccDbLotLine")]
	public sealed class ParcelSegment : Feature
	{
		// Token: 0x06000459 RID: 1113
		public extern ObjectIdCollection GetAvailableParcelSegmentLabelIds();
	}
}
