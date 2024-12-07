using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020003F5 RID: 1013
	public enum PartType
	{
		// Token: 0x04000D08 RID: 3336
		UndefinedPartType,
		// Token: 0x04000D09 RID: 3337
		Pipe = 10,
		// Token: 0x04000D0A RID: 3338
		Channel,
		// Token: 0x04000D0B RID: 3339
		Wire,
		// Token: 0x04000D0C RID: 3340
		Conduit,
		// Token: 0x04000D0D RID: 3341
		StructNull = 101,
		// Token: 0x04000D0E RID: 3342
		StructJunction,
		// Token: 0x04000D0F RID: 3343
		StructInletOutlet,
		// Token: 0x04000D10 RID: 3344
		StructGeneral,
		// Token: 0x04000D11 RID: 3345
		StructEquipment
	}
}
