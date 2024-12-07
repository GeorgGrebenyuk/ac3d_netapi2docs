using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000085 RID: 133
	[Wrapper("AeccDbAlignmentDesignCheckSet")]
	public class AlignmentDesignCheckSet : StyleBase
	{
		// Token: 0x06000615 RID: 1557
		public extern AlignmentDesignCheck[] GetAllDesignChecks();

		// Token: 0x06000616 RID: 1558
		public extern AlignmentDesignCheck AddDesignCheck(AlignmentDesignCheckType type, string name);

		// Token: 0x06000617 RID: 1559
		public extern void RemoveDesignCheck(AlignmentDesignCheck designCheck);

		// Token: 0x06000618 RID: 1560
		public extern void RemoveDesignCheck(AlignmentDesignCheckType type, string name);

		// Token: 0x06000619 RID: 1561
		public extern void RemoveAllDesignCheck();

		// Token: 0x0600061A RID: 1562
		protected internal extern AlignmentDesignCheckSet(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
