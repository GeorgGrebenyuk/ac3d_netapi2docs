using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A82 RID: 2690
	public sealed class SurfaceOperationCollection
	{
		// Token: 0x17000869 RID: 2153
		public extern SurfaceOperation this[int index]
		{
			get;
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x0600142F RID: 5167
		public extern int Count { get; }

		// Token: 0x06001430 RID: 5168
		public extern void Remove(SurfaceOperation operation);

		// Token: 0x06001431 RID: 5169
		public extern void RemoveAt(int index);

		// Token: 0x06001432 RID: 5170
		public extern void Swap(SurfaceOperation firstOperation, SurfaceOperation secondOperation);

		// Token: 0x06001433 RID: 5171
		public extern void SwapAt(int firstIndex, int secondIndex);

		// Token: 0x06001434 RID: 5172
		public extern void EnableOperations(Type operationClassType);

		// Token: 0x06001435 RID: 5173
		public extern void DisableOperations(Type operationClassType);

		// Token: 0x06001436 RID: 5174
		public extern SurfaceOpeartionStatusType GetOperationStatus(Type operationClassType);

		// Token: 0x04001452 RID: 5202
		private int <SyntheticNonEmptyStructMarker>;
	}
}
