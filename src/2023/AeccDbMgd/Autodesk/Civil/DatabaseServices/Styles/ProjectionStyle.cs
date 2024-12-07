using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x0200008A RID: 138
	[Wrapper("AeccDbProfileSectionEntityStyle")]
	public sealed class ProjectionStyle : StyleBase
	{
		// Token: 0x06000627 RID: 1575
		public extern DisplayStyle GetDisplayStyleProfile(ProjectionDisplayStyleProfileType type);

		// Token: 0x06000628 RID: 1576
		public extern DisplayStyle GetDisplayStyleSection(ProjectionDisplayStyleSectionType type);

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000629 RID: 1577
		public extern ProjectionProfileOptions ProfileOptions { get; }

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x0600062A RID: 1578
		public extern ProjectionSectionOptions SectionOptions { get; }
	}
}
