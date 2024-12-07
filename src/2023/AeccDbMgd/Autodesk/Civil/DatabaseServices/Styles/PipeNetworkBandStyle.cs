using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000CB RID: 203
	[Wrapper("AeccDbGraphProfileStylePipeNetworkBand")]
	public sealed class PipeNetworkBandStyle : BandStyle
	{
		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000977 RID: 2423
		public override extern BandType BandType { get; }

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000978 RID: 2424
		public override extern ObjectId TitleTextLabelStyleId { get; }

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000979 RID: 2425
		public extern ObjectId StructureLabelStyleId { get; }

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x0600097A RID: 2426
		public extern ObjectId PipeLabelStyleId { get; }

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x0600097B RID: 2427
		public extern BandTickStyle StructureTickStyle { get; }

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x0600097C RID: 2428
		public extern BandTickStyle PipeTickStyle { get; }

		// Token: 0x0600097D RID: 2429
		public extern DisplayStyle GetDisplayStylePlan(PipeNetworkDisplayStyleType type);
	}
}
