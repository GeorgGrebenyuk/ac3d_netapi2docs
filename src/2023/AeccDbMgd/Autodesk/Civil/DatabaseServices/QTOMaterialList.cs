using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200083C RID: 2108
	public sealed class QTOMaterialList : IEnumerable<QTOMaterial>, IDisposable
	{
		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06000FCA RID: 4042
		public extern int Count { get; }

		// Token: 0x17000690 RID: 1680
		public extern QTOMaterial this[string name]
		{
			get;
		}

		// Token: 0x17000691 RID: 1681
		public extern QTOMaterial this[Guid guid]
		{
			get;
		}

		// Token: 0x17000692 RID: 1682
		public extern QTOMaterial this[int index]
		{
			get;
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06000FCE RID: 4046
		public extern ObjectId SampleLineGroupId { get; }

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06000FCF RID: 4047
		public extern Guid Guid { get; }

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06000FD0 RID: 4048
		// (set) Token: 0x06000FD1 RID: 4049
		public extern string Name { get; set; }

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06000FD2 RID: 4050
		// (set) Token: 0x06000FD3 RID: 4051
		public extern bool IsCurveCorrectionEnabled { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06000FD4 RID: 4052
		// (set) Token: 0x06000FD5 RID: 4053
		public extern double CurveCorrectionTolerance { get; set; }

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06000FD6 RID: 4054
		public extern QTOMaterialListGapCollection MaterialListGaps { get; }

		// Token: 0x06000FD7 RID: 4055
		public extern QTOMaterial Add(string materialName);

		// Token: 0x06000FD8 RID: 4056
		public extern void RemoveAt(int index);

		// Token: 0x06000FD9 RID: 4057
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(QTOMaterial material);

		// Token: 0x06000FDA RID: 4058
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(string name);

		// Token: 0x06000FDB RID: 4059
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(Guid guid);

		// Token: 0x06000FDC RID: 4060
		public extern IEnumerator<QTOMaterial> GetEnumerator();

		// Token: 0x06000FDD RID: 4061
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x06000FDE RID: 4062
		public sealed extern void Dispose();

		// Token: 0x04001245 RID: 4677
		private int <SyntheticNonEmptyStructMarker>;
	}
}
