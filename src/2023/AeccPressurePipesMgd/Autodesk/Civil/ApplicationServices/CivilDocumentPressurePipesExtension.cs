using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.ApplicationServices
{
	// Token: 0x020000F9 RID: 249
	public static class CivilDocumentPressurePipesExtension
	{
		// Token: 0x06000147 RID: 327
		public static extern ObjectIdCollection GetPressurePipeNetworkIds(this CivilDocument document);

		// Token: 0x06000148 RID: 328
		public static extern ObjectId GetPressureNetworkIdFromPipeRunPath(this CivilDocument document, ObjectId idPath);

		// Token: 0x06000149 RID: 329
		public static extern ObjectId GetPressureNetworkIdFromPipeRunProfile(this CivilDocument document, ObjectId idProfile);

		// Token: 0x0600014A RID: 330
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool IsPressurePlanLayoutActive(this CivilDocument document);

		// Token: 0x0600014B RID: 331
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool IsPressurePlanLayoutByPathActive(this CivilDocument document);

		// Token: 0x0600014C RID: 332
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool IsPressureProfileLayoutActive(this CivilDocument document);

		// Token: 0x0600014D RID: 333
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool IsPressureProfileLayoutByPathActive(this CivilDocument document);

		// Token: 0x0600014E RID: 334
		public static extern void SetPressurePlanLayoutActive(this CivilDocument document, [MarshalAs(UnmanagedType.U1)] bool bActive);

		// Token: 0x0600014F RID: 335
		public static extern void SetPressurePlanLayoutByPathActive(this CivilDocument document, [MarshalAs(UnmanagedType.U1)] bool bActive);

		// Token: 0x06000150 RID: 336
		public static extern void SetPressureProfileLayoutActive(this CivilDocument document, [MarshalAs(UnmanagedType.U1)] bool bActive);

		// Token: 0x06000151 RID: 337
		public static extern void SetPressureProfileLayoutByPathActive(this CivilDocument document, [MarshalAs(UnmanagedType.U1)] bool bActive);
	}
}
