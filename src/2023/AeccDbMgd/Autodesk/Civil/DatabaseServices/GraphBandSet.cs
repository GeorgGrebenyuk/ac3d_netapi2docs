using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.Civil.DatabaseServices.Styles;
using std;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000709 RID: 1801
	public abstract class GraphBandSet
	{
		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06000E2E RID: 3630
		// (set) Token: 0x06000E2F RID: 3631
		public extern bool MatchIncrementToGridIntervals { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x06000E30 RID: 3632
		public extern ObjectId SaveAsBandSetStyle(string name);

		// Token: 0x06000E31 RID: 3633
		public virtual extern void ImportBandSetStyle(ObjectId bandSetId);

		// Token: 0x06000E32 RID: 3634
		protected unsafe abstract BandSetItemCollection createBandItemCollection(vector<AeccDbBandStyleSetData\u0020*,std::allocator<AeccDbBandStyleSetData\u0020*>\u0020>* pBandVector, AcDbObjectId oidGraph, BandLocationType location);

		// Token: 0x06000E33 RID: 3635
		protected unsafe abstract void createC3DGraphBandLabelGroups(vector<AeccDbBandStyleSetData\u0020*,std::allocator<AeccDbBandStyleSetData\u0020*>\u0020>* pBandVector);

		// Token: 0x06000E34 RID: 3636
		protected unsafe abstract AeccDbTreeOid* getBandSetStyleRoot(AeccDbTreeOid*);

		// Token: 0x06000E35 RID: 3637
		protected unsafe abstract AeccDbGraphBandStyleSet* createNewBandStyleSetByName(AecRmCString* styleName);

		// Token: 0x06000E36 RID: 3638
		[return: MarshalAs(UnmanagedType.U1)]
		protected abstract bool checkBandStyleSet(AcDbObjectId oidBandSetStyle);

		// Token: 0x06000E37 RID: 3639
		protected unsafe abstract void updateBandItemByInterval(AeccDbBandStyleSetData* pData, double majorInterval, double minorInterval);

		// Token: 0x06000E38 RID: 3640
		protected unsafe virtual extern void updateBandStyleSetDatas(vector<AeccDbBandStyleSetData\u0020*,std::allocator<AeccDbBandStyleSetData\u0020*>\u0020>* pBandVector);

		// Token: 0x06000E39 RID: 3641
		protected extern BandSetItemCollection getTopBandItems();

		// Token: 0x06000E3A RID: 3642
		protected extern void setTopBandItems(BandSetItemCollection bandItems);

		// Token: 0x06000E3B RID: 3643
		protected extern BandSetItemCollection getBottomBandItems();

		// Token: 0x06000E3C RID: 3644
		protected extern void setBottomBandItems(BandSetItemCollection bandItems);

		// Token: 0x04001108 RID: 4360
		protected unsafe AeccDbGraph* m_pGraph;
	}
}
