using System;
using System.Collections;
using System.Collections.Generic;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000E7 RID: 231
	[Wrapper("AeccDbRoadwayStyleSet")]
	public sealed class CodeSetStyle : StyleBase, IEnumerable<CodeSetStyleItem>
	{
		// Token: 0x06000A68 RID: 2664
		public extern CodeSetStyleItem Add(string code, ObjectId styleId);

		// Token: 0x06000A69 RID: 2665
		public extern void Remove(string code);

		// Token: 0x06000A6A RID: 2666
		public extern IEnumerator<CodeSetStyleItem> GetEnumerator();

		// Token: 0x06000A6B RID: 2667
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000A6C RID: 2668
		public extern int Count { get; }

		// Token: 0x06000A6D RID: 2669
		public extern CodeSetStyleItem GetItemBy(CodeSetStyleItemType itemType, string code);

		// Token: 0x17000479 RID: 1145
		public extern CodeSetStyleItem this[int index]
		{
			get;
		}

		// Token: 0x06000A6F RID: 2671
		public static extern ObjectId GetCurrentStyleSetId();

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000A70 RID: 2672
		// (set) Token: 0x06000A71 RID: 2673
		public extern SubassemblySubentityStyleType SubentityStyleType { get; set; }

		// Token: 0x04000310 RID: 784
		private int <SyntheticNonEmptyStructMarker>;
	}
}
