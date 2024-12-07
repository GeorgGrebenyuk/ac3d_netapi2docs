using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil
{
	// Token: 0x020011FB RID: 4603
	public sealed class SurveyProject : DisposableWrapper
	{
		// Token: 0x170013DE RID: 5086
		// (get) Token: 0x060026E0 RID: 9952
		public extern string ProjectName { get; }

		// Token: 0x170013DD RID: 5085
		// (get) Token: 0x060026E1 RID: 9953
		public extern Guid ProjectGUID { get; }

		// Token: 0x060026E2 RID: 9954
		public extern void Open([MarshalAs(UnmanagedType.U1)] bool openMode);

		// Token: 0x060026E3 RID: 9955
		public extern void Close();

		// Token: 0x060026E4 RID: 9956
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool IsOpen();

		// Token: 0x060026E5 RID: 9957
		public extern SurveyQueryCollection GetSurveyQueryCollection();
	}
}
