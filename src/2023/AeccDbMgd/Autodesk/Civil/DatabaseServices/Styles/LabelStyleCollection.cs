using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000B53 RID: 2899
	[DefaultMember("Item")]
	public class LabelStyleCollection : StyleCollectionBase
	{
		// Token: 0x0600157E RID: 5502
		public override extern ObjectId Add(string name);

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x0600157F RID: 5503
		public extern LabelStyleDefault DefaultLabelStyle { get; }

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06001580 RID: 5504
		public extern ExpressionCollection Expressions { get; }

		// Token: 0x06001581 RID: 5505
		public override extern void Remove(string styleName);

		// Token: 0x06001582 RID: 5506
		public override extern void Remove(int index);

		// Token: 0x06001583 RID: 5507
		protected unsafe virtual extern AcDbObjectId* GetClassNodeId(AcDbObjectId*, int type);

		// Token: 0x040014E3 RID: 5347
		private int <SyntheticNonEmptyStructMarker>;
	}
}
