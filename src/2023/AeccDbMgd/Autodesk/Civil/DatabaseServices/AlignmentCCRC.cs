using System;
using System.Reflection;
using std;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000E31 RID: 3633
	[DefaultMember("Item")]
	public class AlignmentCCRC : AlignmentCurve
	{
		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x06001B5D RID: 7005
		public extern AlignmentCCRCConstraintType Constraint2 { get; }

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x06001B5E RID: 7006
		public extern AlignmentSubEntityArc Arc1 { get; }

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x06001B5F RID: 7007
		public extern AlignmentSubEntityArc Arc2 { get; }

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x06001B60 RID: 7008
		public extern AlignmentSubEntityArc Arc3 { get; }

		// Token: 0x06001B61 RID: 7009
		protected new unsafe virtual extern AeccRGCCRC* InternalGetRGObject();

		// Token: 0x06001B62 RID: 7010
		protected unsafe override extern vector<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>,std::allocator<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>\u0020>\u0020>* getSubEntities(vector<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>,std::allocator<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>\u0020>\u0020>*);
	}
}
