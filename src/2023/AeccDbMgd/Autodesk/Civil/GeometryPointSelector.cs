using System;

namespace Autodesk.Civil
{
	// Token: 0x0200011A RID: 282
	public class GeometryPointSelector<T> where T : Enum
	{
		// Token: 0x1700053F RID: 1343
		public extern GeometryPointLabelOption<T> this[T type]
		{
			get;
		}

		// Token: 0x06000C61 RID: 3169
		public extern void SelectAll();

		// Token: 0x06000C62 RID: 3170
		public extern void UnSelectAll();

		// Token: 0x06000C63 RID: 3171
		public extern GeometryPointSelector();

		// Token: 0x0400031D RID: 797
		private int <SyntheticNonEmptyStructMarker>;
	}
}
