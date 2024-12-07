using System;
using System.Collections;
using System.Collections.Generic;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000090 RID: 144
	[Wrapper("AeccDbAlignStnLabelsDlgTemplate")]
	public sealed class AlignmentLabelSetStyle : BaseLabelSetStyle, IEnumerable<AlignmentLabelSetItem>
	{
		// Token: 0x17000251 RID: 593
		public extern AlignmentLabelSetItem this[int index]
		{
			get;
		}

		// Token: 0x0600065C RID: 1628
		public extern IEnumerator<AlignmentLabelSetItem> GetEnumerator();

		// Token: 0x0600065D RID: 1629
		public extern IEnumerator GetObjectEnumerator();
	}
}
