using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02001088 RID: 4232
	public sealed class SettingsCmdMapCheck : Autodesk.Civil.Settings.SettingsGeneral
	{
		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x060021D1 RID: 8657
		public extern SettingsCmdMapCheck.SettingsCmdMapcheck Mapcheck { get; }

		// Token: 0x02001089 RID: 4233
		public sealed class SettingsCmdMapcheck : TreeOidWrapper
		{
			// Token: 0x17001118 RID: 4376
			// (get) Token: 0x060021D2 RID: 8658
			public extern PropertyBoolean UseCommandLineInput { get; }

			// Token: 0x17001117 RID: 4375
			// (get) Token: 0x060021D3 RID: 8659
			public extern PropertyEnum<MapcheckSideType> DefaultSideType { get; }

			// Token: 0x17001116 RID: 4374
			// (get) Token: 0x060021D4 RID: 8660
			public extern PropertyEnum<MapcheckCurveDirectionType> DefaultCurveDirection { get; }

			// Token: 0x17001115 RID: 4373
			// (get) Token: 0x060021D5 RID: 8661
			public extern PropertyEnum<MapcheckAngleType> DefaultAngleType { get; }

			// Token: 0x17001114 RID: 4372
			// (get) Token: 0x060021D6 RID: 8662
			public extern PropertyEnum<MapcheckTraverseMethodType> DefaultCurveTraverseMethod { get; }

			// Token: 0x17001113 RID: 4371
			// (get) Token: 0x060021D7 RID: 8663
			public extern PropertyColor MapcheckColor { get; }

			// Token: 0x17001112 RID: 4370
			// (get) Token: 0x060021D8 RID: 8664
			public extern PropertyColor CurrentMapcheckColor { get; }

			// Token: 0x17001111 RID: 4369
			// (get) Token: 0x060021D9 RID: 8665
			public extern PropertyColor CurrentPointofBeginningColor { get; }

			// Token: 0x17001110 RID: 4368
			// (get) Token: 0x060021DA RID: 8666
			public extern PropertyColor CurrentSideColor { get; }
		}
	}
}
