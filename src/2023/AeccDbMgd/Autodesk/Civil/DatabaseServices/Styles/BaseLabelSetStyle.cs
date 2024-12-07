using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x0200008F RID: 143
	public abstract class BaseLabelSetStyle : StyleBase
	{
		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000651 RID: 1617
		public extern int Count { get; }

		// Token: 0x06000652 RID: 1618
		public extern void RemoveAt(int index);

		// Token: 0x06000653 RID: 1619
		public extern void Add(BaseLabelSetItem majorStation, string minorStationLabelStyleName);

		// Token: 0x06000654 RID: 1620
		public extern void Add(BaseLabelSetItem majorStation, ObjectId minorStationLabelStyleId);

		// Token: 0x06000655 RID: 1621
		public extern void Add(LabelStyleType labelStyleType, string labelStyleName);

		// Token: 0x06000656 RID: 1622
		public extern void Add(ObjectId labelStyleId);

		// Token: 0x06000657 RID: 1623
		protected unsafe extern void CreateLabelGroup(AcRxClass* pLabelingClassDesc, AeccDbTreeOid oidLabelStyle, AeccDbAlignStnLabelsDlgTemplate.LABEL_SET_DATA* pParent);

		// Token: 0x06000658 RID: 1624
		protected unsafe static extern AcRxClass* GetLabelingDesc(AeccAtom* labelStyleType);

		// Token: 0x06000659 RID: 1625
		protected abstract void CheckLabelStyleType(LabelStyleType type);

		// Token: 0x0600065A RID: 1626
		protected internal extern BaseLabelSetStyle(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
