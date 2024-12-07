using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A3E RID: 2622
	[DefaultMember("Item")]
	public sealed class SurfaceDefinitionPointGroups : SurfaceDefinitionBase<SurfaceOperationAddPointGroup>
	{
		// Token: 0x060013CF RID: 5071
		public extern SurfaceOperationAddPointGroup AddPointGroup(ObjectId pointGroupId);
	}
}
