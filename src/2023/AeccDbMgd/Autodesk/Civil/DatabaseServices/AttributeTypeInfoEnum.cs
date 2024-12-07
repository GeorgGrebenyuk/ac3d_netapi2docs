using System;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020012AD RID: 4781
	public class AttributeTypeInfoEnum : AttributeTypeInfo
	{
		// Token: 0x170015CE RID: 5582
		// (get) Token: 0x06002A0F RID: 10767
		// (set) Token: 0x06002A10 RID: 10768
		public new extern string DefaultValue { get; set; }

		// Token: 0x06002A11 RID: 10769
		public extern string[] GetEnumValues();

		// Token: 0x06002A12 RID: 10770
		public extern AttributeTypeInfoEnum(string name, IEnumerable<string> vecArray);

		// Token: 0x06002A13 RID: 10771
		protected override extern object getValidDefaultValue(object defaultValue);
	}
}
