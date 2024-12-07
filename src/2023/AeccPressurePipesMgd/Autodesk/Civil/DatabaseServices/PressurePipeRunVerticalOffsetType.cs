using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200015C RID: 348
	public enum PressurePipeRunVerticalOffsetType
	{
		// Token: 0x040001DD RID: 477
		CutLength,
		// Token: 0x040001DE RID: 478
		OffsetAtBends,
		// Token: 0x040001DF RID: 479
		[DeprecatedVersion(CivilVersion.Civil2022)]
		[Obsolete("Rename to OffsetAtBends. Use OffsetAtBends instead.", false)]
		OffsetAtFitting = 1
	}
}
