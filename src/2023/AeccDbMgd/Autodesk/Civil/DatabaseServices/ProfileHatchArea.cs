using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000E9D RID: 3741
	public sealed class ProfileHatchArea : CivilWrapper<AeccDbGraphProfile>
	{
		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x06001C62 RID: 7266
		// (set) Token: 0x06001C63 RID: 7267
		public extern string Name { get; set; }

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x06001C64 RID: 7268
		// (set) Token: 0x06001C65 RID: 7269
		public extern string ShapeStyleName { get; set; }

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x06001C66 RID: 7270
		// (set) Token: 0x06001C67 RID: 7271
		public extern ObjectId ShapeStyleId { get; set; }

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x06001C68 RID: 7272
		public extern ProfileCriteriaCollection Criteria { get; }

		// Token: 0x0400177C RID: 6012
		private int <SyntheticNonEmptyStructMarker>;
	}
}
