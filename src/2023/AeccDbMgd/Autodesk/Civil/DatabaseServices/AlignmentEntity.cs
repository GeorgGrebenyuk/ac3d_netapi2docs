using System;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using AeccHAlignment;
using Autodesk.AutoCAD.Runtime;
using std;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000F2 RID: 242
	public abstract class AlignmentEntity : DisposableWrapper
	{
		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000B34 RID: 2868
		public extern int EntityBefore { get; }

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000B35 RID: 2869
		public extern int EntityAfter { get; }

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000B36 RID: 2870
		public virtual extern int SubEntityCount { get; }

		// Token: 0x170004DC RID: 1244
		public virtual extern AlignmentSubEntity this[int index]
		{
			get;
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000B38 RID: 2872
		public virtual extern AlignmentEntityType EntityType { get; }

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000B39 RID: 2873
		public extern AlignmentEntityConstraintType Constraint1 { get; }

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000B3A RID: 2874
		public extern int EntityId { get; }

		// Token: 0x06000B3B RID: 2875
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool ValidateDesignCheck(AlignmentDesignCheck designCheck);

		// Token: 0x06000B3C RID: 2876
		public extern Collection<AlignmentDesignCheck> DesignChecks();

		// Token: 0x06000B3D RID: 2877
		[return: MarshalAs(UnmanagedType.U1)]
		public override extern bool Equals(object obj);

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000B3E RID: 2878
		protected extern int InternalConstraint2 { get; }

		// Token: 0x06000B3F RID: 2879
		protected unsafe virtual extern AeccRGObject* InternalGetRGObject();

		// Token: 0x06000B40 RID: 2880
		protected virtual extern kHintSubEntityType getSubEntityType(int index);

		// Token: 0x06000B41 RID: 2881
		protected unsafe virtual extern vector<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>,std::allocator<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>\u0020>\u0020>* getSubEntities(vector<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>,std::allocator<std::pair<AeccGeCurveBase\u0020const\u0020*,enum\u0020AeccHAlignment::kHintSubEntityType>\u0020>\u0020>*);

		// Token: 0x06000B42 RID: 2882
		protected unsafe extern void InternalCheckRGObjectSubEntity(AeccGeCurveBase* pRGObj);

		// Token: 0x06000B43 RID: 2883
		protected extern AlignmentSubEntity CreateAlignmentSubEntity(kHintSubEntityType subEntityType);

		// Token: 0x06000B44 RID: 2884
		protected override extern void DeleteUnmanagedObject();

		// Token: 0x04000319 RID: 793
		private int <SyntheticNonEmptyStructMarker>;
	}
}
