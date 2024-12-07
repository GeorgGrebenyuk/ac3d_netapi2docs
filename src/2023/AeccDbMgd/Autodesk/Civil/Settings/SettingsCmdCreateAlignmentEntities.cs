using System;
using Autodesk.Civil.DatabaseServices;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D4E RID: 3406
	public sealed class SettingsCmdCreateAlignmentEntities : SettingsAlignment
	{
		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x06001883 RID: 6275
		public extern SettingsCmdCreateAlignmentEntities.SettingsCmdCreateFromEntities CreateFromEntities { get; }

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x06001884 RID: 6276
		public extern SettingsCmdCreateAlignmentEntities.SettingsCmdAlignmentTypeOption AlignmentTypeOption { get; }

		// Token: 0x02000D4F RID: 3407
		public sealed class SettingsCmdCreateFromEntities : TreeOidWrapper
		{
			// Token: 0x17000B7D RID: 2941
			// (get) Token: 0x06001885 RID: 6277
			public extern PropertyDouble Radius { get; }

			// Token: 0x17000B7C RID: 2940
			// (get) Token: 0x06001886 RID: 6278
			public extern PropertyBoolean AddCurveBetweenTangents { get; }

			// Token: 0x17000B7B RID: 2939
			// (get) Token: 0x06001887 RID: 6279
			public extern PropertyBoolean EraseExistingEntities { get; }
		}

		// Token: 0x02000D50 RID: 3408
		public sealed class SettingsCmdAlignmentTypeOption : TreeOidWrapper
		{
			// Token: 0x17000B7E RID: 2942
			// (get) Token: 0x06001888 RID: 6280
			public extern PropertyEnum<AlignmentType> AlignmentType { get; }
		}
	}
}
