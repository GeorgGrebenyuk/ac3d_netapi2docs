using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000057 RID: 87
	public class SplitProfileViewCreationOptions
	{
		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600038B RID: 907
		// (set) Token: 0x0600038C RID: 908
		public extern double ViewHeight { get; set; }

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600038D RID: 909
		// (set) Token: 0x0600038E RID: 910
		public extern ObjectId FirstViewStyleId { get; set; }

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600038F RID: 911
		// (set) Token: 0x06000390 RID: 912
		public extern ObjectId IntermediateViewStyleId { get; set; }

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000391 RID: 913
		// (set) Token: 0x06000392 RID: 914
		public extern ObjectId LastViewStyleId { get; set; }

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000393 RID: 915
		// (set) Token: 0x06000394 RID: 916
		public extern ProfileViewSplitStationType SplitStationOption { get; set; }

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000395 RID: 917
		// (set) Token: 0x06000396 RID: 918
		public extern ProfileViewSplitDatumType SplitDatumOption { get; set; }

		// Token: 0x06000397 RID: 919
		public extern SplitProfileViewCreationOptions(double viewHeight, ObjectId firstViewStyleId, ObjectId intermediateViewStyleId, ObjectId lastViewStyleId);

		// Token: 0x040002F8 RID: 760
		private int <SyntheticNonEmptyStructMarker>;
	}
}
