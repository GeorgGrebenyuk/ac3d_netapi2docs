using System;
using System.Reflection;
using std;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000E4A RID: 3658
	[DefaultMember("Item")]
	public class AlignmentSTS : AlignmentCurve
	{
		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x06001BAA RID: 7082
		public extern AlignmentSTSConstraintType Constraint2 { get; }

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x06001BAB RID: 7083
		public extern AlignmentSubEntitySpiral SpiralIn { get; }

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x06001BAC RID: 7084
		public extern AlignmentSubEntityLine Tangent { get; }

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x06001BAD RID: 7085
		public extern AlignmentSubEntitySpiral SpiralOut { get; }

		// Token: 0x06001BAE RID: 7086
		protected new unsafe virtual extern AeccRGSTS* InternalGetRGObject();

		// Token: 0x06001BAF RID: 7087
		protected unsafe override extern vector<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>,std::allocator<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>\u0020>\u0020>* getSubEntities(vector<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>,std::allocator<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>\u0020>\u0020>*);
	}
}
