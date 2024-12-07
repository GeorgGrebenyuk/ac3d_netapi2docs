using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000073 RID: 115
	[Wrapper("AeccDbCogoPoint")]
	public sealed class CogoPoint : Entity
	{
		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060004DC RID: 1244
		public extern Point3d Location { get; }

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060004DD RID: 1245
		public extern bool IsSurveyPoint { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060004DE RID: 1246
		public extern bool IsMovable { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060004DF RID: 1247
		// (set) Token: 0x060004E0 RID: 1248
		public extern string PointName { get; set; }

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060004E1 RID: 1249
		// (set) Token: 0x060004E2 RID: 1250
		public extern uint PointNumber { get; set; }

		// Token: 0x060004E3 RID: 1251
		public extern uint Renumber(uint newPointNumber, PointNumberResolveType resolveType);

		// Token: 0x060004E4 RID: 1252
		public extern uint Renumber(uint newPointNumber);

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060004E5 RID: 1253
		// (set) Token: 0x060004E6 RID: 1254
		public extern string RawDescription { get; set; }

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060004E7 RID: 1255
		public extern string RawDescriptionOverride { get; }

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060004E8 RID: 1256
		public extern string FullDescription { get; }

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060004E9 RID: 1257
		public extern string FullDescriptionOverride { get; }

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060004EA RID: 1258
		// (set) Token: 0x060004EB RID: 1259
		public extern string DescriptionFormat { get; set; }

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060004EC RID: 1260
		public extern ObjectId PrimaryPointGroupId { get; }

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060004ED RID: 1261
		// (set) Token: 0x060004EE RID: 1262
		public extern bool IsLocked { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060004EF RID: 1263
		// (set) Token: 0x060004F0 RID: 1264
		public extern bool ShowToolTip { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060004F1 RID: 1265
		// (set) Token: 0x060004F2 RID: 1266
		public extern double Easting { get; set; }

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060004F3 RID: 1267
		// (set) Token: 0x060004F4 RID: 1268
		public extern double Northing { get; set; }

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060004F5 RID: 1269
		// (set) Token: 0x060004F6 RID: 1270
		public extern double Elevation { get; set; }

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060004F7 RID: 1271
		public extern double ElevationOverride { get; }

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060004F8 RID: 1272
		// (set) Token: 0x060004F9 RID: 1273
		public extern double MarkerRotation { get; set; }

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060004FA RID: 1274
		// (set) Token: 0x060004FB RID: 1275
		public extern double LabelRotation { get; set; }

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060004FC RID: 1276
		// (set) Token: 0x060004FD RID: 1277
		public extern Point3d LabelLocation { get; set; }

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060004FE RID: 1278
		// (set) Token: 0x060004FF RID: 1279
		public extern double ScaleXY { get; set; }

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000500 RID: 1280
		// (set) Token: 0x06000501 RID: 1281
		public extern double ScaleZ { get; set; }

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000502 RID: 1282
		public extern double Scale { get; }

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000503 RID: 1283
		// (set) Token: 0x06000504 RID: 1284
		public extern ObjectId LabelStyleId { get; set; }

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000505 RID: 1285
		public extern ObjectId LabelStyleIdOverride { get; }

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000506 RID: 1286
		// (set) Token: 0x06000507 RID: 1287
		public extern ObjectId StyleId { get; set; }

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000508 RID: 1288
		public extern ObjectId StyleIdOverride { get; }

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000509 RID: 1289
		public extern double Convergence { get; }

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600050A RID: 1290
		// (set) Token: 0x0600050B RID: 1291
		public extern double Latitude { get; set; }

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600050C RID: 1292
		// (set) Token: 0x0600050D RID: 1293
		public extern double Longitude { get; set; }

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600050E RID: 1294
		// (set) Token: 0x0600050F RID: 1295
		public extern double GridNorthing { get; set; }

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000510 RID: 1296
		// (set) Token: 0x06000511 RID: 1297
		public extern double GridEasting { get; set; }

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000512 RID: 1298
		public extern bool IsProjectPoint { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000513 RID: 1299
		public extern int ProjectVersion { get; }

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000514 RID: 1300
		public extern bool IsCheckedOut { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x06000515 RID: 1301
		public extern void ApplyDescriptionKeys();

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000516 RID: 1302
		public extern bool IsLabelDragged { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000517 RID: 1303
		// (set) Token: 0x06000518 RID: 1304
		public extern bool IsLabelPinned { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000519 RID: 1305
		// (set) Token: 0x0600051A RID: 1306
		public extern bool IsLabelVisible { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600051B RID: 1307
		// (set) Token: 0x0600051C RID: 1308
		public extern LeaderVisibilityType LeaderVisibility { get; set; }

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600051D RID: 1309
		// (set) Token: 0x0600051E RID: 1310
		public extern LeaderTailVisibilityType LeaderTailVisibility { get; set; }

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600051F RID: 1311
		// (set) Token: 0x06000520 RID: 1312
		public extern LeaderAttachmentBehaviorType LeaderAttachment { get; set; }

		// Token: 0x06000521 RID: 1313
		public extern void ResetLabel();

		// Token: 0x06000522 RID: 1314
		public extern void ResetLabelLocation();

		// Token: 0x06000523 RID: 1315
		public extern void ResetLabelRotation();

		// Token: 0x06000524 RID: 1316
		public extern ObjectIdCollection GetLabelTextComponentIds();

		// Token: 0x06000525 RID: 1317
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool IsLabelTextComponentOverriden(ObjectId labelComponentId);

		// Token: 0x06000526 RID: 1318
		public extern string GetLabelTextComponentOverride(ObjectId labelComponentId);

		// Token: 0x06000527 RID: 1319
		public extern void SetLabelTextComponentOverride(ObjectId labelComponentId, string textOverride);

		// Token: 0x06000528 RID: 1320
		public extern TextJustificationType GetLabelTextComponentJustificationOverride(ObjectId labelComponentId);

		// Token: 0x06000529 RID: 1321
		public extern void SetLabelTextComponentJustificationOverride(ObjectId labelComponentId, TextJustificationType textJustificationType);

		// Token: 0x0600052A RID: 1322
		public extern void ClearAllLabelTextComponentOverrides();

		// Token: 0x0600052B RID: 1323
		public extern void ClearLabelTextComponentOverrides(ObjectId labelComponentId);

		// Token: 0x0600052C RID: 1324
		public extern void SetUDPValue(UDPEnumeration udp, string value);

		// Token: 0x0600052D RID: 1325
		public extern void SetUDPValue(UDPBoolean udp, [MarshalAs(UnmanagedType.U1)] bool value);

		// Token: 0x0600052E RID: 1326
		public extern void SetUDPValue(UDPInteger udp, int value);

		// Token: 0x0600052F RID: 1327
		public extern void SetUDPValue(UDPString udp, string value);

		// Token: 0x06000530 RID: 1328
		public extern void SetUDPValue(UDPDouble udp, double value);

		// Token: 0x06000531 RID: 1329
		public extern string GetUDPValue(UDPEnumeration udp);

		// Token: 0x06000532 RID: 1330
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool GetUDPValue(UDPBoolean udp);

		// Token: 0x06000533 RID: 1331
		public extern int GetUDPValue(UDPInteger udp);

		// Token: 0x06000534 RID: 1332
		public extern string GetUDPValue(UDPString udp);

		// Token: 0x06000535 RID: 1333
		public extern double GetUDPValue(UDPDouble udp);
	}
}
