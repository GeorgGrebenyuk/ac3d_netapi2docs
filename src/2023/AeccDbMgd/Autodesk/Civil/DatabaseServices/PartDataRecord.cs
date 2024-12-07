using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200102B RID: 4139
	public sealed class PartDataRecord : IDisposable
	{
		// Token: 0x060020EB RID: 8427
		public extern PartDataField[] GetAllDataFields();

		// Token: 0x060020EC RID: 8428
		public extern PartDataField GetDataFieldBy(string name);

		// Token: 0x060020ED RID: 8429
		public extern PartDataField GetDataFieldBy(PartContextType context);

		// Token: 0x060020EE RID: 8430
		public extern PartDataField GetDataFieldBy(PartContextType context, int index);

		// Token: 0x060020EF RID: 8431
		public extern PartContextType[] GetSupportedContexts();

		// Token: 0x060020F0 RID: 8432
		public extern int GetMaxIndex(PartContextType context);

		// Token: 0x060020F1 RID: 8433
		public sealed extern void Dispose();

		// Token: 0x04001920 RID: 6432
		private int <SyntheticNonEmptyStructMarker>;
	}
}
