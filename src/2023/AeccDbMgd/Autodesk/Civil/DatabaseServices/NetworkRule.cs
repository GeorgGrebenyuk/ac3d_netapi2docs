using System;
using Autodesk.AutoCAD.Runtime;
using Autodesk.Civil.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000D7 RID: 215
	[Wrapper("AeccDbNetworkRule")]
	public sealed class NetworkRule : DBObject
	{
		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x060009D7 RID: 2519
		public extern ParamLongCollection ParamsLong { get; }

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x060009D8 RID: 2520
		public extern ParamDoubleCollection ParamsDouble { get; }

		// Token: 0x0400030A RID: 778
		private int <SyntheticNonEmptyStructMarker>;
	}
}
