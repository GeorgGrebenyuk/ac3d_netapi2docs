using System;
using System.Reflection;
using std;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001132 RID: 4402
	[DefaultMember("Item")]
	internal class SubassemblyOwnedCalculatedLinkProvider : CalculatedLinkProvider
	{
		// Token: 0x06002468 RID: 9320
		public unsafe extern SubassemblyOwnedCalculatedLinkProvider(AeccDbCorridor* pCorridor, CalculatedLinksIdentity* pIdentity, RoadwayStateData roadwayStateData);

		// Token: 0x06002469 RID: 9321
		protected override extern int calculateCount();

		// Token: 0x0600246A RID: 9322
		protected unsafe override extern pair<AcDbObjectId,long>* getSubassemblyAndEntityInfoAt(pair<AcDbObjectId,long>*, int index);
	}
}
