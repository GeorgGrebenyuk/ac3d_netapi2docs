using System;
using System.Runtime.InteropServices;
using std;

namespace Autodesk.Civil
{
	// Token: 0x0200001B RID: 27
	internal sealed class AttributeHelper
	{
		// Token: 0x06000037 RID: 55
		public unsafe static extern string getAttributeString(uint attributeId, AcDbObjectId* ObjectId);

		// Token: 0x06000038 RID: 56
		public unsafe static extern string getAttributeString(uint attributeId, AcDbObjectId* ObjectId, AeccUserParam* userParam);

		// Token: 0x06000039 RID: 57
		public unsafe static extern string getAttributeString(uint attributeId, IAeccAttributeBin* pAttrBin);

		// Token: 0x0600003A RID: 58
		public unsafe static extern string getAttributeString(uint attributeId, IAeccAttributeBin* pAttrBin, AeccUserParam* userParam);

		// Token: 0x0600003B RID: 59
		public unsafe static extern _FILETIME getAttributeFILETIME(uint attributeId, AcDbObjectId* ObjectId);

		// Token: 0x0600003C RID: 60
		public unsafe static extern _FILETIME getAttributeFILETIME(uint attributeId, AcDbObjectId* ObjectId, AeccUserParam* userParam);

		// Token: 0x0600003D RID: 61
		public unsafe static extern _FILETIME getAttributeFILETIME(uint attributeId, IAeccAttributeBin* pAttrBin);

		// Token: 0x0600003E RID: 62
		public unsafe static extern _FILETIME getAttributeFILETIME(uint attributeId, IAeccAttributeBin* pAttrBin, AeccUserParam* userParam);

		// Token: 0x0600003F RID: 63
		public unsafe static extern AeccAtom* getAttributeAeccAtom(AeccAtom*, uint attributeId, AcDbObjectId* ObjectId);

		// Token: 0x06000040 RID: 64
		public unsafe static extern AeccAtom* getAttributeAeccAtom(AeccAtom*, uint attributeId, AcDbObjectId* ObjectId, AeccUserParam* userParam);

		// Token: 0x06000041 RID: 65
		public unsafe static extern AeccAtom* getAttributeAeccAtom(AeccAtom*, uint attributeId, IAeccAttributeBin* pAttrBin);

		// Token: 0x06000042 RID: 66
		public unsafe static extern AeccAtom* getAttributeAeccAtom(AeccAtom*, uint attributeId, IAeccAttributeBin* pAttrBin, AeccUserParam* userParam);

		// Token: 0x06000043 RID: 67
		public unsafe static extern double getAttributeDouble(uint attributeId, AcDbObjectId* ObjectId);

		// Token: 0x06000044 RID: 68
		public unsafe static extern double getAttributeDouble(uint attributeId, AcDbObjectId* ObjectId, AeccUserParam* userParam);

		// Token: 0x06000045 RID: 69
		public unsafe static extern double getAttributeDouble(uint attributeId, IAeccAttributeBin* pAttrBin);

		// Token: 0x06000046 RID: 70
		public unsafe static extern double getAttributeDouble(uint attributeId, IAeccAttributeBin* pAttrBin, AeccUserParam* userParam);

		// Token: 0x06000047 RID: 71
		[return: MarshalAs(UnmanagedType.U1)]
		public unsafe static extern bool getAttributeBool(uint attributeId, AcDbObjectId* ObjectId);

		// Token: 0x06000048 RID: 72
		[return: MarshalAs(UnmanagedType.U1)]
		public unsafe static extern bool getAttributeBool(uint attributeId, AcDbObjectId* ObjectId, AeccUserParam* userParam);

		// Token: 0x06000049 RID: 73
		[return: MarshalAs(UnmanagedType.U1)]
		public unsafe static extern bool getAttributeBool(uint attributeId, IAeccAttributeBin* pAttrBin);

