using System;

namespace Autodesk.Civil
{
	// Token: 0x02000190 RID: 400
	public enum SurveyStatus
	{
		// Token: 0x040003BA RID: 954
		StatusOk,
		// Token: 0x040003BB RID: 955
		FdbStatusCorruption = 5,
		// Token: 0x040003BC RID: 956
		FdbStatusNoName,
		// Token: 0x040003BD RID: 957
		FdbStatusDuplicateName,
		// Token: 0x040003BE RID: 958
		FdbStatusDatabaseDoesNotExist,
		// Token: 0x040003BF RID: 959
		FdbStatusNotFound,
		// Token: 0x040003C0 RID: 960
		FdbStatusDuplicateDbName,
		// Token: 0x040003C1 RID: 961
		FdbStatusDbNoName,
		// Token: 0x040003C2 RID: 962
		FdbStatusDatabaseDirectoryNotWritable,
		// Token: 0x040003C3 RID: 963
		FdbStatusDatabaseNotReadable,
		// Token: 0x040003C4 RID: 964
		FdbStatusDatabaseNotWritable,
		// Token: 0x040003C5 RID: 965
		EdbStatusCorruption,
		// Token: 0x040003C6 RID: 966
		EdbStatusNoName,
		// Token: 0x040003C7 RID: 967
		EdbStatusDuplicateName,
		// Token: 0x040003C8 RID: 968
		EdbStatusDatabaseDoesNotExist,
		// Token: 0x040003C9 RID: 969
		EdbStatusNotFound,
		// Token: 0x040003CA RID: 970
		EdbStatusDuplicateDbName,
		// Token: 0x040003CB RID: 971
		EdbStatusDbNoName,
		// Token: 0x040003CC RID: 972
		EdbStatusDatabaseDirectoryNotWritable,
		// Token: 0x040003CD RID: 973
		EdbStatusDatabaseNotReadable,
		// Token: 0x040003CE RID: 974
		EdbStatusDatabaseNotWritable,
		// Token: 0x040003CF RID: 975
		SdbStatusCorruption,
		// Token: 0x040003D0 RID: 976
		SdbStatusDatabaseDoesNotExist,
		// Token: 0x040003D1 RID: 977
		SdbStatusDatabaseDirectoryNotWritable,
		// Token: 0x040003D2 RID: 978
		SdbStatusDatabaseNotReadable,
		// Token: 0x040003D3 RID: 979
		SdbStatusDatabaseNotWritable,
		// Token: 0x040003D4 RID: 980
		SdbStatusDatabaseNotOpen,
		// Token: 0x040003D5 RID: 981
		SdbStatusDatabaseVersionNewerThanSupported,
		// Token: 0x040003D6 RID: 982
		SdbStatusDatabaseVersionCanNotBeUpgraded,
		// Token: 0x040003D7 RID: 983
		SdbStatusDatabaseNeedMigration,
		// Token: 0x040003D8 RID: 984
		SdbStatusDatabaseAccessPermissionDenied,
		// Token: 0x040003D9 RID: 985
		SdbStatusDatabaseCreateCacheCopyFailed,
		// Token: 0x040003DA RID: 986
		SdbStatusDatabaseDuplicateProjectGUID,
		// Token: 0x040003DB RID: 987
		SdbStatusDatabaseProjectInfoMissingOrFailedToCreate,
		// Token: 0x040003DC RID: 988
		FigStatusNoName,
		// Token: 0x040003DD RID: 989
		FigStatusNotFound,
		// Token: 0x040003DE RID: 990
		FigStatusNodeNotFound,
		// Token: 0x040003DF RID: 991
		FigStatusRecalcNotPermitted,
		// Token: 0x040003E0 RID: 992
		FigStatusRecalcFailed,
		// Token: 0x040003E1 RID: 993
		NetStatusNoName,
		// Token: 0x040003E2 RID: 994
		NetStatusDuplicateName,
		// Token: 0x040003E3 RID: 995
		NetStatusNotFound,
		// Token: 0x040003E4 RID: 996
		NetStatusNoFileSpecified,
		// Token: 0x040003E5 RID: 997
		ObsStatusNotFound,
		// Token: 0x040003E6 RID: 998
		StpStatusNotFound,
		// Token: 0x040003E7 RID: 999
		TrvStatusNoName,
		// Token: 0x040003E8 RID: 1000
		TrvStatusNotFound,
		// Token: 0x040003E9 RID: 1001
		TrvStatusNodeNotFound,
		// Token: 0x040003EA RID: 1002
		TrvStatusDuplicateName,
		// Token: 0x040003EB RID: 1003
		PrjStatusInsertError,
		// Token: 0x040003EC RID: 1004
		PrjStatusWrongSvProject,
		// Token: 0x040003ED RID: 1005
		PrjStatusWrongVaultProject,
		// Token: 0x040003EE RID: 1006
		SdxStatusDatabaseNotOpen,
		// Token: 0x040003EF RID: 1007
		SdxStatusDatabaseNotReadable,
		// Token: 0x040003F0 RID: 1008
		SdxStatusDatabaseNotWritable,
		// Token: 0x040003F1 RID: 1009
		SdxStatusDefFileNotAvailable,
		// Token: 0x040003F2 RID: 1010
		SdxStatusDatabaseNotAvailable,
		// Token: 0x040003F3 RID: 1011
		SdxStatusActiveDrawingRequiredToOpen,
		// Token: 0x040003F4 RID: 1012
		SdxStatusSchemaNotOpen,
		// Token: 0x040003F5 RID: 1013
		SdxStatusSchemaNotOpenForWrite,
		// Token: 0x040003F6 RID: 1014
		SdxStatusSchemaAttributeNotDefined,
		// Token: 0x040003F7 RID: 1015
		SdxStatusSchemaAttributeInUse,
		// Token: 0x040003F8 RID: 1016
		SdxStatusSchemaInvalidAttributeDefinitionParameter,
		// Token: 0x040003F9 RID: 1017
		SdxStatusSchemaDuplicateClassAttributeName,
		// Token: 0x040003FA RID: 1018
		SdxStatusSchemaAttributeDefinitionNotFound,
		// Token: 0x040003FB RID: 1019
		SdxStatusSchemaInternalError,
		// Token: 0x040003FC RID: 1020
		SdxStatusDataObjectNotOpen = 71,
		// Token: 0x040003FD RID: 1021
		SdxStatusDataObjectNotOpenForWrite,
		// Token: 0x040003FE RID: 1022
		SdxStatusDataWrongAttrClass,
		// Token: 0x040003FF RID: 1023
		SdxStatusDataCollectionNotFound,
		// Token: 0x04000400 RID: 1024
		SdxStatusDataRecordNotFound,
		// Token: 0x04000401 RID: 1025
		SdxStatusDataCreateCollectionFailed,
		// Token: 0x04000402 RID: 1026
		SdxStatusDataObjectNotFound,
		// Token: 0x04000403 RID: 1027
		SdxStatusDataMultipleRecordsNotSupported,
		// Token: 0x04000404 RID: 1028
		SetStatusFileNotAvailable,
		// Token: 0x04000405 RID: 1029
		SetStatusFileNotReadable,
		// Token: 0x04000406 RID: 1030
		SetStatusFileNotWritable,
		// Token: 0x04000407 RID: 1031
		SetStatusFileNotCorrectType,
		// Token: 0x04000408 RID: 1032
		GrpStatusNotFound,
		// Token: 0x04000409 RID: 1033
		GrpStatusDuplicateName,
		// Token: 0x0400040A RID: 1034
		GrpStatusNoName,
		// Token: 0x0400040B RID: 1035
		TranslateDbInvalidInput,
		// Token: 0x0400040C RID: 1036
		ImpEventStatusNoName,
		// Token: 0x0400040D RID: 1037
		ImpEventStatusDuplicateName,
		// Token: 0x0400040E RID: 1038
		ImpEventStatusNotFound,
		// Token: 0x0400040F RID: 1039
		ImpEventStatusImportDuplicateFileFound,
		// Token: 0x04000410 RID: 1040
		ImpEventStatusImportFileNotFound,
		// Token: 0x04000411 RID: 1041
		ImpEventStatusPointFormatNotFound,
		// Token: 0x04000412 RID: 1042
		ImpEventStatusF2FCodingConventionNotFound,
		// Token: 0x04000413 RID: 1043
		PointStatusConflictPointIgnored,
		// Token: 0x04000414 RID: 1044
		PointStatusConflictAbortProcess,
		// Token: 0x04000415 RID: 1045
		LogStatusLogFileNotFound,
		// Token: 0x04000416 RID: 1046
		LogStatusXslFileNotFound,
		// Token: 0x04000417 RID: 1047
		LogStatusXmlCouldNotBeGenerated,
		// Token: 0x04000418 RID: 1048
		LogStatusHtmlFileNotGenerated,
		// Token: 0x04000419 RID: 1049
		LogStatusOldHtmlFileNotDeleted,
		// Token: 0x0400041A RID: 1050
		MetaQueryStatusNoName,
		// Token: 0x0400041B RID: 1051
		MetaQueryStatusDuplicateName,
		// Token: 0x0400041C RID: 1052
		MetaQueryStatusNotFound,
		// Token: 0x0400041D RID: 1053
		MetaQueryStatusQueryDataFileMissing
	}
}
