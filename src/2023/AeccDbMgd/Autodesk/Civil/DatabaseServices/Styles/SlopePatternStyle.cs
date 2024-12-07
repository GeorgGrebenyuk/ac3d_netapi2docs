using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000B4 RID: 180
	[Wrapper("AeccDbSlopePatternStyle")]
	public sealed class SlopePatternStyle : StyleBase
	{
		// Token: 0x1700032C RID: 812
		public extern SlopePatternComponent this[int index]
		{
			get;
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060007D1 RID: 2001
		public extern int Count { get; }

		// Token: 0x060007D2 RID: 2002
		public extern void AddComponent(int position);

		// Token: 0x060007D3 RID: 2003
		public extern void RemoveAt(int index);

		// Token: 0x060007D4 RID: 2004
		public extern void CopyComponent(int index, int insertPosition);

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060007D5 RID: 2005
		// (set) Token: 0x060007D6 RID: 2006
		public extern double MinDisplayLength { get; set; }

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060007D7 RID: 2007
		// (set) Token: 0x060007D8 RID: 2008
		public extern double PreviewFeatureLength { get; set; }

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060007D9 RID: 2009
		// (set) Token: 0x060007DA RID: 2010
		public extern double PreviewSlopeLength { get; set; }

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060007DB RID: 2011
		// (set) Token: 0x060007DC RID: 2012
		public extern double PreviewSlope { get; set; }
	}
}