		// Token: 0x0600004A RID: 74
		[return: MarshalAs(UnmanagedType.U1)]
		public unsafe static extern bool getAttributeBool(uint attributeId, IAeccAttributeBin* pAttrBin, AeccUserParam* userParam);

		// Token: 0x0600004B RID: 75
		public unsafe static extern int getAttributeInt(uint attributeId, AcDbObjectId* ObjectId);

		// Token: 0x0600004C RID: 76
		public unsafe static extern int getAttributeInt(uint attributeId, AcDbObjectId* ObjectId, AeccUserParam* userParam);

		// Token: 0x0600004D RID: 77
		public unsafe static extern int getAttributeInt(uint attributeId, IAeccAttributeBin* pAttrBin);

		// Token: 0x0600004E RID: 78
		public unsafe static extern int getAttributeInt(uint attributeId, IAeccAttributeBin* pAttrBin, AeccUserParam* userParam);

		// Token: 0x0600004F RID: 79
		public unsafe static extern AcDbObjectId* getAttributeOid(AcDbObjectId*, uint attributeId, AcDbObjectId* ObjectId);

		// Token: 0x06000050 RID: 80
		public unsafe static extern AcDbObjectId* getAttributeOid(AcDbObjectId*, uint attributeId, AcDbObjectId* ObjectId, AeccUserParam* userParam);

		// Token: 0x06000051 RID: 81
		public unsafe static extern AcDbObjectId* getAttributeOid(AcDbObjectId*, uint attributeId, IAeccAttributeBin* pAttrBin);

		// Token: 0x06000052 RID: 82
		public unsafe static extern AcDbObjectId* getAttributeOid(AcDbObjectId*, uint attributeId, IAeccAttributeBin* pAttrBin, AeccUserParam* userParam);

		// Token: 0x06000053 RID: 83
		public unsafe static extern AcGePoint2d* getAttributePoint2d(AcGePoint2d*, uint attributeId, AcDbObjectId* ObjectId);

		// Token: 0x06000054 RID: 84
		public unsafe static extern AcGePoint2d* getAttributePoint2d(AcGePoint2d*, uint attributeId, AcDbObjectId* ObjectId, AeccUserParam* userParam);

		// Token: 0x06000055 RID: 85
		public unsafe static extern AcGePoint2d* getAttributePoint2d(AcGePoint2d*, uint attributeId, IAeccAttributeBin* pAttrBin);

		// Token: 0x06000056 RID: 86
		public unsafe static extern AcGePoint2d* getAttributePoint2d(AcGePoint2d*, uint attributeId, IAeccAttributeBin* pAttrBin, AeccUserParam* userParam);

		// Token: 0x06000057 RID: 87
		public unsafe static extern AcGePoint3d* getAttributePoint3d(AcGePoint3d*, uint attributeId, AcDbObjectId* ObjectId);

		// Token: 0x06000058 RID: 88
		public unsafe static extern AcGePoint3d* getAttributePoint3d(AcGePoint3d*, uint attributeId, AcDbObjectId* ObjectId, AeccUserParam* userParam);

		// Token: 0x06000059 RID: 89
		public unsafe static extern AcGePoint3d* getAttributePoint3d(AcGePoint3d*, uint attributeId, IAeccAttributeBin* pAttrBin);

		// Token: 0x0600005A RID: 90
		public unsafe static extern AcGePoint3d* getAttributePoint3d(AcGePoint3d*, uint attributeId, IAeccAttributeBin* pAttrBin, AeccUserParam* userParam);

		// Token: 0x0600005B RID: 91
		public unsafe static extern AcGeVector3d* getAttributeVector3d(AcGeVector3d*, uint attributeId, AcDbObjectId* ObjectId);

		// Token: 0x0600005C RID: 92
		public unsafe static extern AcGeVector3d* getAttributeVector3d(AcGeVector3d*, uint attributeId, AcDbObjectId* ObjectId, AeccUserParam* userParam);

