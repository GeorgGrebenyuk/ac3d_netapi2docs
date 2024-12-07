using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000B8F RID: 2959
	internal abstract class AppliedSubassemblyParamTrait<T> : IAppliedSubassemblyParamTrait, IDisposable
	{
		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x0600161F RID: 5663
		public extern string KeyName { get; }

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06001620 RID: 5664
		public extern string DisplayName { get; }

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06001621 RID: 5665
		// (set) Token: 0x06001622 RID: 5666
		public extern string Comment { get; set; }

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06001623 RID: 5667
		public extern bool IsOverriden { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06001624 RID: 5668
		public extern Type ValueType { get; }

		// Token: 0x06001625 RID: 5669
		public extern T GetDesignValue();

		// Token: 0x06001626 RID: 5670
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool ClearOverride();

		// Token: 0x06001627 RID: 5671
		public extern T GetValue();

		// Token: 0x06001628 RID: 5672
		public extern void SetValue(T newValue);

		// Token: 0x06001629 RID: 5673
		public virtual extern IAppliedSubassemblyParam MakeParamInterface();

		// Token: 0x0600162A RID: 5674
		protected unsafe extern AeccCivilScriptParam* getParamForWrite();

		// Token: 0x0600162B RID: 5675
		protected unsafe extern AeccCivilScriptParam* getParamForRead();

		// Token: 0x0600162C RID: 5676
		protected unsafe extern AeccCivilScriptParam* getReadonlyParamForValue([MarshalAs(UnmanagedType.U1)] bool bDesignValue);

		// Token: 0x0600162D RID: 5677
		protected abstract AeccParamType getParamType();

		// Token: 0x0600162E RID: 5678
		protected unsafe abstract T getValue(AeccCivilScriptParam* pParam, [MarshalAs(UnmanagedType.U1)] bool bGetDefaultValue);

		// Token: 0x0600162F RID: 5679
		[return: MarshalAs(UnmanagedType.U1)]
		protected unsafe abstract bool setValue(AeccCivilScriptParam* pParam, T newValue);

		// Token: 0x06001630 RID: 5680
		protected virtual extern void validate(T newValue);

		// Token: 0x06001631 RID: 5681
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x06001632 RID: 5682
		public sealed extern void Dispose();

		// Token: 0x06001633 RID: 5683
		protected override extern void Finalize();

		// Token: 0x04001519 RID: 5401
		private int <SyntheticNonEmptyStructMarker>;
	}
}
