using System;
using System.Reflection;
using std;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001134 RID: 4404
	[DefaultMember("Item")]
	internal class AssemblyOwnedNotFilteredCalculatedLinkProvider : CalculatedLinkProvider
	{
		// Token: 0x0600246E RID: 9326
		public unsafe extern AssemblyOwnedNotFilteredCalculatedLinkProvider(AeccDbCorridor* pCorridor, CalculatedLinksIdentity* pIdentity, RoadwayStateData roadwayStateData);

		// Token: 0x0600246F RID: 9327
		protected override extern int calculateCount();

		// Token: 0x06002470 RID: 9328
		protected unsafe override extern pair<AcDbObjectId,long>* getSubassemblyAndEntityInfoAt(pair<AcDbObjectId,long>*, int index);
	}
}
