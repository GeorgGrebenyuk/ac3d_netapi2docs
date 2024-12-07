using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020011B0 RID: 4528
	internal interface ILinkProxy
	{
		// Token: 0x060025D8 RID: 9688
		unsafe AeccSubassemblyLinkData* GetLinkData();

		// Token: 0x060025D9 RID: 9689
		unsafe AeccSubassemblyLinkData* GetConstLinkData();
	}
}