		// Token: 0x0600005D RID: 93
		public unsafe static extern AcGeVector3d* getAttributeVector3d(AcGeVector3d*, uint attributeId, IAeccAttributeBin* pAttrBin);

		// Token: 0x0600005E RID: 94
		public unsafe static extern AcGeVector3d* getAttributeVector3d(AcGeVector3d*, uint attributeId, IAeccAttributeBin* pAttrBin, AeccUserParam* userParam);

		// Token: 0x0600005F RID: 95
		public unsafe static extern AcCmColor* getAttributeColor(AcCmColor*, uint attributeId, AcDbObjectId* ObjectId);

		// Token: 0x06000060 RID: 96
		public unsafe static extern AcCmColor* getAttributeColor(AcCmColor*, uint attributeId, AcDbObjectId* ObjectId, AeccUserParam* userParam);

		// Token: 0x06000061 RID: 97
		public unsafe static extern AcCmColor* getAttributeColor(AcCmColor*, uint attributeId, IAeccAttributeBin* pAttrBin);

		// Token: 0x06000062 RID: 98
		public unsafe static extern AcCmColor* getAttributeColor(AcCmColor*, uint attributeId, IAeccAttributeBin* pAttrBin, AeccUserParam* userParam);

		// Token: 0x06000063 RID: 99
		public unsafe static extern void putAttributeAeccAtom(uint attributeId, AcDbObjectId* ObjectId, AeccAtom* newValue);

		// Token: 0x06000064 RID: 100
		public unsafe static extern void putAttributeAeccAtom(uint attributeId, AcDbObjectId* ObjectId, AeccAtom* newValue, AeccUserParam* userParam);

		// Token: 0x06000065 RID: 101
		public unsafe static extern void putAttributeAeccAtom(uint attributeId, IAeccAttributeBin* pAttrBin, AeccAtom* newValue);

		// Token: 0x06000066 RID: 102
		public unsafe static extern void putAttributeAeccAtom(uint attributeId, IAeccAttributeBin* pAttrBin, AeccAtom* newValue, AeccUserParam* userParam);

		// Token: 0x06000067 RID: 103
		public unsafe static extern void putAttributeString(uint attributeId, AcDbObjectId* ObjectId, string newValue);

		// Token: 0x06000068 RID: 104
		public unsafe static extern void putAttributeString(uint attributeId, AcDbObjectId* ObjectId, string newValue, AeccUserParam* userParam);

		// Token: 0x06000069 RID: 105
		public unsafe static extern void putAttributeString(uint attributeId, IAeccAttributeBin* pAttrBin, string newValue);

		// Token: 0x0600006A RID: 106
		public unsafe static extern void putAttributeString(uint attributeId, IAeccAttributeBin* pAttrBin, string newValue, AeccUserParam* userParam);

		// Token: 0x0600006B RID: 107
		public unsafe static extern void putAttributeDouble(uint attributeId, AcDbObjectId* ObjectId, double newValue);

		// Token: 0x0600006C RID: 108
		public unsafe static extern void putAttributeDouble(uint attributeId, AcDbObjectId* ObjectId, double newValue, AeccUserParam* userParam);

		// Token: 0x0600006D RID: 109
		public unsafe static extern void putAttributeDouble(uint attributeId, IAeccAttributeBin* pAttrBin, double newValue);

		// Token: 0x0600006E RID: 110
		public unsafe static extern void putAttributeDouble(uint attributeId, IAeccAttributeBin* pAttrBin, double newValue, AeccUserParam* userParam);

		// Token: 0x0600006F RID: 111
		public unsafe static extern void putAttributeBool(uint attributeId, AcDbObjectId* ObjectId, [MarshalAs(UnmanagedType.U1)] bool newValue);

