using System;
using System.Reflection;
using std;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000E3C RID: 3644
	[DefaultMember("Item")]
	public class AlignmentCTC : AlignmentCurve
	{
		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x06001B68 RID: 7016
		public extern AlignmentCTCConstraintType Constraint2 { get; }

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x06001B69 RID: 7017
		public extern AlignmentSubEntityArc Arc1 { get; }

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x06001B6A RID: 7018
		public extern AlignmentSubEntityLine Tangent { get; }

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x06001B6B RID: 7019
		public extern AlignmentSubEntityArc Arc2 { get; }

		// Token: 0x06001B6C RID: 7020
		protected new unsafe virtual extern AeccRGCTC* InternalGetRGObject();

		// Token: 0x06001B6D RID: 7021
		protected unsafe override extern vector<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>,std::allocator<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>\u0020>\u0020>* getSubEntities(vector<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>,std::allocator<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>\u0020>\u0020>*);
	}
}
