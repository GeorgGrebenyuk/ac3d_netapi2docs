using System;
using System.Collections;
using System.Collections.Generic;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000091 RID: 145
	[Wrapper("AeccDbVAlignStnLabelsDlgTemplate")]
	public sealed class ProfileLabelSetStyle : BaseLabelSetStyle, IEnumerable<ProfileLabelSetItem>
	{
		// Token: 0x17000252 RID: 594
		public extern ProfileLabelSetItem this[int index]
		{
			get;
		}

		// Token: 0x0600065F RID: 1631
		public extern void AddSagCurve(ObjectId labelStyleId);

		// Token: 0x06000660 RID: 1632
		public extern void AddCrestCurve(ObjectId labelStyleId);

		// Token: 0x06000661 RID: 1633
		public extern IEnumerator<ProfileLabelSetItem> GetEnumerator();

		// Token: 0x06000662 RID: 1634
		public extern IEnumerator GetObjectEnumerator();
	}
}
