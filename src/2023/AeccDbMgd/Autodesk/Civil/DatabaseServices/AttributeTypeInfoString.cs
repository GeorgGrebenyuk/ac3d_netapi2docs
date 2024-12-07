using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020012AC RID: 4780
	public class AttributeTypeInfoString : AttributeTypeInfo
	{
		// Token: 0x170015CD RID: 5581
		// (get) Token: 0x06002A0B RID: 10763
		// (set) Token: 0x06002A0C RID: 10764
		public new extern string DefaultValue { get; set; }

		// Token: 0x06002A0D RID: 10765
		public extern AttributeTypeInfoString(string name);

		// Token: 0x06002A0E RID: 10766
		protected override extern object getValidDefaultValue(object defaultValue);
	}
}