		// Token: 0x06000070 RID: 112
		public unsafe static extern void putAttributeBool(uint attributeId, AcDbObjectId* ObjectId, [MarshalAs(UnmanagedType.U1)] bool newValue, AeccUserParam* userParam);

		// Token: 0x06000071 RID: 113
		public unsafe static extern void putAttributeBool(uint attributeId, IAeccAttributeBin* pAttrBin, [MarshalAs(UnmanagedType.U1)] bool newValue);

		// Token: 0x06000072 RID: 114
		public unsafe static extern void putAttributeBool(uint attributeId, IAeccAttributeBin* pAttrBin, [MarshalAs(UnmanagedType.U1)] bool newValue, AeccUserParam* userParam);

		// Token: 0x06000073 RID: 115
		public unsafe static extern void putAttributeInt(uint attributeId, AcDbObjectId* ObjectId, int newValue);

		// Token: 0x06000074 RID: 116
		public unsafe static extern void putAttributeInt(uint attributeId, AcDbObjectId* ObjectId, int newValue, AeccUserParam* userParam);

		// Token: 0x06000075 RID: 117
		public unsafe static extern void putAttributeInt(uint attributeId, IAeccAttributeBin* pAttrBin, int newValue);

		// Token: 0x06000076 RID: 118
		public unsafe static extern void putAttributeInt(uint attributeId, IAeccAttributeBin* pAttrBin, int newValue, AeccUserParam* userParam);

		// Token: 0x06000077 RID: 119
		public unsafe static extern void putAttributeOid(uint attributeId, AcDbObjectId* ObjectId, AcDbObjectId* newValue);

		// Token: 0x06000078 RID: 120
		public unsafe static extern void putAttributeOid(uint attributeId, AcDbObjectId* ObjectId, AcDbObjectId* newValue, AeccUserParam* userParam);

		// Token: 0x06000079 RID: 121
		public unsafe static extern void putAttributeOid(uint attributeId, IAeccAttributeBin* pAttrBin, AcDbObjectId* newValue);

		// Token: 0x0600007A RID: 122
		public unsafe static extern void putAttributeOid(uint attributeId, IAeccAttributeBin* pAttrBin, AcDbObjectId* newValue, AeccUserParam* userParam);

		// Token: 0x0600007B RID: 123
		public unsafe static extern void putAttributePoint2d(uint attributeId, AcDbObjectId* ObjectId, AcGePoint2d* newValue);

		// Token: 0x0600007C RID: 124
		public unsafe static extern void putAttributePoint2d(uint attributeId, AcDbObjectId* ObjectId, AcGePoint2d* newValue, AeccUserParam* userParam);

		// Token: 0x0600007D RID: 125
		public unsafe static extern void putAttributePoint2d(uint attributeId, IAeccAttributeBin* pAttrBin, AcGePoint2d* newValue);

		// Token: 0x0600007E RID: 126
		public unsafe static extern void putAttributePoint2d(uint attributeId, IAeccAttributeBin* pAttrBin, AcGePoint2d* newValue, AeccUserParam* userParam);

		// Token: 0x0600007F RID: 127
		public unsafe static extern void putAttributePoint3d(uint attributeId, AcDbObjectId* ObjectId, AcGePoint3d* newValue);

		// Token: 0x06000080 RID: 128
		public unsafe static extern void putAttributePoint3d(uint attributeId, AcDbObjectId* ObjectId, AcGePoint3d* newValue, AeccUserParam* userParam);

		// Token: 0x06000081 RID: 129
		public unsafe static extern void putAttributePoint3d(uint attributeId, IAeccAttributeBin* pAttrBin, AcGePoint3d* newValue);

		// Token: 0x06000082 RID: 130
		public unsafe static extern void putAttributePoint3d(uint attributeId, IAeccAttributeBin* pAttrBin, AcGePoint3d* newValue, AeccUserParam* userParam);

		// Token: 0x06000083 RID: 131
		public unsafe static extern void putAttributeVector3d(uint attributeId, AcDbObjectId* ObjectId, AcGeVector3d* newValue);

