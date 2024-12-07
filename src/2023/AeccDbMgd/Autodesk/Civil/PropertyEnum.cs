using System;

namespace Autodesk.Civil
{
	// Token: 0x02000030 RID: 48
	public class PropertyEnum<T> : Property<int,int,Autodesk::Civil::CastOp<int,int>\u0020> where T : struct
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600012C RID: 300
		// (set) Token: 0x0600012D RID: 301
		public new extern T Value { get; set; }
	}
}
