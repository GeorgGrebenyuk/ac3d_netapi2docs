using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil
{
	// Token: 0x020012A6 RID: 4774
	public class ProjectionUtil
	{
		// Token: 0x060029EC RID: 10732
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool IsProfileProjectionObject(ObjectId projectionId, IntPtr gsMarker);

		// Token: 0x060029ED RID: 10733
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool IsSectionProjectionObject(ObjectId projectionId, IntPtr gsMarker);

		// Token: 0x060029EE RID: 10734
		public extern ProjectionUtil();
	}
}
