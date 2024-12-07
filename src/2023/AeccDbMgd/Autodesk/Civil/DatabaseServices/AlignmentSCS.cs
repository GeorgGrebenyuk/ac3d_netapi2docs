using System;
using System.Reflection;
using System.Runtime.InteropServices;
using std;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000793 RID: 1939
	[DefaultMember("Item")]
	public class AlignmentSCS : AlignmentCurve
	{
		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06000F2B RID: 3883
		public extern AlignmentSCSConstraintType Constraint2 { get; }

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06000F2C RID: 3884
		// (set) Token: 0x06000F2D RID: 3885
		public extern bool GreaterThan180 { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06000F2E RID: 3886
		public extern AlignmentSubEntitySpiral SpiralIn { get; }

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06000F2F RID: 3887
		public extern AlignmentSubEntityArc Arc { get; }

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06000F30 RID: 3888
		public extern AlignmentSubEntitySpiral SpiralOut { get; }

		// Token: 0x06000F31 RID: 3889
		protected new unsafe virtual extern AeccRGSCS* InternalGetRGObject();

		// Token: 0x06000F32 RID: 3890
		protected unsafe override extern vector<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>,std::allocator<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>\u0020>\u0020>* getSubEntities(vector<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>,std::allocator<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>\u0020>\u0020>*);
	}
}
