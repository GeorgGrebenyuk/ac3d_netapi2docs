using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000E62 RID: 3682
	public sealed class AlignmentRegion : CivilWrapper<AeccDbAlignment>
	{
		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x06001BD3 RID: 7123
		public extern AlignmentTransition EntryTransition { get; }

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x06001BD4 RID: 7124
		public extern AlignmentTransition ExitTransition { get; }

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x06001BD5 RID: 7125
		// (set) Token: 0x06001BD6 RID: 7126
		public extern double StartStation { get; set; }

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x06001BD7 RID: 7127
		// (set) Token: 0x06001BD8 RID: 7128
		public extern double EndStation { get; set; }

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06001BD9 RID: 7129
		// (set) Token: 0x06001BDA RID: 7130
		public extern double Length { get; set; }

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x06001BDB RID: 7131
		// (set) Token: 0x06001BDC RID: 7132
		public extern double Offset { get; set; }

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x06001BDD RID: 7133
		// (set) Token: 0x06001BDE RID: 7134
		public extern double IncreasedWidth { get; set; }

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06001BDF RID: 7135
		// (set) Token: 0x06001BE0 RID: 7136
		[DeprecatedVersion(CivilVersion.Civil2010)]
		[Obsolete("Autodesk.Civil.DatabaseServices.AlignmentRegion.Offset instead.", false)]
		public extern double OffsetDist { get; set; }

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x06001BE1 RID: 7137
		// (set) Token: 0x06001BE2 RID: 7138
		public extern AlignmentRegionType RegionType { get; set; }

		// Token: 0x06001BE3 RID: 7139
		public extern void Split();

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x06001BE4 RID: 7140
		public extern OffsetAlignmentWideningCriteria WideningCriteria { get; }

		// Token: 0x04001748 RID: 5960
		private int <SyntheticNonEmptyStructMarker>;
	}
}
