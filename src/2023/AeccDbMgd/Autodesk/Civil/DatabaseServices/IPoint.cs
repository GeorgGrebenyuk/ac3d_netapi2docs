using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000B75 RID: 2933
	public interface IPoint
	{
		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x060015D9 RID: 5593
		CodeCollection Codes { get; }

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x060015DA RID: 5594
		// (set) Token: 0x060015DB RID: 5595
		double Station { get; set; }

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x060015DC RID: 5596
		// (set) Token: 0x060015DD RID: 5597
		double Offset { get; set; }

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x060015DE RID: 5598
		// (set) Token: 0x060015DF RID: 5599
		double Elevation { get; set; }

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x060015E0 RID: 5600
		int Index { get; }
	}
}
