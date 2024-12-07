using System;
using Autodesk.AutoCAD.Colors;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000040 RID: 64
	public class ContourValues
	{
		// Token: 0x0600017F RID: 383
		public extern ContourValues(Color majorColr, Color minorColor, ObjectId majorLineTypeId, ObjectId minorLineTypeId, LineWeight majorLineWight, LineWeight minorLineWight);

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000180 RID: 384
		// (set) Token: 0x06000181 RID: 385
		public extern Color MajorColor { get; set; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000182 RID: 386
		// (set) Token: 0x06000183 RID: 387
		public extern Color MinorColor { get; set; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000184 RID: 388
		// (set) Token: 0x06000185 RID: 389
		public extern ObjectId MajorLineTypeId { get; set; }

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000186 RID: 390
		// (set) Token: 0x06000187 RID: 391
		public extern ObjectId MinorLineTypeId { get; set; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000188 RID: 392
		// (set) Token: 0x06000189 RID: 393
		public extern LineWeight MajorLineWeight { get; set; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600018A RID: 394
		// (set) Token: 0x0600018B RID: 395
		public extern LineWeight MinorLineWeight { get; set; }

		// Token: 0x040002E6 RID: 742
		private int <SyntheticNonEmptyStructMarker>;
	}
}
