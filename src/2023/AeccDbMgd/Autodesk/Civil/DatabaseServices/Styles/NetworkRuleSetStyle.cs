using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000D4 RID: 212
	[Wrapper("AeccDbNetworkPartRules")]
	public class NetworkRuleSetStyle : StyleBase
	{
		// Token: 0x060009D1 RID: 2513
		public extern ObjectIdCollection GetRuleIds();

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x060009D2 RID: 2514
		public extern int RulesCount { get; }

		// Token: 0x060009D3 RID: 2515
		public extern void CloneAndAddRule(ObjectId sourceRuleId);

		// Token: 0x060009D4 RID: 2516
		public extern void RemoveRule(ObjectId ruleId);

		// Token: 0x060009D5 RID: 2517
		public extern void RemoveAllRules();

		// Token: 0x060009D6 RID: 2518
		protected internal extern NetworkRuleSetStyle(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
