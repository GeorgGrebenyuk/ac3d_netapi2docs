using System;
using System.Reflection;
using std;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001131 RID: 4401
	[DefaultMember("Item")]
	internal class SubentityOwnedCalculatedLinkProvider : CalculatedLinkProvider
	{
		// Token: 0x06002465 RID: 9317
		public unsafe extern SubentityOwnedCalculatedLinkProvider(AeccDbCorridor* pCorridor, CalculatedLinksIdentity* pIdentity, RoadwayStateData roadwayStateData);

		// Token: 0x06002466 RID: 9318
		protected override extern int calculateCount();

		// Token: 0x06002467 RID: 9319
		protected unsafe override extern pair<AcDbObjectId,long>* getSubassemblyAndEntityInfoAt(pair<AcDbObjectId,long>*, int index);
	}
}
