using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000FF0 RID: 4080
	public sealed class NetworkCatalogDef
	{
		// Token: 0x0600206C RID: 8300
		public static extern void DeclareNewParameter(string globalContext, string displayContext, string paramName, string paramDesc, PartCatalogDataType dataType, PartParamUsageType usage, string defaultUnits, [MarshalAs(UnmanagedType.U1)] bool singleton, [MarshalAs(UnmanagedType.U1)] bool catManagedList);

		// Token: 0x0600206D RID: 8301
		public static extern void DeclarePartProperty(string globalContext, DomainType domain, PartType partType);
	}
}
