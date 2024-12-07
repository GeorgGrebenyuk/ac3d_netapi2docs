using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200006A RID: 106
	[Wrapper("AeccDbSectionViewQuantityTakeoffTable")]
	public sealed class SectionViewQuantityTakeoffTable : Table
	{
		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600045B RID: 1115
		public extern VolumeTableType Type { get; }

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600045C RID: 1116
		// (set) Token: 0x0600045D RID: 1117
		public extern Guid MaterialListGuid { get; set; }

		// Token: 0x0600045E RID: 1118
		public extern Guid[] GetSelectedMaterials();

		// Token: 0x0600045F RID: 1119
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool AddSelectedMaterial(Guid materialGuid);

		// Token: 0x06000460 RID: 1120
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool RemoveSelectedMaterial(Guid materialGuid);
	}
}