		// Token: 0x06000084 RID: 132
		public unsafe static extern void putAttributeVector3d(uint attributeId, AcDbObjectId* ObjectId, AcGeVector3d* newValue, AeccUserParam* userParam);

		// Token: 0x06000085 RID: 133
		public unsafe static extern void putAttributeVector3d(uint attributeId, IAeccAttributeBin* pAttrBin, AcGeVector3d* newValue);

		// Token: 0x06000086 RID: 134
		public unsafe static extern void putAttributeVector3d(uint attributeId, IAeccAttributeBin* pAttrBin, AcGeVector3d* newValue, AeccUserParam* userParam);

		// Token: 0x06000087 RID: 135
		public unsafe static extern void putAttributeColor(uint attributeId, AcDbObjectId* ObjectId, AcCmColor* newValue);

		// Token: 0x06000088 RID: 136
		public unsafe static extern void putAttributeColor(uint attributeId, AcDbObjectId* ObjectId, AcCmColor* newValue, AeccUserParam* userParam);

		// Token: 0x06000089 RID: 137
		public unsafe static extern void putAttributeColor(uint attributeId, IAeccAttributeBin* pAttrBin, AcCmColor* newValue);

		// Token: 0x0600008A RID: 138
		public unsafe static extern void putAttributeColor(uint attributeId, IAeccAttributeBin* pAttrBin, AcCmColor* newValue, AeccUserParam* userParam);

		// Token: 0x0600008B RID: 139
		public unsafe static extern vector<AeccAttribute,std::allocator<AeccAttribute>\u0020>* getAttributeGeneric<std::vector<AeccAttribute,std::allocator<AeccAttribute>\u0020>\u0020>(vector<AeccAttribute,std::allocator<AeccAttribute>\u0020>*, uint attributeId, IAeccAttributeBin* pAttrBin);

		// Token: 0x0600008C RID: 140
		public unsafe static extern AcCmColor* getAttributeGeneric<AcCmColor>(AcCmColor*, uint attributeId, IAeccAttributeBin* pAttrBin);

		// Token: 0x0600008D RID: 141
		public unsafe static extern AcDbObjectId* getAttributeGeneric<AcDbObjectId>(AcDbObjectId*, uint attributeId, IAeccAttributeBin* pAttrBin);

		// Token: 0x0600008E RID: 142
		public unsafe static extern AecRmCString* getAttributeGeneric<AecRmCString>(AecRmCString*, uint attributeId, IAeccAttributeBin* pAttrBin);

		// Token: 0x0600008F RID: 143
		[return: MarshalAs(UnmanagedType.U1)]
		public unsafe static extern bool getAttributeGeneric<bool>(uint attributeId, IAeccAttributeBin* pAttrBin);

		// Token: 0x06000090 RID: 144
		public unsafe static extern int getAttributeGeneric<int>(uint attributeId, IAeccAttributeBin* pAttrBin);

		// Token: 0x06000091 RID: 145
		public unsafe static extern double getAttributeGeneric<double>(uint attributeId, IAeccAttributeBin* pAttrBin);

		// Token: 0x06000092 RID: 146
		public unsafe static extern vector<AeccAttribute,std::allocator<AeccAttribute>\u0020>* getAttributeGeneric<std::vector<AeccAttribute,std::allocator<AeccAttribute>\u0020>\u0020>(vector<AeccAttribute,std::allocator<AeccAttribute>\u0020>*, uint attributeId, IAeccAttributeBin* pAttrBin, AeccUserParam* userParam);

		// Token: 0x06000093 RID: 147
		public unsafe static extern AcCmColor* getAttributeGeneric<AcCmColor>(AcCmColor*, uint attributeId, IAeccAttributeBin* pAttrBin, AeccUserParam* userParam);

