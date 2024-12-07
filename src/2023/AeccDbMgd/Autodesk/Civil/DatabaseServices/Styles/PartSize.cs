using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000DB RID: 219
	[Wrapper("AeccDbPartSizeFilter")]
	public sealed class PartSize : DBObject
	{
		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060009F5 RID: 2549
		// (set) Token: 0x060009F6 RID: 2550
		public extern ObjectId MaterialStyleId { get; set; }

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060009F7 RID: 2551
		// (set) Token: 0x060009F8 RID: 2552
		public extern ObjectId RulesStyleId { get; set; }

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060009F9 RID: 2553
		// (set) Token: 0x060009FA RID: 2554
		public extern ObjectId PartStyleId { get; set; }

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x060009FB RID: 2555
		// (set) Token: 0x060009FC RID: 2556
		public extern PartDataRecord SizeDataRecord { get; set; }

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x060009FD RID: 2557
		// (set) Token: 0x060009FE RID: 2558
		public extern string[] PayItems { get; set; }
	}
}
