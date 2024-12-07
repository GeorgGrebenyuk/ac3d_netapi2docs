using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000BC7 RID: 3015
	internal sealed class RoadwayStateData : IDisposable
	{
		// Token: 0x060016CA RID: 5834
		public unsafe extern RoadwayStateData(AeccDbCorridor* pCorridor, uint nBaselineIndex, double* station);

		// Token: 0x060016CB RID: 5835
		public unsafe extern AeccSubassemblyData* GetSubassemblyData(AcDbObjectId* oidSubassembly);

		// Token: 0x060016CC RID: 5836
		public unsafe extern int GetSubassemblyPointCount(AcDbObjectId* oidSubassembly);

		// Token: 0x060016CD RID: 5837
		public unsafe extern int GetSubassemblyLinkCount(AcDbObjectId* oidSubassembly);

		// Token: 0x060016CE RID: 5838
		public unsafe extern int GetSubassemblyShapeCount(AcDbObjectId* oidSubassembly);

		// Token: 0x060016CF RID: 5839
		public unsafe extern AeccSubassemblyPointData* GetSubassemblyPointData(AcDbObjectId* oidSubassembly, int subEntityIndex);

		// Token: 0x060016D0 RID: 5840
		public unsafe extern AeccSubassemblyLinkData* GetSubassemblyLinkData(AcDbObjectId* oidSubassembly, int subEntityIndex);

		// Token: 0x060016D1 RID: 5841
		public unsafe extern AeccSubassemblyShapeData* GetSubassemblyShapeData(AcDbObjectId* oidSubassembly, int subEntityIndex);

		// Token: 0x060016D2 RID: 5842
		public unsafe extern void GetSubassemblyPointInfo(AcDbObjectId* oidSubassembly, int subEntityIndex, AeccSubassemblyPointData* info);

		// Token: 0x060016D3 RID: 5843
		public unsafe extern void GetSubassemblyLinkInfo(AcDbObjectId* oidSubassembly, int subEntityIndex, AeccSubassemblyLinkData* info);

		// Token: 0x060016D4 RID: 5844
		public unsafe extern void GetSubassemblyShapeInfo(AcDbObjectId* oidSubassembly, int subEntityIndex, AeccSubassemblyShapeData* info);

		// Token: 0x060016D5 RID: 5845
		public unsafe extern void BuildTransform(AcDbObjectId* oidSubassembly, AcGeMatrix3d* matTransform, [MarshalAs(UnmanagedType.U1)] bool isHardcodedOffset);

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x060016D6 RID: 5846
		public extern uint AssemblyIndex { get; }

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x060016D7 RID: 5847
		public unsafe extern AeccAssemblyData* AssemblyData { get; }

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x060016D8 RID: 5848
		public extern ObjectId[] AppliedSubassembliesIds { get; }

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x060016D9 RID: 5849
		public unsafe extern RoadwayStateDataNativeCache* RoadwayStateDataCache { get; }

		// Token: 0x060016DA RID: 5850
		public unsafe extern AcDbObjectId* GetAcDbObjectAt(AcDbObjectId*, int index);

		// Token: 0x060016DB RID: 5851
		public unsafe extern uint AddPoint(AcDbObjectId* oidSubassembly, uint linkIndex, AecRmCString* codeName);

		// Token: 0x060016DC RID: 5852
		public unsafe extern void RemovePoint(AcDbObjectId* oidSubassembly, uint pointIndex);

		// Token: 0x060016DD RID: 5853
		public unsafe extern void AddCodeToPoint(AcDbObjectId* oidSubassembly, uint pointIndex, AecRmCString* codeName);

		// Token: 0x060016DE RID: 5854
		public unsafe extern uint AddLink(AcDbObjectId* oidSubassembly, uint pointIndex1, uint pointIndex2, AecRmCString* codeName);

		// Token: 0x060016DF RID: 5855
		public unsafe extern void RemoveLink(AcDbObjectId* oidSubassembly, uint linkIndex);

		// Token: 0x060016E0 RID: 5856
		public unsafe extern void AddCodeToLink(AcDbObjectId* oidSubassembly, uint linkIndex, AecRmCString* codeName);

		// Token: 0x060016E1 RID: 5857
		public sealed extern void Dispose();

		// Token: 0x0400154E RID: 5454
		private int <SyntheticNonEmptyStructMarker>;
	}
}
