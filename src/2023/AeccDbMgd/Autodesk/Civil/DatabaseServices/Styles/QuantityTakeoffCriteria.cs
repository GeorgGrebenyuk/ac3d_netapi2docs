using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000BD RID: 189
	[Wrapper("AeccDbQuantityTakeoffCriteria")]
	public sealed class QuantityTakeoffCriteria : StyleBase
	{
		// Token: 0x1700035A RID: 858
		public extern QuantityTakeoffCriteriaItem this[int index]
		{
			get;
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x0600083B RID: 2107
		public extern int Count { get; }

		// Token: 0x0600083C RID: 2108
		public extern void AddMaterial(string materialName);

		// Token: 0x0600083D RID: 2109
		public extern void RemoveAt(int index);

		// Token: 0x0600083E RID: 2110
		public extern void Clear();
	}
}
