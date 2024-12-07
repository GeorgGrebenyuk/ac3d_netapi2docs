using System;
using System.Reflection;
using std;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000E4C RID: 3660
	[DefaultMember("Item")]
	public class AlignmentSCSCS : AlignmentCurve
	{
		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x06001BBA RID: 7098
		public extern AlignmentSCSCSConstraintType Constraint2 { get; }

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x06001BBB RID: 7099
		public extern AlignmentSubEntitySpiral Spiral1 { get; }

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x06001BBC RID: 7100
		public extern AlignmentSubEntityArc Arc1 { get; }

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x06001BBD RID: 7101
		public extern AlignmentSubEntitySpiral Spiral2 { get; }

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x06001BBE RID: 7102
		public extern AlignmentSubEntityArc Arc2 { get; }

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x06001BBF RID: 7103
		public extern AlignmentSubEntitySpiral Spiral3 { get; }

		// Token: 0x06001BC0 RID: 7104
		protected new unsafe virtual extern AeccGeSCSCS* InternalGetRGObject();

		// Token: 0x06001BC1 RID: 7105
		protected unsafe override extern vector<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>,std::allocator<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>\u0020>\u0020>* getSubEntities(vector<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>,std::allocator<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>\u0020>\u0020>*);
	}
}
