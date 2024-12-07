using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000CF2 RID: 3314
	public sealed class SettingsCmdCatchmentArea : SettingsSurface
	{
		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x0600178E RID: 6030
		public extern PropertyLayer Layer { get; }

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x0600178F RID: 6031
		public extern PropertyEnum<CatchmentObjectType> ObjectType { get; }

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06001790 RID: 6032
		public extern PropertyBoolean DisplayDisChargePoint { get; }

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06001791 RID: 6033
		public extern PropertyString DischargePointStyle { get; }

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06001792 RID: 6034
		public extern PropertyObjectId DischargePointStyleId { get; }
	}
}
