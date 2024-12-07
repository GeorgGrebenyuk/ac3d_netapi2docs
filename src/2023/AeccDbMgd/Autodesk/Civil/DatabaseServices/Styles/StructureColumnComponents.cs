using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02001267 RID: 4711
	public sealed class StructureColumnComponents : CivilWrapper<tableCellComponentVec>
	{
		// Token: 0x17001507 RID: 5383
		public extern StructureColumnComponentData this[int index]
		{
			get;
		}

		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x060028F7 RID: 10487
		public extern int Count { get; }

		// Token: 0x060028F8 RID: 10488
		public extern void AddComponent(string name, StructureColumnComponentType componentType);

		// Token: 0x060028F9 RID: 10489
		public extern void RemoveAt(string name);

		// Token: 0x060028FA RID: 10490
		public extern void RemoveAt(int index);

		// Token: 0x060028FB RID: 10491
		public extern void Clear();

		// Token: 0x060028FC RID: 10492
		public extern void SwitchComponentsOrder(int index1, int index2);
	}
}
