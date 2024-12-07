using System;

namespace Autodesk.Civil
{
	// Token: 0x02000036 RID: 54
	public class PropertyAnchorPoint : Property<int,int,Autodesk::Civil::CastOp<int,int>\u0020>
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000141 RID: 321
		// (set) Token: 0x06000142 RID: 322
		public new virtual extern AnchorPointType Value { get; set; }
	}
}
