using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil
{
	// Token: 0x02000033 RID: 51
	public class PropertyFeatureLineStylePriority : Property<Autodesk::AutoCAD::DatabaseServices::ObjectIdCollection\u0020^,std::vector<AeccAttribute,std::allocator<AeccAttribute>\u0020>,Autodesk::Civil::CastOp<Autodesk::AutoCAD::DatabaseServices::ObjectIdCollection\u0020^,std::vector<AeccAttribute,std::allocator<AeccAttribute>\u0020>\u0020>\u0020>
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600013B RID: 315
		// (set) Token: 0x0600013C RID: 316
		public new virtual extern ObjectIdCollection Value { get; set; }
	}
}
