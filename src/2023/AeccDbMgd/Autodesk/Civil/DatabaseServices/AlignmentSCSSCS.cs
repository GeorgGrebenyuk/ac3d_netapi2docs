using System;
using System.Reflection;
using std;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000E4D RID: 3661
	[DefaultMember("Item")]
	public class AlignmentSCSSCS : AlignmentCurve
	{
		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x06001BC2 RID: 7106
		public extern AlignmentSCSSCSConstraintType Constraint2 { get; }

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x06001BC3 RID: 7107
		public extern AlignmentSubEntitySpiral Spiral1 { get; }

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x06001BC4 RID: 7108
		public extern AlignmentSubEntityArc Arc1 { get; }

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x06001BC5 RID: 7109
		public extern AlignmentSubEntitySpiral Spiral2 { get; }

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x06001BC6 RID: 7110
		public extern AlignmentSubEntitySpiral Spiral3 { get; }

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x06001BC7 RID: 7111
		public extern AlignmentSubEntityArc Arc2 { get; }

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x06001BC8 RID: 7112
		public extern AlignmentSubEntitySpiral Spiral4 { get; }

		// Token: 0x06001BC9 RID: 7113
		protected new unsafe virtual extern AeccGeSCSSCS* InternalGetRGObject();

		// Token: 0x06001BCA RID: 7114
		protected unsafe override extern vector<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>,std::allocator<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>\u0020>\u0020>* getSubEntities(vector<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>,std::allocator<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>\u0020>\u0020>*);
	}
}
