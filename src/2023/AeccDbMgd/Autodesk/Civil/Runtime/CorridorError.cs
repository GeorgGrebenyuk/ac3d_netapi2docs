using System;

namespace Autodesk.Civil.Runtime
{
	// Token: 0x02001237 RID: 4663
	public enum CorridorError
	{
		// Token: 0x04001B58 RID: 7000
		None,
		// Token: 0x04001B59 RID: 7001
		Success = -2147221504,
		// Token: 0x04001B5A RID: 7002
		Failure,
		// Token: 0x04001B5B RID: 7003
		CouldNotSolveInLayoutMode,
		// Token: 0x04001B5C RID: 7004
		ParameterNotFound,
		// Token: 0x04001B5D RID: 7005
		LogicalNameNotFound,
		// Token: 0x04001B5E RID: 7006
		NoSideslopeIntersectFound,
		// Token: 0x04001B5F RID: 7007
		NoSubgradeIntersectFound,
		// Token: 0x04001B60 RID: 7008
		ScriptModuleNotFound,
		// Token: 0x04001B61 RID: 7009
		ScriptMacroNotFound,
		// Token: 0x04001B62 RID: 7010
		CorridorStateNotFound,
		// Token: 0x04001B63 RID: 7011
		ScriptPossibleSyntaxError,
		// Token: 0x04001B64 RID: 7012
		StopProcessingGroup,
		// Token: 0x04001B65 RID: 7013
		StopProcessingAssembly,
		// Token: 0x04001B66 RID: 7014
		StopProcessingRegion,
		// Token: 0x04001B67 RID: 7015
		StopProcessingBaseline,
		// Token: 0x04001B68 RID: 7016
		StopProcessingCorridor,
		// Token: 0x04001B69 RID: 7017
		ElevationAtStationNotFound,
		// Token: 0x04001B6A RID: 7018
		ScriptModulePathUpdated,
		// Token: 0x04001B6B RID: 7019
		CorridorOutOfDate,
		// Token: 0x04001B6C RID: 7020
		ValueShouldNotBeLessThanOrEqualToZero,
		// Token: 0x04001B6D RID: 7021
		ValueShouldNotBeLessThanZero,
		// Token: 0x04001B6E RID: 7022
		ValueShouldNotBeZero,
		// Token: 0x04001B6F RID: 7023
		ValueInABadPosition,
		// Token: 0x04001B70 RID: 7024
		ValueTooSmall,
		// Token: 0x04001B71 RID: 7025
		ValueTooLarge,
		// Token: 0x04001B72 RID: 7026
		NoLinkIntersectFound,
		// Token: 0x04001B73 RID: 7027
		NoMarkedPointFound,
		// Token: 0x04001B74 RID: 7028
		ValueShouldNotBeOdd,
		// Token: 0x04001B75 RID: 7029
		InvalidArraySpecifiedForLinkDefinition,
		// Token: 0x04001B76 RID: 7030
		InvalidArraySpecifiedForLinkDefinitionFormat,
		// Token: 0x04001B77 RID: 7031
		InvalidArraySpecifiedForShapeDefinition,
		// Token: 0x04001B78 RID: 7032
		InvalidArraySpecifiedForShapeDefinitionFormat,
		// Token: 0x04001B79 RID: 7033
		InvalidCorridorStateObjectId,
		// Token: 0x04001B7A RID: 7034
		InvalidSubassemblyCOMClassId,
		// Token: 0x04001B7B RID: 7035
		StopProcessingConditional = -2147221469,
		// Token: 0x04001B7C RID: 7036
		ReprocessSubassembly,
		// Token: 0x04001B7D RID: 7037
		ReprocessAssembly,
		// Token: 0x04001B7E RID: 7038
		ReprocessRegion,
		// Token: 0x04001B7F RID: 7039
		ReprocessBaseline
	}
}
