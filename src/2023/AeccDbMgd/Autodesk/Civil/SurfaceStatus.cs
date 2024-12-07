using System;

namespace Autodesk.Civil
{
	// Token: 0x0200018F RID: 399
	public enum SurfaceStatus
	{
		// Token: 0x04000395 RID: 917
		Success,
		// Token: 0x04000396 RID: 918
		NoSurfaceFound,
		// Token: 0x04000397 RID: 919
		ProcessingInterrupted,
		// Token: 0x04000398 RID: 920
		NoPointsInSurface,
		// Token: 0x04000399 RID: 921
		NoTrianglesInSurface,
		// Token: 0x0400039A RID: 922
		NoTriangleFound,
		// Token: 0x0400039B RID: 923
		PointOutsideSurface,
		// Token: 0x0400039C RID: 924
		TriangleIsDeleted,
		// Token: 0x0400039D RID: 925
		NoBorderFound,
		// Token: 0x0400039E RID: 926
		NoRangePointsFound,
		// Token: 0x0400039F RID: 927
		TrianglesAreNotNeighbors,
		// Token: 0x040003A0 RID: 928
		NoIntersectionFound,
		// Token: 0x040003A1 RID: 929
		DuplicatePoint,
		// Token: 0x040003A2 RID: 930
		NoPointFound,
		// Token: 0x040003A3 RID: 931
		Failure,
		// Token: 0x040003A4 RID: 932
		UnimplementedOperation,
		// Token: 0x040003A5 RID: 933
		UnableToReadFile,
		// Token: 0x040003A6 RID: 934
		NoEdgeFound,
		// Token: 0x040003A7 RID: 935
		EdgeIsLocked,
		// Token: 0x040003A8 RID: 936
		CantSwap,
		// Token: 0x040003A9 RID: 937
		LoadFailed,
		// Token: 0x040003AA RID: 938
		DuplicateName,
		// Token: 0x040003AB RID: 939
		IllegalBoundary,
		// Token: 0x040003AC RID: 940
		InvalidFileFormat,
		// Token: 0x040003AD RID: 941
		FileNotFound,
		// Token: 0x040003AE RID: 942
		SnapshotNotFound,
		// Token: 0x040003AF RID: 943
		GradingPasteToTargetSurfRejected,
		// Token: 0x040003B0 RID: 944
		IncompatibleGrids,
		// Token: 0x040003B1 RID: 945
		UnableToOpenSurfaceStyle,
		// Token: 0x040003B2 RID: 946
		PointOnFlatArea,
		// Token: 0x040003B3 RID: 947
		NeighborsNotFullySpecified,
		// Token: 0x040003B4 RID: 948
		InconsistentNeighborPointers,
		// Token: 0x040003B5 RID: 949
		PointsNotInCcwOrder,
		// Token: 0x040003B6 RID: 950
		OutOfMemory,
		// Token: 0x040003B7 RID: 951
		BaseSurfaceNotFound,
		// Token: 0x040003B8 RID: 952
		ComparisonSurfaceNotFound
	}
}
