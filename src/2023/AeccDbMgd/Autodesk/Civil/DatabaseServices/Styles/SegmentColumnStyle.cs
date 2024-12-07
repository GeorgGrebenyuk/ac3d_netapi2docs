using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02001261 RID: 4705
	public sealed class SegmentColumnStyle : ColumnStyle
	{
		// Token: 0x060028E3 RID: 10467
		public extern string GetContentString(TableSegmentDataType type);

		// Token: 0x060028E4 RID: 10468
		[Obsolete("Use SetContentStringFormatted instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2013)]
		public extern void SetContentString(TableSegmentDataType type, string newVal);

		// Token: 0x060028E5 RID: 10469
		public extern string GetContentStringFormatted(TableSegmentDataType type);

		// Token: 0x060028E6 RID: 10470
		public extern void SetContentStringFormatted(TableSegmentDataType type, string newVal);
	}
}
