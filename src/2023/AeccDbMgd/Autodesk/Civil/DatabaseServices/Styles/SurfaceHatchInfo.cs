using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000985 RID: 2437
	public class SurfaceHatchInfo
	{
		// Token: 0x06001273 RID: 4723
		public extern void SetHatchPattern(HatchPatternType patternType, string patternName);

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06001274 RID: 4724
		public extern HatchPatternType PatternType { get; }

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06001275 RID: 4725
		public extern string PatternName { get; }

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06001276 RID: 4726
		// (set) Token: 0x06001277 RID: 4727
		public extern double PatternScale { get; set; }

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06001278 RID: 4728
		public extern bool PatternScaleType { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06001279 RID: 4729
		// (set) Token: 0x0600127A RID: 4730
		public extern double PatternAngle { get; set; }

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x0600127B RID: 4731
		// (set) Token: 0x0600127C RID: 4732
		public extern double PatternSpace { get; set; }

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x0600127D RID: 4733
		// (set) Token: 0x0600127E RID: 4734
		public extern bool PatternDouble { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x04001386 RID: 4998
		private int <SyntheticNonEmptyStructMarker>;
	}
}
