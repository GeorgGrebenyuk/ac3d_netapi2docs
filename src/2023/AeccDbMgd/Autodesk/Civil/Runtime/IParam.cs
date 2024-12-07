using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.Runtime
{
	// Token: 0x02001009 RID: 4105
	public interface IParam
	{
		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x0600206F RID: 8303
		// (set) Token: 0x06002070 RID: 8304
		ParamAccessType Access { get; set; }

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x06002071 RID: 8305
		// (set) Token: 0x06002072 RID: 8306
		string DisplayName { get; set; }

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x06002073 RID: 8307
		// (set) Token: 0x06002074 RID: 8308
		string Description { get; set; }

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x06002075 RID: 8309
		// (set) Token: 0x06002076 RID: 8310
		string Comment { get; set; }

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x06002077 RID: 8311
		// (set) Token: 0x06002078 RID: 8312
		ushort DisplayOrder { get; set; }

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x06002079 RID: 8313
		// (set) Token: 0x0600207A RID: 8314
		bool IsReadOnly { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x0600207B RID: 8315
		// (set) Token: 0x0600207C RID: 8316
		object Value { get; set; }
	}
}
