using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000192 RID: 402
	internal sealed class PressurePartCatalog : DisposableWrapper
	{
		// Token: 0x060001B7 RID: 439
		public static extern void SetCatalog(string fullPath);

		// Token: 0x060001B8 RID: 440
		public extern PressurePartType[] GetPartTypes(PressurePartDomainType domain);

		// Token: 0x060001B9 RID: 441
		public extern List<PressurePartSize> GetParts(PressurePartType type);

		// Token: 0x060001BA RID: 442
		public extern List<PressurePartSize> GetParts(PressurePartDomainType domain);

		// Token: 0x060001BB RID: 443
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool IsPartAvailable(PressurePartSize part);
	}
}
