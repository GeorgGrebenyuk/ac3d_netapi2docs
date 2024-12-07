using System;
using Autodesk.AutoCAD.Geometry;
using Autodesk.Civil.DatabaseServices.Styles;
using Autodesk.Civil.DataShortcuts;

namespace Autodesk.Civil
{
	// Token: 0x0200001A RID: 26
	internal sealed class CivilHelper
	{
		// Token: 0x06000030 RID: 48
		public unsafe static extern LabelStyleType GetLabelStyleType(AeccDbLabelStyle* pLabelStyleComponent);

		// Token: 0x06000031 RID: 49
		public unsafe static extern LabelStyleType GetLabelStyleType(AeccDbLabelStyleCollector* pLabelStyle);

		// Token: 0x06000032 RID: 50
		public static extern LabelStyleType GetLabelStyleType(AeccDbTreeOid oidLabelStyle);

		// Token: 0x06000033 RID: 51
		public static extern Point3dCollection ToPoint3dCollection(Point2dCollection cliPoints);

		// Token: 0x06000034 RID: 52
		public unsafe static extern void InitializePropertyFieldMap(AeccPropertyFieldLocalRLMap* propertyFieldMap, AcDbObjectId* oid);

		// Token: 0x06000035 RID: 53
		public unsafe static extern void TransactionAddToModelSpace(AcDbDatabase* pDatabase, AcDbEntity* pDbEntity, AcDbObjectId* oidEntity);

		// Token: 0x06000036 RID: 54
		public unsafe static extern DataShortcutEntityType GetDataShortcutEntityType(AecRmCString* dsEntityTypeName);
	}
}
