using System;

namespace Autodesk.Civil
{
	// Token: 0x02000084 RID: 132
	public class AlignmentDesignCheck : DesignCheck
	{
		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000613 RID: 1555
		public extern AlignmentDesignCheckType DesignCheckType { get; }

		// Token: 0x06000614 RID: 1556
		protected unsafe override extern AcDbObjectId* GetClassNodeType(AcDbObjectId*);
	}
}
