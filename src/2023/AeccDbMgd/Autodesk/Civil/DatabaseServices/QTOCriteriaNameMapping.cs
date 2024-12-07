using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000801 RID: 2049
	public class QTOCriteriaNameMapping : IDisposable
	{
		// Token: 0x06000F73 RID: 3955
		public extern ObjectId GetMappedSurfaceId(string materialName, string surfaceName);

		// Token: 0x06000F74 RID: 3956
		public extern void MapSurface(string surfaceName, ObjectId mappedSurfaceId);

		// Token: 0x06000F75 RID: 3957
		public extern void MapSurface(string materialName, string surfaceName, ObjectId mappedSurfaceId);

		// Token: 0x06000F76 RID: 3958
		public extern void MapCorridorShape(string shapeName, ObjectId mappedCorridorId, string mappedShapeName);

		// Token: 0x06000F77 RID: 3959
		public extern void MapCorridorShape(string materialName, string shapeName, ObjectId mappedCorridorId, string mappedShapeName);

		// Token: 0x06000F78 RID: 3960
		public extern void GetMappedCorridorShape(string materialName, string shapeName, ref ObjectId mappedCorridorId, ref string mappedShapeName);

		// Token: 0x06000F79 RID: 3961
		public extern QTOCriteriaNameMapping(ObjectId quantityTakeoffCriteriaId, ObjectId sampleLineGroupId);

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06000F7A RID: 3962
		public extern bool isMappingCompleted { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x06000F7B RID: 3963
		[HandleProcessCorruptedStateExceptions]
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x06000F7C RID: 3964
		public sealed extern void Dispose();

		// Token: 0x06000F7D RID: 3965
		protected override extern void Finalize();

		// Token: 0x0400120A RID: 4618
		private int <SyntheticNonEmptyStructMarker>;
	}
}
