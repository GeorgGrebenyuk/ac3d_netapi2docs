using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;

namespace Autodesk.Civil.AeccUiMgd.Roadway
{
	// Token: 0x020000D8 RID: 216
	public class PrompSelectNewRehabRegions : IDisposable
	{
		// Token: 0x0600008E RID: 142
		public extern PrompSelectNewRehabRegions(string prompStr);

		// Token: 0x0600008F RID: 143
		public extern PromptStatus PrompSelectRegion();

		// Token: 0x06000090 RID: 144
		public extern ObjectId GetSeletedCorridor();

		// Token: 0x06000091 RID: 145
		public extern int GetSeletedBaselineIndex();

		// Token: 0x06000092 RID: 146
		public extern int GetSeletedRegionIndex();

		// Token: 0x06000093 RID: 147
		public extern string GetSeletedOffsetName();

		// Token: 0x06000094 RID: 148
		[HandleProcessCorruptedStateExceptions]
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x06000095 RID: 149
		public sealed extern void Dispose();

		// Token: 0x06000096 RID: 150
		protected override extern void Finalize();

		// Token: 0x040000F5 RID: 245
		private int <SyntheticNonEmptyStructMarker>;
	}
}
