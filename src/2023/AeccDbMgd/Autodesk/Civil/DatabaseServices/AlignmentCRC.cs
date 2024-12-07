using System;
using System.Reflection;
using std;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000E38 RID: 3640
	[DefaultMember("Item")]
	public class AlignmentCRC : AlignmentCurve
	{
		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x06001B63 RID: 7011
		public extern AlignmentCRCConstraintType Constraint2 { get; }

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x06001B64 RID: 7012
		public extern AlignmentSubEntityArc Arc1 { get; }

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x06001B65 RID: 7013
		public extern AlignmentSubEntityArc Arc2 { get; }

		// Token: 0x06001B66 RID: 7014
		protected new unsafe virtual extern AeccRGCRevC* InternalGetRGObject();

		// Token: 0x06001B67 RID: 7015
		protected unsafe override extern vector<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>,std::allocator<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>\u0020>\u0020>* getSubEntities(vector<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>,std::allocator<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>\u0020>\u0020>*);
	}
}
