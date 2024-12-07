using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000955 RID: 2389
	public sealed class SectionViewProfileGradePointCollection : IEnumerable<SectionViewProfileGradePoint>
	{
		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06001227 RID: 4647
		public extern int Count { get; }

		// Token: 0x17000778 RID: 1912
		public extern SectionViewProfileGradePoint this[int index]
		{
			get;
		}

		// Token: 0x06001229 RID: 4649
		public extern SectionViewProfileGradePoint Add(ObjectId alignmentId);

		// Token: 0x0600122A RID: 4650
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(SectionViewProfileGradePoint pgPoint);

		// Token: 0x0600122B RID: 4651
		public extern void RemoveAt(int index);

		// Token: 0x0600122C RID: 4652
		public extern IEnumerator<SectionViewProfileGradePoint> GetEnumerator();

		// Token: 0x0600122D RID: 4653
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x04001352 RID: 4946
		private int <SyntheticNonEmptyStructMarker>;
	}
}
