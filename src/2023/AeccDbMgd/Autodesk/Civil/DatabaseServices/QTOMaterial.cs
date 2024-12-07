using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000822 RID: 2082
	public sealed class QTOMaterial : IEnumerable<QTOMaterialItem>, IDisposable
	{
		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06000F7E RID: 3966
		public extern ObjectId SampleLineGroupId { get; }

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06000F7F RID: 3967
		public extern Guid MaterialListGuid { get; }

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06000F80 RID: 3968
		public extern Guid Guid { get; }

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06000F81 RID: 3969
		// (set) Token: 0x06000F82 RID: 3970
		public extern string Name { get; set; }

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06000F83 RID: 3971
		// (set) Token: 0x06000F84 RID: 3972
		public extern MaterialQuantityType QuantityType { get; set; }

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06000F85 RID: 3973
		// (set) Token: 0x06000F86 RID: 3974
		public extern ObjectId ShapeStyleId { get; set; }

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06000F87 RID: 3975
		public extern bool IsSubcriteriaSupported { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06000F88 RID: 3976
		public extern QTOSubcriteriaCollection Subcriteria { get; }

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06000F89 RID: 3977
		public extern QTOMaterialGapCollection MaterialGaps { get; }

		// Token: 0x06000F8A RID: 3978
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool IsFactorApplicable(MaterialFactorType type);

		// Token: 0x06000F8B RID: 3979
		public extern double GetFactor(MaterialFactorType type);

		// Token: 0x06000F8C RID: 3980
		public extern void SetFactor(MaterialFactorType type, double newValue);

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06000F8D RID: 3981
		public extern int Count { get; }

		// Token: 0x17000668 RID: 1640
		public extern QTOMaterialItem this[string name]
		{
			get;
		}

		// Token: 0x17000669 RID: 1641
		public extern QTOMaterialItem this[int index]
		{
			get;
		}

		// Token: 0x06000F90 RID: 3984
		public extern QTOMaterialItem Add(ObjectId corridorId, string shapeCode);

		// Token: 0x06000F91 RID: 3985
		public extern QTOMaterialItem Add(ObjectId surfaceId);

		// Token: 0x06000F92 RID: 3986
		public extern void RemoveAt(int index);

		// Token: 0x06000F93 RID: 3987
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(QTOMaterialItem materialItem);

		// Token: 0x06000F94 RID: 3988
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(string name);

		// Token: 0x06000F95 RID: 3989
		public extern IEnumerator<QTOMaterialItem> GetEnumerator();

		// Token: 0x06000F96 RID: 3990
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x06000F97 RID: 3991
		public sealed extern void Dispose();

		// Token: 0x04001229 RID: 4649
		private int <SyntheticNonEmptyStructMarker>;
	}
}
