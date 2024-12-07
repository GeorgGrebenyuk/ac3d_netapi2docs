using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000F00 RID: 3840
	public abstract class ProfileEntity : CivilWrapper<AeccDbVAlignment>
	{
		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x06001CC0 RID: 7360
		public abstract ProfileEntityType EntityType { get; }

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x06001CC1 RID: 7361
		public extern uint EntityId { get; }

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x06001CC2 RID: 7362
		public extern ProfileEntityConstraintType Constraint1 { get; }

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x06001CC3 RID: 7363
		public extern uint EntityBefore { get; }

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x06001CC4 RID: 7364
		public extern uint EntityAfter { get; }

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x06001CC5 RID: 7365
		// (set) Token: 0x06001CC6 RID: 7366
		public extern double Length { get; set; }

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x06001CC7 RID: 7367
		public extern double StartStation { get; }

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x06001CC8 RID: 7368
		public extern double StartElevation { get; }

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x06001CC9 RID: 7369
		public extern double EndStation { get; }

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x06001CCA RID: 7370
		public extern double EndElevation { get; }

		// Token: 0x06001CCB RID: 7371
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool ValidateDesignCheck(ProfileDesignCheck designCheck, ProfileApplyCurveType curveType);

		// Token: 0x06001CCC RID: 7372
		public extern ProfileDesignCheck[] DesignChecks();

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x06001CCD RID: 7373
		public extern double HighestDesignSpeed { get; }

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x06001CCE RID: 7374
		public extern double MinimumKValueSSD { get; }

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x06001CCF RID: 7375
		public extern double MinimumKValuePSD { get; }

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x06001CD0 RID: 7376
		public extern double MinimumKValueHSD { get; }

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x06001CD1 RID: 7377
		public extern EntityVerticalConstraintType Constraint2 { get; }

		// Token: 0x06001CD2 RID: 7378
		protected extern double InternalGetProfileEntityAttributeDouble(uint attributeId);

		// Token: 0x06001CD3 RID: 7379
		protected extern void InternalPutProfileEntityAttributeDouble(uint attributeId, double newValue);

		// Token: 0x040017D2 RID: 6098
		private int <SyntheticNonEmptyStructMarker>;
	}
}
