using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Runtime;
using std;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020011DA RID: 4570
	[Wrapper("SampleSectionLinkDataVector")]
	public sealed class SampledSectionLinkCollection : CivilWrapper<std::vector<Autodesk::Civil::DatabaseServices::SampleSectionLinkData\u0020*,std::allocator<Autodesk::Civil::DatabaseServices::SampleSectionLinkData\u0020*>\u0020>\u0020>, IEnumerable<SampledSectionLink>
	{
		// Token: 0x170013C4 RID: 5060
		public extern SampledSectionLink this[int index]
		{
			get;
		}

		// Token: 0x06002697 RID: 9879
		public extern IEnumerator<SampledSectionLink> GetEnumerator();

		// Token: 0x06002698 RID: 9880
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x020011DB RID: 4571
		private class SampledSectionLinkEnumerator : IEnumerator<SampledSectionLink>
		{
			// Token: 0x06002699 RID: 9881
			public unsafe extern SampledSectionLinkEnumerator(vector<Autodesk::Civil::DatabaseServices::SampleSectionLinkData\u0020*,std::allocator<Autodesk::Civil::DatabaseServices::SampleSectionLinkData\u0020*>\u0020>* pVector);

			// Token: 0x170013C6 RID: 5062
			// (get) Token: 0x0600269A RID: 9882
			public virtual extern object CurrentObject { get; }

			// Token: 0x170013C5 RID: 5061
			// (get) Token: 0x0600269B RID: 9883
			public virtual extern SampledSectionLink Current { get; }

			// Token: 0x0600269C RID: 9884
			[return: MarshalAs(UnmanagedType.U1)]
			public virtual extern bool MoveNext();

			// Token: 0x0600269D RID: 9885
			public virtual extern void Reset();

			// Token: 0x0600269E RID: 9886
			protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

			// Token: 0x0600269F RID: 9887
			public sealed extern void Dispose();

			// Token: 0x04001B1C RID: 6940
			private int <SyntheticNonEmptyStructMarker>;
		}
	}
}
