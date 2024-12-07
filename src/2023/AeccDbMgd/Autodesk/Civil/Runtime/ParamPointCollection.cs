using System;
using System.Reflection;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.Runtime
{
	// Token: 0x02001224 RID: 4644
	[DefaultMember("Item")]
	public sealed class ParamPointCollection : ParamCollectionBase<Autodesk::Civil::Runtime::ParamPoint,Autodesk::Civil::Runtime::ParamPoint\u0020^>
	{
		// Token: 0x060027C1 RID: 10177
		public extern ParamPoint Add(string name);

		// Token: 0x060027C2 RID: 10178
		public extern ParamPoint Add(string name, Point3d value);
	}
}
