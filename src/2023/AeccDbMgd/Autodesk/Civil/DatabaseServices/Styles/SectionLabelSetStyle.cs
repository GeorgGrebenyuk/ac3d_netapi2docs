using System;
using System.Collections;
using System.Collections.Generic;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000092 RID: 146
	[Wrapper("AeccDbSectionLabelsDlgTemplate")]
	public sealed class SectionLabelSetStyle : BaseLabelSetStyle, IEnumerable<SectionLabelSetItem>
	{
		// Token: 0x17000253 RID: 595
		public extern SectionLabelSetItem this[int index]
		{
			get;
		}

		// Token: 0x06000664 RID: 1636
		public extern IEnumerator<SectionLabelSetItem> GetEnumerator();

		// Token: 0x06000665 RID: 1637
		public extern IEnumerator GetObjectEnumerator();
	}
}
