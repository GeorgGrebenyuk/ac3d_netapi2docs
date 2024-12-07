using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02001207 RID: 4615
	[DefaultMember("Item")]
	public sealed class SurveyNetworkStyleCollection : StyleCollectionBase
	{
		// Token: 0x06002706 RID: 9990
		public sealed override extern ObjectId Add(string name);
	}
}
