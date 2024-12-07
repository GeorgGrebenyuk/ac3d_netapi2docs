using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02001206 RID: 4614
	[DefaultMember("Item")]
	public sealed class SurveyFigureStyleCollection : StyleCollectionBase
	{
		// Token: 0x06002705 RID: 9989
		public sealed override extern ObjectId Add(string name);
	}
}
