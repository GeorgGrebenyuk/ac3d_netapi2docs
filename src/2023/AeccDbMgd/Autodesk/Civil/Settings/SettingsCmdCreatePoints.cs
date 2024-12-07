using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000CD7 RID: 3287
	public sealed class SettingsCmdCreatePoints : SettingsPoint
	{
		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x0600175B RID: 5979
		public extern SettingsCmdCreatePoints.SettingsCmdLayer Layer { get; }

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x0600175C RID: 5980
		public extern SettingsCmdCreatePoints.SettingsCmdPointsCreation PointsCreation { get; }

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x0600175D RID: 5981
		public extern SettingsCmdCreatePoints.SettingsCmdPointIdentity PointIdentity { get; }

		// Token: 0x02000CD8 RID: 3288
		public sealed class SettingsCmdLayer : TreeOidWrapper
		{
			// Token: 0x17000A54 RID: 2644
			// (get) Token: 0x0600175E RID: 5982
			public extern PropertyLayer Layer { get; }
		}

		// Token: 0x02000CD9 RID: 3289
		public sealed class SettingsCmdPointsCreation : TreeOidWrapper
		{
			// Token: 0x17000A5F RID: 2655
			// (get) Token: 0x0600175F RID: 5983
			public extern PropertyEnum<LocalCoordinateType> LocalCoordinates { get; }

			// Token: 0x17000A5E RID: 2654
			// (get) Token: 0x06001760 RID: 5984
			public extern PropertyEnum<GridCoordinateType> GridCoordinates { get; }

			// Token: 0x17000A5D RID: 2653
			// (get) Token: 0x06001761 RID: 5985
			public extern PropertyEnum<GeographicCoordinateType> GeographicCoordinates { get; }

			// Token: 0x17000A5C RID: 2652
			// (get) Token: 0x06001762 RID: 5986
			public extern PropertyEnum<AutomaticManual> PromptForElevations { get; }

			// Token: 0x17000A5B RID: 2651
			// (get) Token: 0x06001763 RID: 5987
			public extern PropertyEnum<AutomaticManual> PromptForPointNames { get; }

			// Token: 0x17000A5A RID: 2650
			// (get) Token: 0x06001764 RID: 5988
			public extern PropertyEnum<AutomaticManual> PromptForDescriptions { get; }

			// Token: 0x17000A59 RID: 2649
			// (get) Token: 0x06001765 RID: 5989
			public extern PropertyDouble DefaultElevation { get; }

			// Token: 0x17000A58 RID: 2648
			// (get) Token: 0x06001766 RID: 5990
			public extern PropertyString DefaultDescription { get; }

			// Token: 0x17000A57 RID: 2647
			// (get) Token: 0x06001767 RID: 5991
			public extern PropertyBoolean MatchOnDescriptionParameters { get; }

			// Token: 0x17000A56 RID: 2646
			// (get) Token: 0x06001768 RID: 5992
			public extern PropertyBoolean DisableDescriptionKeys { get; }

			// Token: 0x17000A55 RID: 2645
			// (get) Token: 0x06001769 RID: 5993
			public extern PropertyBoolean EchoCoordinatesToCommandLine { get; }
		}

		// Token: 0x02000CDA RID: 3290
		public sealed class SettingsCmdPointIdentity : TreeOidWrapper
		{
			// Token: 0x17000A68 RID: 2664
			// (get) Token: 0x0600176A RID: 5994
			public extern PropertyUInt NextPointNumber { get; }

			// Token: 0x17000A67 RID: 2663
			// (get) Token: 0x0600176B RID: 5995
			public extern PropertyBoolean UseSequentialNumbering { get; }

			// Token: 0x17000A66 RID: 2662
			// (get) Token: 0x0600176C RID: 5996
			public extern PropertyUInt PointNumberOffset { get; }

			// Token: 0x17000A65 RID: 2661
			// (get) Token: 0x0600176D RID: 5997
			public extern PropertyUInt StartPointNumber { get; }

			// Token: 0x17000A64 RID: 2660
			// (get) Token: 0x0600176E RID: 5998
			public extern PropertyEnum<PointNumbersSuppliedType> HandleSuppliedPointNumbersOption { get; }

			// Token: 0x17000A63 RID: 2659
			// (get) Token: 0x0600176F RID: 5999
			public extern PropertyBoolean ForceNames { get; }

			// Token: 0x17000A62 RID: 2658
			// (get) Token: 0x06001770 RID: 6000
			public extern PropertyEnum<PointNumbersExistType> ResolveDuplicatePointNumbersOption { get; }

			// Token: 0x17000A61 RID: 2657
			// (get) Token: 0x06001771 RID: 6001
			public extern PropertyEnum<PointNamesExistType> ResolveDuplicatePointNamesOption { get; }

			// Token: 0x17000A60 RID: 2656
			// (get) Token: 0x06001772 RID: 6002
			public extern PropertyEnum<PointNumbersAssignedType> AssignPointNamesOption { get; }
		}
	}
}
