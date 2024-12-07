using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200083F RID: 2111
	public sealed class QTOMaterialListCollection : IEnumerable<QTOMaterialList>
	{
		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06000FE4 RID: 4068
		public extern int Count { get; }

		// Token: 0x17000697 RID: 1687
		public extern QTOMaterialList this[string name]
		{
			get;
		}

		// Token: 0x17000698 RID: 1688
		public extern QTOMaterialList this[Guid guid]
		{
			get;
		}

		// Token: 0x17000699 RID: 1689
		public extern QTOMaterialList this[int index]
		{
			get;
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06000FE8 RID: 4072
		// (set) Token: 0x06000FE9 RID: 4073
		public extern MaterialVolumeCalculationMethodType VolumeCalculationMethodType { get; set; }

		// Token: 0x06000FEA RID: 4074
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Validate(MaterialVolumeCalculationMethodType methodType);

		// Token: 0x06000FEB RID: 4075
		public extern void Fix(MaterialVolumeCalculationMethodType methodType);

		// Token: 0x06000FEC RID: 4076
		public extern QTOMaterialList Add(string materialListName);

		// Token: 0x06000FED RID: 4077
		public extern QTOMaterialList ImportCriteria(QTOCriteriaNameMapping criteriaNameMapping);

		// Token: 0x06000FEE RID: 4078
		public extern void RemoveAt(int index);

		// Token: 0x06000FEF RID: 4079
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(QTOMaterialList materialList);

		// Token: 0x06000FF0 RID: 4080
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(string name);

		// Token: 0x06000FF1 RID: 4081
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(Guid guid);

		// Token: 0x06000FF2 RID: 4082
		public extern IEnumerator<QTOMaterialList> GetEnumerator();

		// Token: 0x06000FF3 RID: 4083
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x04001248 RID: 4680
		private int <SyntheticNonEmptyStructMarker>;
	}
}
