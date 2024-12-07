using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000A1 RID: 161
	[Wrapper("AeccDbSectionStyle")]
	public sealed class SectionStyle : StyleBase
	{
		// Token: 0x06000722 RID: 1826
		public extern DisplayStyle GetDisplayStyleSection(SectionDisplayStyleSectionType type);
	}
}
