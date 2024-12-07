using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200006F RID: 111
	[Wrapper("AeccDbLabeling")]
	public class LabelGroup : LabelBase
	{
		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060004AD RID: 1197
		public extern uint SubEntityCount { get; }

		// Token: 0x060004AE RID: 1198
		public extern LabelGroupSubEntity GetAt(uint index);

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060004AF RID: 1199
		public virtual extern IList<LabelGroupSubEntity> SubEntities { get; }

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060004B0 RID: 1200
		// (set) Token: 0x060004B1 RID: 1201
		public override extern ObjectId StyleId { get; set; }

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060004B2 RID: 1202
		// (set) Token: 0x060004B3 RID: 1203
		public override extern string StyleName { get; set; }

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060004B4 RID: 1204
		// (set) Token: 0x060004B5 RID: 1205
		public override extern DimensionAnchorOptionType DefaultDimensionAnchorOption { get; set; }

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060004B6 RID: 1206
		// (set) Token: 0x060004B7 RID: 1207
		public override extern double DefaultDimensionAnchorValue { get; set; }

		// Token: 0x060004B8 RID: 1208
		public extern void ResetAllSubCommonLabelLocations();

		// Token: 0x060004B9 RID: 1209
		public extern void ResetAllSubCommonLabelProperties();

		// Token: 0x060004BA RID: 1210
		public extern void ResetAllSubCommonLabels();

		// Token: 0x060004BB RID: 1211
		protected internal extern LabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
