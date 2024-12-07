using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02001258 RID: 4696
	public class ColumnStyle : CivilWrapper<AeccDbScheduleTableStyle>
	{
		// Token: 0x170014FE RID: 5374
		// (get) Token: 0x060028CB RID: 10443
		// (set) Token: 0x060028CC RID: 10444
		public extern double ColumnWidth { get; set; }

		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x060028CD RID: 10445
		// (set) Token: 0x060028CE RID: 10446
		public extern string HeaderString { get; [DeprecatedVersion(CivilVersion.Civil2013)] [Obsolete("Use HeaderStringFormatted instead.", false)] set; }

		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x060028CF RID: 10447
		// (set) Token: 0x060028D0 RID: 10448
		public extern string HeaderStringFormatted { get; set; }

		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x060028D1 RID: 10449
		// (set) Token: 0x060028D2 RID: 10450
		public extern TextJustificationType HeaderJustification { get; set; }

		// Token: 0x170014FA RID: 5370
		// (get) Token: 0x060028D3 RID: 10451
		// (set) Token: 0x060028D4 RID: 10452
		public extern string ContentString { get; [DeprecatedVersion(CivilVersion.Civil2013)] [Obsolete("Use ContentStringFormatted instead.", false)] set; }

		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x060028D5 RID: 10453
		// (set) Token: 0x060028D6 RID: 10454
		public extern string ContentStringFormatted { get; set; }

		// Token: 0x170014F8 RID: 5368
		// (get) Token: 0x060028D7 RID: 10455
		// (set) Token: 0x060028D8 RID: 10456
		public extern TextJustificationType ContentJustification { get; set; }

		// Token: 0x060028D9 RID: 10457
		protected extern string InternalGetContentString(AeccTableSegmentData.dataType type);

		// Token: 0x060028DA RID: 10458
		protected extern void InternalSetContentString(AeccTableSegmentData.dataType type, string newVal);

		// Token: 0x060028DB RID: 10459
		protected extern string InternalGetContentStringFormatted(AeccTableSegmentData.dataType type);

		// Token: 0x060028DC RID: 10460
		protected extern void InternalSetContentStringFormatted(AeccTableSegmentData.dataType type, string newVal);

		// Token: 0x04001BB4 RID: 7092
		protected int m_CurrentIndex;
	}
}
