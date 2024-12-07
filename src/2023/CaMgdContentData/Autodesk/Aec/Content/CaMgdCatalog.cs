using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Autodesk.Aec.Content
{
	// Token: 0x0200003C RID: 60
	public class CaMgdCatalog : IDisposable
	{
		// Token: 0x06000014 RID: 20
		public unsafe extern CaMgdCatalog(CaCatalog* pCatalog);

		// Token: 0x06000015 RID: 21
		public static extern string GetCatalogID(string fileName);

		// Token: 0x06000016 RID: 22
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool InitCatalogInfo(string catalogID, string catalogUnit);

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000017 RID: 23
		public extern CaMgdUnitSystem UnitSystem { get; }

		// Token: 0x06000018 RID: 24
		public extern string GetUnitString(int unit);

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000019 RID: 25
		public extern string Version { get; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001A RID: 26
		public extern string CatalogFilePath { get; }

		// Token: 0x0600001B RID: 27
		public extern List<string> GetUnits(CaMgdMeasuringUnitType unitType);

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001C RID: 28
		public extern string CatalogId { get; }

		// Token: 0x0600001D RID: 29
		public extern List<string> GetPartFamilyNames(string industry, string partType);

		// Token: 0x0600001E RID: 30
		public extern List<string> GetPartFamilyIDs(string industry, string partType, string partFamilyName);

		// Token: 0x0600001F RID: 31
		public extern List<string> GetPartSizeIDs(string industry, string partType, string partFamilyID);

		// Token: 0x06000020 RID: 32
		public extern CaMgdPart GetPart(string industry, string partType, string partSizeID);

		// Token: 0x06000021 RID: 33
		public extern string GetDrawingFilePath(string industry, string partType, string partSizeID);

		// Token: 0x06000022 RID: 34
		public extern string GetDrawingFilePath(CaMgdPart part);

		// Token: 0x06000023 RID: 35
		public extern string GetImageFilePath(string industry, string partType, string partSizeID);

		// Token: 0x06000024 RID: 36
		public extern string GetImageFilePath(CaMgdPart part);

		// Token: 0x06000025 RID: 37
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool GetDisplayGraphicInfo(CaMgdPart part, out string fileName, out string blockName, CaMgdAcGraphicDisplayType type);

		// Token: 0x06000026 RID: 38
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool GetDisplayGraphicInfo(string industry, string partType, string partSizeID, out string fileName, out string blockName, CaMgdAcGraphicDisplayType type);

		// Token: 0x06000027 RID: 39
		public extern List<string> GetPartTypes(string industry, string domain, string propertyName, CaMgdContentValue value);

		// Token: 0x06000028 RID: 40
		public extern List<string> GetPartTypes(string industry, string domain);

		// Token: 0x06000029 RID: 41
		public extern List<CaMgdContentValue> GetAvailableValues(string industry, string domain, string propertyName);

		// Token: 0x0600002A RID: 42
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool InsertPart(out CaMgdPart part, string dwgPath, string imgPath);

		// Token: 0x0600002B RID: 43
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool InsertPart(out CaMgdPart part, string rootPath);

		// Token: 0x0600002C RID: 44
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool UpdatePart(CaMgdPart part);

		// Token: 0x0600002D RID: 45
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool DeletePart(string industry, string partType, CaMgdFilters filter);

		// Token: 0x0600002E RID: 46
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool DeletePart(CaMgdPart part);

		// Token: 0x0600002F RID: 47
		public extern CaMgdPartSet GetParts(string industry, string partType, CaMgdSortSequence sortSequence);

		// Token: 0x06000030 RID: 48
		public extern CaMgdPartSet GetParts(string industry, string partType, CaMgdFilters filter, CaMgdSortSequence sortSequence);

		// Token: 0x06000031 RID: 49
		public extern CaMgdPartSet GetParts(string industry, string partType, CaMgdFilters filter);

		// Token: 0x06000032 RID: 50
		public extern CaMgdPartSet GetParts(string industry, string partType);

		// Token: 0x06000033 RID: 51
		public extern int GetEngineeringPropertyIndex(string industry, string partType, string propertyName);

		// Token: 0x06000034 RID: 52
		public extern int GetConnectionPointPropertyIndex(string industry, string propertyName);

		// Token: 0x06000035 RID: 53
		public extern CaMgdPart CreateNewPart(string industry, string partType, int connectionPointCount);

		// Token: 0x06000036 RID: 54
		public extern CaMgdPartAttributeDefinitionCollection GetEngineeringDefinition(string industry, string partType);

		// Token: 0x06000037 RID: 55
		public extern CaMgdPartAttributeDefinitionCollection GetConnectionPointDefinition(string industry);

		// Token: 0x06000038 RID: 56
		public extern void StartNewChange(string transactionName);

		// Token: 0x06000039 RID: 57
		public extern void CommitChanges(string transactionName);

		// Token: 0x0600003A RID: 58
		public extern void RollbackChanges(string transactionName);

		// Token: 0x0600003B RID: 59
		public unsafe extern CaCatalog* GetCatalog();

		// Token: 0x0600003C RID: 60
		public extern Dictionary<int, string> GetEnums(CaMgdPartAttributeDefinition partDefinition);

		// Token: 0x0600003D RID: 61
		public extern int GetEnumIndex(CaMgdPartAttributeDefinition partDefinition, string value);

		// Token: 0x0600003E RID: 62
		public extern string GetEnumValue(CaMgdPartAttributeDefinition partDefinition, int key);

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600003F RID: 63
		public extern List<string> IndustryTypes { get; }

		// Token: 0x06000040 RID: 64
		public extern List<string> GetDomainTypes(string industry);

		// Token: 0x06000041 RID: 65
		public extern Dictionary<string, string> GetReferenceTableInfo();

		// Token: 0x06000042 RID: 66
		public extern CaMgdReferenceDataSet GetReferenceTableData(string tableName);

		// Token: 0x06000043 RID: 67
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool IsReferenced(string tableName, CaMgdContentValue key);

		// Token: 0x06000044 RID: 68
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool UpdateReferenceTable(string tableName, List<CaMgdContentValue> __unnamed001);

		// Token: 0x06000045 RID: 69
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool UpdateReferenceTable(CaMgdReferenceDataSet A_0);

		// Token: 0x06000046 RID: 70
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool InsertReferenceTable(string tableName, List<CaMgdContentValue> __unnamed001);

		// Token: 0x06000047 RID: 71
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool InsertReferenceTable(CaMgdReferenceDataSet A_0);

		// Token: 0x06000048 RID: 72
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool DeleteReferenceTable(string tableName, CaMgdContentValue key);

		// Token: 0x06000049 RID: 73
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool DeleteReferenceTable(CaMgdReferenceDataSet A_0);

		// Token: 0x0600004A RID: 74
		public extern void SetDesiredPartTypes(Dictionary<string, List<string>> desiredPartTypes);

		// Token: 0x0600004B RID: 75
		public extern string GetDisplayCaption(string industry, string domain, string partType);

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600004C RID: 76
		public extern List<CaMgdTermCaption> IndustryTypeTerms { get; }

		// Token: 0x0600004D RID: 77
		public extern List<CaMgdTermCaption> GetDomainTypeTerms(string industry);

		// Token: 0x0600004E RID: 78
		public extern List<CaMgdTermCaption> GetPartTypeTerms(string industry, string domain);

		// Token: 0x0600004F RID: 79
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x06000050 RID: 80
		public sealed extern void Dispose();

		// Token: 0x0400045D RID: 1117
		private int <SyntheticNonEmptyStructMarker>;
	}
}
