using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A33 RID: 2611
	public class SurfaceOperationAddDrawingObject : SurfaceOperation
	{
		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x060013C3 RID: 5059
		public extern string Description { get; }

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x060013C4 RID: 5060
		public extern SurfaceDrawObjectType ObjectType { get; }

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x060013C5 RID: 5061
		public extern bool MaintainEdge { [return: MarshalAs(UnmanagedType.U1)] get; }
	}
}
