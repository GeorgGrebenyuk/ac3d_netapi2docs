using System;
using System.Reflection;
using System.Runtime.InteropServices;
using std;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000E4B RID: 3659
	[DefaultMember("Item")]
	public class AlignmentSSCSS : AlignmentCurve
	{
		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x06001BB0 RID: 7088
		public extern AlignmentSSCSSConstraintType Constraint2 { get; }

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x06001BB1 RID: 7089
		// (set) Token: 0x06001BB2 RID: 7090
		public extern bool GreaterThan180 { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x06001BB3 RID: 7091
		public extern AlignmentSubEntitySpiral Spiral1 { get; }

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x06001BB4 RID: 7092
		public extern AlignmentSubEntitySpiral Spiral2 { get; }

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x06001BB5 RID: 7093
		public extern AlignmentSubEntityArc Arc { get; }

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x06001BB6 RID: 7094
		public extern AlignmentSubEntitySpiral Spiral3 { get; }

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x06001BB7 RID: 7095
		public extern AlignmentSubEntitySpiral Spiral4 { get; }

		// Token: 0x06001BB8 RID: 7096
		protected new unsafe virtual extern AeccRGSSCSS* InternalGetRGObject();

		// Token: 0x06001BB9 RID: 7097
		protected unsafe override extern vector<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>,std::allocator<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>\u0020>\u0020>* getSubEntities(vector<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>,std::allocator<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>\u0020>\u0020>*);
	}
}
