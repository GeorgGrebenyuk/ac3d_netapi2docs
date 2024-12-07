using System;
using System.Collections;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200012C RID: 300
	public class PressureNetworkPartData : IEnumerable<PressurePartProperty>
	{
		// Token: 0x06000158 RID: 344
		public extern uint[] GetAllPropertyIds();

		// Token: 0x06000159 RID: 345
		public extern PressurePartProperty GetProperty(uint propertyId);

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600015A RID: 346
		public extern PressurePart Parent { get; }

		// Token: 0x0600015B RID: 347
		public virtual extern IEnumerator<PressurePartProperty> GetEnumerator();

		// Token: 0x0600015C RID: 348
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x040001B1 RID: 433
		private int <SyntheticNonEmptyStructMarker>;
	}
}