		// Token: 0x06000094 RID: 148
		public unsafe static extern AcDbObjectId* getAttributeGeneric<AcDbObjectId>(AcDbObjectId*, uint attributeId, IAeccAttributeBin* pAttrBin, AeccUserParam* userParam);

		// Token: 0x06000095 RID: 149
		public unsafe static extern AecRmCString* getAttributeGeneric<AecRmCString>(AecRmCString*, uint attributeId, IAeccAttributeBin* pAttrBin, AeccUserParam* userParam);

		// Token: 0x06000096 RID: 150
		[return: MarshalAs(UnmanagedType.U1)]
		public unsafe static extern bool getAttributeGeneric<bool>(uint attributeId, IAeccAttributeBin* pAttrBin, AeccUserParam* userParam);

		// Token: 0x06000097 RID: 151
		public unsafe static extern int getAttributeGeneric<int>(uint attributeId, IAeccAttributeBin* pAttrBin, AeccUserParam* userParam);

		// Token: 0x06000098 RID: 152
		public unsafe static extern double getAttributeGeneric<double>(uint attributeId, IAeccAttributeBin* pAttrBin, AeccUserParam* userParam);

		// Token: 0x06000099 RID: 153
		public unsafe static extern void putAttributeGeneric<std::vector<AeccAttribute,std::allocator<AeccAttribute>\u0020>\u0020>(uint attributeId, IAeccAttributeBin* pAttrBin, vector<AeccAttribute,std::allocator<AeccAttribute>\u0020>* newValue);

		// Token: 0x0600009A RID: 154
		public unsafe static extern void putAttributeGeneric<AcCmColor>(uint attributeId, IAeccAttributeBin* pAttrBin, AcCmColor* newValue);

		// Token: 0x0600009B RID: 155
		public unsafe static extern void putAttributeGeneric<AcDbObjectId>(uint attributeId, IAeccAttributeBin* pAttrBin, AcDbObjectId newValue);

		// Token: 0x0600009C RID: 156
		public unsafe static extern void putAttributeGeneric<AecRmCString>(uint attributeId, IAeccAttributeBin* pAttrBin, AecRmCString* newValue);

		// Token: 0x0600009D RID: 157
		public unsafe static extern void putAttributeGeneric<bool>(uint attributeId, IAeccAttributeBin* pAttrBin, [MarshalAs(UnmanagedType.U1)] bool newValue);

		// Token: 0x0600009E RID: 158
		public unsafe static extern void putAttributeGeneric<int>(uint attributeId, IAeccAttributeBin* pAttrBin, int newValue);

		// Token: 0x0600009F RID: 159
		public unsafe static extern void putAttributeGeneric<double>(uint attributeId, IAeccAttributeBin* pAttrBin, double newValue);

		// Token: 0x060000A0 RID: 160
		public unsafe static extern void putAttributeGeneric<std::vector<AeccAttribute,std::allocator<AeccAttribute>\u0020>\u0020>(uint attributeId, IAeccAttributeBin* pAttrBin, vector<AeccAttribute,std::allocator<AeccAttribute>\u0020>* newValue, AeccUserParam* userParam);

		// Token: 0x060000A1 RID: 161
		public unsafe static extern void putAttributeGeneric<AcCmColor>(uint attributeId, IAeccAttributeBin* pAttrBin, AcCmColor* newValue, AeccUserParam* userParam);

		// Token: 0x060000A2 RID: 162
		public unsafe static extern void putAttributeGeneric<AcDbObjectId>(uint attributeId, IAeccAttributeBin* pAttrBin, AcDbObjectId newValue, AeccUserParam* userParam);

		// Token: 0x060000A3 RID: 163
		public unsafe static extern void putAttributeGeneric<AecRmCString>(uint attributeId, IAeccAttributeBin* pAttrBin, AecRmCString* newValue, AeccUserParam* userParam);

