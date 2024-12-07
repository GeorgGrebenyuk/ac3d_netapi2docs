using System;
using Autodesk.Civil.DatabaseServices;

namespace Autodesk.Civil.Settings
{
	// Token: 0x020010D8 RID: 4312
	public sealed class SettingsCmdCreateAlignFromCorridor : SettingsCorridor
	{
		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x060022D6 RID: 8918
		public extern SettingsCmdCreateAlignFromCorridor.SettingsCmdAlignmentTypeOption AlignmentTypeOption { get; }

		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x060022D7 RID: 8919
		public extern SettingsCmdCreateAlignFromCorridor.SettingsCmdProfileCreationOption ProfileCreationOption { get; }

		// Token: 0x170011B7 RID: 4535
		// (get) Token: 0x060022D8 RID: 8920
		public extern SettingsCmdCreateAlignFromCorridor.SettingsCmdCriteriaBasedDesignOptions CriteriaBasedDesignOptions { get; }

		// Token: 0x020010D9 RID: 4313
		public sealed class SettingsCmdAlignmentTypeOption : TreeOidWrapper
		{
			// Token: 0x170011BA RID: 4538
			// (get) Token: 0x060022D9 RID: 8921
			public extern PropertyEnum<AlignmentType> AlignmentType { get; }
		}

		// Token: 0x020010DA RID: 4314
		public sealed class SettingsCmdProfileCreationOption : TreeOidWrapper
		{
			// Token: 0x170011BB RID: 4539
			// (get) Token: 0x060022DA RID: 8922
			public extern PropertyBoolean CreateProfileFromCorridor { get; }
		}

		// Token: 0x020010DB RID: 4315
		public sealed class SettingsCmdCriteriaBasedDesignOptions : TreeOidWrapper
		{
			// Token: 0x170011C3 RID: 4547
			// (get) Token: 0x060022DB RID: 8923
			public extern PropertyBoolean UseCriteriaBasedDesignOption { get; }

			// Token: 0x170011C2 RID: 4546
			// (get) Token: 0x060022DC RID: 8924
			public extern PropertyDouble DesignSpeed { get; }

			// Token: 0x170011C1 RID: 4545
			// (get) Token: 0x060022DD RID: 8925
			public extern PropertyBoolean UseDesignCriteriaFileOption { get; }

			// Token: 0x170011C0 RID: 4544
			// (get) Token: 0x060022DE RID: 8926
			public extern PropertyBoolean UseDesignChecksOption { get; }

			// Token: 0x170011BF RID: 4543
			// (get) Token: 0x060022DF RID: 8927
			public extern PropertyString DefaultDesignCheckSet { get; }

			// Token: 0x170011BE RID: 4542
			// (get) Token: 0x060022E0 RID: 8928
			public extern PropertyObjectId DefaultDesignCheckSetId { get; }

			// Token: 0x170011BD RID: 4541
			// (get) Token: 0x060022E1 RID: 8929
			public extern PropertyEnum<DesignSpeedLookupMethodType> DesignSpeedLookupMethod { get; }

			// Token: 0x170011BC RID: 4540
			// (get) Token: 0x060022E2 RID: 8930
			public extern PropertyEnum<RadiusLookupMethodType> RadiusLookupMethod { get; }
		}
	}
}
