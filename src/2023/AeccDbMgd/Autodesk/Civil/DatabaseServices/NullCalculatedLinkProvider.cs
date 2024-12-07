using System;
using System.Reflection;
using std;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001135 RID: 4405
	[DefaultMember("Item")]
	internal class NullCalculatedLinkProvider : CalculatedLinkProvider
	{
		// Token: 0x06002471 RID: 9329
		public unsafe extern NullCalculatedLinkProvider(AeccDbCorridor* pCorridor, CalculatedLinksIdentity* pIdentity, RoadwayStateData roadwayStateData);

		// Token: 0x06002472 RID: 9330
		protected override extern int calculateCount();

		// Token: 0x06002473 RID: 9331
		protected unsafe override extern pair<AcDbObjectId,long>* getSubassemblyAndEntityInfoAt(pair<AcDbObjectId,long>*, int index);
	}
}
