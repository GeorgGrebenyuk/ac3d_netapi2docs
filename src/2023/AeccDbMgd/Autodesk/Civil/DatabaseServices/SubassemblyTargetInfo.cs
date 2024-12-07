using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000BEA RID: 3050
	public class SubassemblyTargetInfo : DisposableWrapper
	{
		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06001705 RID: 5893
		public extern string AssemblyGroupName { get; }

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06001706 RID: 5894
		public extern string SubassemblyName { get; }

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06001707 RID: 5895
		public extern string LogicalName { get; }

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06001708 RID: 5896
		public extern string DisplayName { get; }

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06001709 RID: 5897
		// (set) Token: 0x0600170A RID: 5898
		public extern ObjectIdCollection TargetIds { get; set; }

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x0600170B RID: 5899
		public extern SubassemblyLogicalNameType TargetType { get; }

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x0600170C RID: 5900
		// (set) Token: 0x0600170D RID: 5901
		public extern SubassemblyTargetToOption TargetToOption { get; set; }

		// Token: 0x0600170E RID: 5902
		protected override extern void DeleteUnmanagedObject();
	}
}
