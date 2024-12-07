using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000DCC RID: 3532
	public class UDPEnumeration : UDP
	{
		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06001A31 RID: 6705
		// (set) Token: 0x06001A32 RID: 6706
		public new extern string DefaultValue { get; set; }

		// Token: 0x06001A33 RID: 6707
		public extern string[] GetEnumValues();
	}
}
