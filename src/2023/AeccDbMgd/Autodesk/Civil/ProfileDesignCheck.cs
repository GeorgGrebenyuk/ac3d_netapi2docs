using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil
{
	// Token: 0x02000083 RID: 131
	[Wrapper("AeccDbVAlignmentDesignCheckSet")]
	public class ProfileDesignCheck : DesignCheck
	{
		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000611 RID: 1553
		public extern ProfileDesignCheckType DesignCheckType { get; }

		// Token: 0x06000612 RID: 1554
		protected unsafe override extern AcDbObjectId* GetClassNodeType(AcDbObjectId*);
	}
}
