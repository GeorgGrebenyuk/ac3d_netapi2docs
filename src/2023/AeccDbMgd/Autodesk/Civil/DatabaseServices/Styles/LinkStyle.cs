using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000E4 RID: 228
	[Wrapper("AeccDbRoadwayLinkStyle")]
	public sealed class LinkStyle : SubassemblySubentityStyle
	{
		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000A3F RID: 2623
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.LinkStyle.GetLinkDisplayStylePlan() instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2010)]
		public extern DisplayStyle LinkDisplayStylePlan { get; }

		// Token: 0x06000A40 RID: 2624
		public extern DisplayStyle GetLinkDisplayStylePlan();

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000A41 RID: 2625
		[DeprecatedVersion(CivilVersion.Civil2010)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.LinkStyle.GetLinkDisplayStyleModel() instead.", false)]
		public extern DisplayStyle LinkDisplayStyleModel { get; }

		// Token: 0x06000A42 RID: 2626
		public extern DisplayStyle GetLinkDisplayStyleModel();

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000A43 RID: 2627
		public override extern SubassemblySubentityStyleType StyleType { get; }

		// Token: 0x06000A44 RID: 2628
		public extern DisplayStyle GetDisplayStylePlan();

		// Token: 0x06000A45 RID: 2629
		public extern DisplayStyle GetDisplayStyleModel();

		// Token: 0x06000A46 RID: 2630
		public extern DisplayStyle GetDisplayStyleSection();
	}
}
