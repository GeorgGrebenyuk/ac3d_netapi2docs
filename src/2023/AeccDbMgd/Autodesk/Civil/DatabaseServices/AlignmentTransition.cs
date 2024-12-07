using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000E63 RID: 3683
	public sealed class AlignmentTransition : CivilWrapper<AeccDbAlignment>
	{
		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x06001BE5 RID: 7141
		public extern AlignmentRegion NextRegion { get; }

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06001BE6 RID: 7142
		public extern AlignmentRegion PreviousRegion { get; }

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06001BE7 RID: 7143
		// (set) Token: 0x06001BE8 RID: 7144
		public extern TransitionType TransitionType { get; set; }

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x06001BE9 RID: 7145
		public extern TransitionDescriptionBase TransitionDescription { get; }

		// Token: 0x06001BEA RID: 7146
		public extern void Slim();

		// Token: 0x04001749 RID: 5961
		private int <SyntheticNonEmptyStructMarker>;
	}
}
