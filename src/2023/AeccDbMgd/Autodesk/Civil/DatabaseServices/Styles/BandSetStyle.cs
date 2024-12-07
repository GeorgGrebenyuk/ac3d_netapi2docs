using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Runtime;
using std;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000096 RID: 150
	[Wrapper("AeccDbGraphBandStyleSet")]
	public class BandSetStyle : StyleBase
	{
		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000697 RID: 1687
		// (set) Token: 0x06000698 RID: 1688
		public extern bool MatchIncrementToGridIntervals { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x06000699 RID: 1689
		protected internal extern BandSetStyle(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);

		// Token: 0x0600069A RID: 1690
		protected extern void setTopBandSetItems(BandSetItemCollection bandSetItems);

		// Token: 0x0600069B RID: 1691
		protected extern void setBottomBandSetItems(BandSetItemCollection bandSetItems);

		// Token: 0x0600069C RID: 1692
		protected unsafe extern vector<AeccDbBandStyleSetData\u0020*,std::allocator<AeccDbBandStyleSetData\u0020*>\u0020>* getBottomBandSet();

		// Token: 0x0600069D RID: 1693
		protected unsafe extern vector<AeccDbBandStyleSetData\u0020*,std::allocator<AeccDbBandStyleSetData\u0020*>\u0020>* getTopBandSet();
	}
}
