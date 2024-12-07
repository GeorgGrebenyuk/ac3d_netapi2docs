using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000858 RID: 2136
	public class PointCloudUtility
	{
		// Token: 0x06001029 RID: 4137
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool IsCivilPointCloud(ObjectId A_0);

		// Token: 0x0600102A RID: 4138
		public static extern string GetCivilPointCloudName(ObjectId A_0);
	}
}
