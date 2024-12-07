using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil
{
	// Token: 0x02000010 RID: 16
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
	[ComVisible(true)]
	[Serializable]
	public sealed class DeprecatedVersionAttribute : Attribute
	{
		// Token: 0x06000004 RID: 4
		public extern DeprecatedVersionAttribute(CivilVersion version);

		// Token: 0x06000005 RID: 5
		public extern DeprecatedVersionAttribute();

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6
		// (set) Token: 0x06000007 RID: 7
		public extern CivilVersion Version { get; set; }

		// Token: 0x040002D8 RID: 728
		private int <SyntheticNonEmptyStructMarker>;
	}
}
