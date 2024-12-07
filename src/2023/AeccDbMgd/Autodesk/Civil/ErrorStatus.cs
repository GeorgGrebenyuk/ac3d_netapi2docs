using System;

namespace Autodesk.Civil
{
	// Token: 0x0200018E RID: 398
	public enum ErrorStatus
	{
		// Token: 0x04000355 RID: 853
		Ok,
		// Token: 0x04000356 RID: 854
		PointNotOnEntity,
		// Token: 0x04000357 RID: 855
		EntityNotFound,
		// Token: 0x04000358 RID: 856
		ObjectNotOverridable,
		// Token: 0x04000359 RID: 857
		PropertyNotInheritable,
		// Token: 0x0400035A RID: 858
		PropertyLockedByAncestor,
		// Token: 0x0400035B RID: 859
		AlignmentError = 5000,
		// Token: 0x0400035C RID: 860
		NoPrevAlignmentEntity,
		// Token: 0x0400035D RID: 861
		NoNextAlignmentEntity,
		// Token: 0x0400035E RID: 862
		ProfileError = 6000,
		// Token: 0x0400035F RID: 863
		SurfaceError = 7000,
		// Token: 0x04000360 RID: 864
		NoSurfaceFound,
		// Token: 0x04000361 RID: 865
		ProcessingInterrupted,
		// Token: 0x04000362 RID: 866
		NoPointsInSurface,
		// Token: 0x04000363 RID: 867
		NoTrianglesInSurface,
		// Token: 0x04000364 RID: 868
		NoTriangleFound,
		// Token: 0x04000365 RID: 869
		PointOutsideSurface,
		// Token: 0x04000366 RID: 870
		TriangleIsDeleted,
		// Token: 0x04000367 RID: 871
		NoBorderFound,
		// Token: 0x04000368 RID: 872
		NoRangePointsFound,
		// Token: 0x04000369 RID: 873
		TrianglesAreNotNeeghbors,
		// Token: 0x0400036A RID: 874
		NoIntersectionFound,
		// Token: 0x0400036B RID: 875
		DuplicatePoint,
		// Token: 0x0400036C RID: 876
		NoPointFound,
		// Token: 0x0400036D RID: 877
		UnableToReadFile,
		// Token: 0x0400036E RID: 878
		NoEdgeFound,
		// Token: 0x0400036F RID: 879
		EdgeIsLocked,
		// Token: 0x04000370 RID: 880
		CantSwap,
		// Token: 0x04000371 RID: 881
		LoadFailed,
		// Token: 0x04000372 RID: 882
		DuplicateName,
		// Token: 0x04000373 RID: 883
		IllegalBoundary,
		// Token: 0x04000374 RID: 884
		InvalidFileFormat,
		// Token: 0x04000375 RID: 885
		SnapshotNotFound,
		// Token: 0x04000376 RID: 886
		GradingPasteToTargetSurfRejected,
		// Token: 0x04000377 RID: 887
		CorridorError = 8000,
		// Token: 0x04000378 RID: 888
		SurveyError = 9000,
		// Token: 0x04000379 RID: 889
		PrjStatusInsertError,
		// Token: 0x0400037A RID: 890
		PrjStatusWrongSvProject,
		// Token: 0x0400037B RID: 891
		PrjStatusWrongVaultProject,
		// Token: 0x0400037C RID: 892
		MetaQueryStatusNoName,
		// Token: 0x0400037D RID: 893
		MetaQueryStatusDuplicateName,
		// Token: 0x0400037E RID: 894
		MetaQueryStatusNotFound,
		// Token: 0x0400037F RID: 895
		MetaQueryStatusQueryDataFileMissing,
		// Token: 0x04000380 RID: 896
		SdxStatusDatabaseNotOpen,
		// Token: 0x04000381 RID: 897
		SdxStatusDatabaseNotReadable,
		// Token: 0x04000382 RID: 898
		SdxStatusDatabaseNotWritable,
		// Token: 0x04000383 RID: 899
		SdxStatusDefFileNotAvailable,
		// Token: 0x04000384 RID: 900
		SdxStatusDatabaseNotAvailable,
		// Token: 0x04000385 RID: 901
		SdxStatusActiveDrawingRequiredToOpen,
		// Token: 0x04000386 RID: 902
		SdbStatusCorruption,
		// Token: 0x04000387 RID: 903
		SdbStatusDatabaseDoesNotExist,
		// Token: 0x04000388 RID: 904
		SdbStatusDatabaseDirectoryNotWritable,
		// Token: 0x04000389 RID: 905
		SdbStatusDatabaseNotReadable,
		// Token: 0x0400038A RID: 906
		SdbStatusDatabaseNotWritable,
		// Token: 0x0400038B RID: 907
		SdbStatusDatabaseNotOpen,
		// Token: 0x0400038C RID: 908
		SdbStatusDatabaseVersionNewerThanSupported,
		// Token: 0x0400038D RID: 909
		SdbStatusDatabaseVersionCanNotBeUpgraded,
		// Token: 0x0400038E RID: 910
		SdbStatusDatabaseNeedMigration,
		// Token: 0x0400038F RID: 911
		SdbStatusDatabaseAccessPermissionDenied,
		// Token: 0x04000390 RID: 912
		SdbStatusDatabaseCreateCacheCopyFailed,
		// Token: 0x04000391 RID: 913
		SdbStatusDatabaseDuplicateProjectGUID,
		// Token: 0x04000392 RID: 914
		SdbStatusDatabaseProjectInfoMissingOrFailedToCreate,
		// Token: 0x04000393 RID: 915
		UnknownError = -1
	}
}
