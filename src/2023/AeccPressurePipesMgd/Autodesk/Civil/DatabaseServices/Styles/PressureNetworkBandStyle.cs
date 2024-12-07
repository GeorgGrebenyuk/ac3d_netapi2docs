using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x0200000F RID: 15
	[Wrapper("AeccDbGraphProfileStylePressureNetworkBand")]
	public sealed class PressureNetworkBandStyle : BandStyle
	{
		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060000FA RID: 250
		public override extern BandType BandType { get; }

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060000FB RID: 251
		public override extern ObjectId TitleTextLabelStyleId { get; }

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060000FC RID: 252
		public extern ObjectId PressurePipeLabelStyleId { get; }

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060000FD RID: 253
		public extern ObjectId FittingLabelStyleId { get; }

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060000FE RID: 254
		public extern ObjectId AppurtenanceLabelStyleId { get; }

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060000FF RID: 255
		public extern BandTickStyle PressurePipeTickStyle { get; }

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000100 RID: 256
		public extern BandTickStyle FittingTickStyle { get; }

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000101 RID: 257
		public extern BandTickStyle AppurtenanceTickStyle { get; }

		// Token: 0x06000102 RID: 258
		public extern DisplayStyle GetDisplayStylePlan(PressureNetworkDisplayStyleType type);
	}
}
