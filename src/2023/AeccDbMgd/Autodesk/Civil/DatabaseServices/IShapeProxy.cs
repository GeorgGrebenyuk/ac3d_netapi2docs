using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020011C0 RID: 4544
	internal interface IShapeProxy
	{
		// Token: 0x0600261E RID: 9758
		unsafe AeccSubassemblyShapeData* GetShapeData();

		// Token: 0x0600261F RID: 9759
		unsafe AeccSubassemblyShapeData* GetConstShapeData();
	}
}
