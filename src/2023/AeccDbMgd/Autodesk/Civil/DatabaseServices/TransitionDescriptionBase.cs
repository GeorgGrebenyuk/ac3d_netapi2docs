using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000E67 RID: 3687
	public abstract class TransitionDescriptionBase : CivilWrapper<AeccDbAlignment>
	{
		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06001C06 RID: 7174
		// (set) Token: 0x06001C07 RID: 7175
		public extern double EndStation { get; set; }

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06001C08 RID: 7176
		// (set) Token: 0x06001C09 RID: 7177
		public extern double Length { get; set; }

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06001C0A RID: 7178
		// (set) Token: 0x06001C0B RID: 7179
		public extern double StartStation { get; set; }

		// Token: 0x06001C0C RID: 7180
		[HandleProcessCorruptedStateExceptions]
		protected override extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x0400174D RID: 5965
		protected unsafe AeccUserParam* m_pTransitionParam;
	}
}
