using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A57 RID: 2647
	public sealed class SurfaceMaskCreationData
	{
		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x060013DC RID: 5084
		// (set) Token: 0x060013DD RID: 5085
		public extern string Name { get; set; }

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x060013DE RID: 5086
		// (set) Token: 0x060013DF RID: 5087
		public extern string Description { get; set; }

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x060013E0 RID: 5088
		// (set) Token: 0x060013E1 RID: 5089
		public extern double MidOrdinateDistance { get; set; }

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x060013E2 RID: 5090
		// (set) Token: 0x060013E3 RID: 5091
		public extern ObjectId MaterialId { get; set; }

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x060013E4 RID: 5092
		// (set) Token: 0x060013E5 RID: 5093
		public extern ObjectIdCollection Linkages { get; set; }

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x060013E6 RID: 5094
		// (set) Token: 0x060013E7 RID: 5095
		public extern SurfaceMaskType Type { get; set; }

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x060013E8 RID: 5096
		// (set) Token: 0x060013E9 RID: 5097
		public extern bool IsRenderOnly { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x060013EA RID: 5098
		// (set) Token: 0x060013EB RID: 5099
		public extern ObjectId SurfaceId { get; set; }

		// Token: 0x060013EC RID: 5100
		public extern SurfaceMaskCreationData(string name, string desc, ObjectId surfaceId, ObjectIdCollection linkages, double midOrdinateDistance, ObjectId materialId, SurfaceMaskType type, [MarshalAs(UnmanagedType.U1)] bool isRenderOnly);

		// Token: 0x060013ED RID: 5101
		public extern SurfaceMaskCreationData();

		// Token: 0x04001432 RID: 5170
		private int <SyntheticNonEmptyStructMarker>;
	}
}