		// Token: 0x060000A4 RID: 164
		public unsafe static extern void putAttributeGeneric<bool>(uint attributeId, IAeccAttributeBin* pAttrBin, [MarshalAs(UnmanagedType.U1)] bool newValue, AeccUserParam* userParam);

		// Token: 0x060000A5 RID: 165
		public unsafe static extern void putAttributeGeneric<int>(uint attributeId, IAeccAttributeBin* pAttrBin, int newValue, AeccUserParam* userParam);

		// Token: 0x060000A6 RID: 166
		public unsafe static extern void putAttributeGeneric<double>(uint attributeId, IAeccAttributeBin* pAttrBin, double newValue, AeccUserParam* userParam);

		// Token: 0x060000A7 RID: 167
		public unsafe static extern string getTableStyleAttribute(uint attributeId, IAeccAttributeBin* pAttrBin);

		// Token: 0x060000A8 RID: 168
		public unsafe static extern void putTableStyleAttribute(uint attributeId, AeccAtom* styleType, IAeccAttributeBin* pAttrBin, string styleName);

		// Token: 0x060000A9 RID: 169
		public unsafe static extern string GetStyleName(uint attributeId, IAeccAttributeBin* pAttrBin);

		// Token: 0x060000AA RID: 170
		public unsafe static extern void SetStyleByName(uint attributeId, IAeccAttributeBin* pAttrBin, AeccDbTreeOid stylesRootOid, string newValue);

		// Token: 0x060000AB RID: 171
		public unsafe static extern string GetSymbolRecordNameFromId<AcDbLayerTable>(AcDbDatabase* pDatabase, AcDbObjectId* symbolRecordId);

		// Token: 0x060000AC RID: 172
		public unsafe static extern AcDbObjectId* GetSymbolRecordIdFromName<AcDbLayerTable>(AcDbObjectId*, AcDbDatabase* pDatabase, string symbolRecordName);

		// Token: 0x060000AD RID: 173
		public unsafe static extern string GetSymbolRecordNameFromId<AcDbBlockTable>(AcDbDatabase* pDatabase, AcDbObjectId* symbolRecordId);

		// Token: 0x060000AE RID: 174
		public unsafe static extern string getSymbolTableAttribute<AcDbBlockTable>(uint attributeId, IAeccAttributeBin* pAttrBin);

		// Token: 0x060000AF RID: 175
		public unsafe static extern string getSymbolTableAttribute<AcDbBlockTable>(uint attributeId, IAeccAttributeBin* pAttrBin, AeccUserParam* userParam);

		// Token: 0x060000B0 RID: 176
		public unsafe static extern string GetSymbolRecordNameFromId<AcDbLinetypeTable>(AcDbDatabase* pDatabase, AcDbObjectId* symbolRecordId);

		// Token: 0x060000B1 RID: 177
		public unsafe static extern AcDbObjectId* GetSymbolRecordIdFromName<AcDbLinetypeTable>(AcDbObjectId*, AcDbDatabase* pDatabase, string symbolRecordName);

		// Token: 0x060000B2 RID: 178
		public unsafe static extern AcDbObjectId* GetSymbolRecordIdFromName<AcDbBlockTable>(AcDbObjectId*, AcDbDatabase* pDatabase, string symbolRecordName);

		// Token: 0x060000B3 RID: 179
		public unsafe static extern string getSymbolTableAttribute<AcDbLinetypeTable>(uint attributeId, IAeccAttributeBin* pAttrBin);

		// Token: 0x060000B4 RID: 180
		public unsafe static extern string getSymbolTableAttribute<AcDbLinetypeTable>(uint attributeId, IAeccAttributeBin* pAttrBin, AeccUserParam* userParam);

		// Token: 0x060000B5 RID: 181
		public unsafe static extern void putSymbolTableAttribute<AcDbBlockTable>(uint attributeId, IAeccAttributeBin* pAttrBin, string symbolRecordName);

