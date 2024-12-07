using System;

namespace Autodesk.Civil.AeccUiMgd
{
	// Token: 0x020000EC RID: 236
	public class PaletteEventArgs : EventArgs
	{
		// Token: 0x0600009A RID: 154
		public extern PaletteEventArgs(PaletteType paletteType);

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600009B RID: 155
		public extern PaletteType PalType { get; }

		// Token: 0x04000104 RID: 260
		private int <SyntheticNonEmptyStructMarker>;
	}
}
