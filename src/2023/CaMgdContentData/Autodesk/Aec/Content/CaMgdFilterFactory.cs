using System;
using System.Collections.Generic;

namespace Autodesk.Aec.Content
{
	// Token: 0x02000040 RID: 64
	public class CaMgdFilterFactory
	{
		// Token: 0x060000A9 RID: 169
		public static extern CaMgdIFilter CreateFilter(CaMgdFilterType ft, string propertyName, List<CaMgdContentValue> values);

		// Token: 0x060000AA RID: 170
		public static extern CaMgdIFilter CreateFilter(CaMgdFilterType ft, string propertyName, CaMgdContentValue value);

		// Token: 0x060000AB RID: 171
		public extern CaMgdFilterFactory();
	}
}