		// Token: 0x060000B6 RID: 182
		public unsafe static extern void putSymbolTableAttribute<AcDbBlockTable>(uint attributeId, IAeccAttributeBin* pAttrBin, string symbolRecordName, AeccUserParam* userParam);

		// Token: 0x060000B7 RID: 183
		public unsafe static extern string GetSymbolRecordNameFromId<AcDbTextStyleTable>(AcDbDatabase* pDatabase, AcDbObjectId* symbolRecordId);

		// Token: 0x060000B8 RID: 184
		public unsafe static extern AcDbObjectId* GetSymbolRecordIdFromName<AcDbTextStyleTable>(AcDbObjectId*, AcDbDatabase* pDatabase, string symbolRecordName);

		// Token: 0x060000B9 RID: 185
		public unsafe static extern string getSymbolTableAttribute<AcDbTextStyleTable>(uint attributeId, IAeccAttributeBin* pAttrBin);

		// Token: 0x060000BA RID: 186
		public unsafe static extern string getSymbolTableAttribute<AcDbTextStyleTable>(uint attributeId, IAeccAttributeBin* pAttrBin, AeccUserParam* userParam);

		// Token: 0x060000BB RID: 187
		public unsafe static extern void putSymbolTableAttribute<AcDbTextStyleTable>(uint attributeId, IAeccAttributeBin* pAttrBin, string symbolRecordName);

		// Token: 0x060000BC RID: 188
		public unsafe static extern void putSymbolTableAttribute<AcDbTextStyleTable>(uint attributeId, IAeccAttributeBin* pAttrBin, string symbolRecordName, AeccUserParam* userParam);

		// Token: 0x060000BD RID: 189
		public unsafe static extern _FILETIME getAttributeGeneric<_FILETIME>(uint attributeId, IAeccAttributeBin* pAttrBin, AeccUserParam* userParam);

		// Token: 0x060000BE RID: 190
		public unsafe static extern AeccAtom* getAttributeGeneric<AeccAtom>(AeccAtom*, uint attributeId, IAeccAttributeBin* pAttrBin, AeccUserParam* userParam);

		// Token: 0x060000BF RID: 191
		public unsafe static extern AcGePoint2d* getAttributeGeneric<AcGePoint2d>(AcGePoint2d*, uint attributeId, IAeccAttributeBin* pAttrBin, AeccUserParam* userParam);

		// Token: 0x060000C0 RID: 192
		public unsafe static extern AcGePoint3d* getAttributeGeneric<AcGePoint3d>(AcGePoint3d*, uint attributeId, IAeccAttributeBin* pAttrBin, AeccUserParam* userParam);

		// Token: 0x060000C1 RID: 193
		public unsafe static extern AcGeVector3d* getAttributeGeneric<AcGeVector3d>(AcGeVector3d*, uint attributeId, IAeccAttributeBin* pAttrBin, AeccUserParam* userParam);

		// Token: 0x060000C2 RID: 194
		public unsafe static extern void putAttributeGeneric<AeccAtom>(uint attributeId, IAeccAttributeBin* pAttrBin, AeccAtom* newValue, AeccUserParam* userParam);

		// Token: 0x060000C3 RID: 195
		public unsafe static extern void putAttributeGeneric<AcGePoint2d>(uint attributeId, IAeccAttributeBin* pAttrBin, AcGePoint2d* newValue, AeccUserParam* userParam);

		// Token: 0x060000C4 RID: 196
		public unsafe static extern void putAttributeGeneric<AcGePoint3d>(uint attributeId, IAeccAttributeBin* pAttrBin, AcGePoint3d* newValue, AeccUserParam* userParam);

		// Token: 0x060000C5 RID: 197
		public unsafe static extern void putAttributeGeneric<AcGeVector3d>(uint attributeId, IAeccAttributeBin* pAttrBin, AcGeVector3d* newValue, AeccUserParam* userParam);
	}
}
