using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x0200008E RID: 142
	[Wrapper("AeccDbLabelStyleCollector")]
	public sealed class LabelStyle : StyleBase
	{
		// Token: 0x0600063D RID: 1597
		public extern ObjectIdCollection GetComponents(LabelStyleComponentType type);

		// Token: 0x0600063E RID: 1598
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool IsSupportedComponent(LabelStyleComponentType type);

		// Token: 0x0600063F RID: 1599
		public extern ObjectId AddComponent(string name, LabelStyleComponentType type);

		// Token: 0x06000640 RID: 1600
		public extern ObjectId AddReferenceTextComponent(string name, ReferenceTextComponentSelectedType selectedType);

		// Token: 0x06000641 RID: 1601
		public extern ObjectId AddTextForEachComponent(string name, TextForEachComponentSelectedType selectedType);

		// Token: 0x06000642 RID: 1602
		public extern void RemoveComponent(string name);

		// Token: 0x06000643 RID: 1603
		public extern int GetComponentsCount();

		// Token: 0x06000644 RID: 1604
		public extern int GetComponentsCount(LabelStyleComponentType type);

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000645 RID: 1605
		public extern LabelStyleBase Properties { get; }

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000646 RID: 1606
		public extern ObjectId ParentLabelStyleId { get; }

		// Token: 0x1700024C RID: 588
		public extern ObjectId this[int index]
		{
			get;
		}

		// Token: 0x1700024D RID: 589
		public extern ObjectId this[string labelStyleName]
		{
			get;
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000649 RID: 1609
		public extern int ChildrenCount { get; }

		// Token: 0x0600064A RID: 1610
		public extern void RemoveChild(int index);

		// Token: 0x0600064B RID: 1611
		public extern void RemoveChild(string labelStyleName);

		// Token: 0x0600064C RID: 1612
		public extern void RemoveAllDescendants();

		// Token: 0x0600064D RID: 1613
		public extern ObjectId AddChild(string labelStyleName);

		// Token: 0x0600064E RID: 1614
		public extern void SwitchComponentsDrawOrder(int index1, int index2);

		// Token: 0x0600064F RID: 1615
		public extern void SetComponentsDrawOrder(ObjectId[] componentIds);

		// Token: 0x06000650 RID: 1616
		public extern ObjectId[] GetComponentsDrawOrder();

		// Token: 0x04000305 RID: 773
		private int <SyntheticNonEmptyStructMarker>;
	}
}
