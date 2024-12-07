using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A03 RID: 2563
	internal interface ISurfaceAnalysis
	{
		// Token: 0x060012FF RID: 4863
		unsafe void Initialize(AeccDbSurface.ColorValue* colorValue);

		// Token: 0x06001300 RID: 4864
		unsafe void Update(AeccDbSurface.ColorValue* colorValue);
	}
}
