using System;

namespace Autodesk.Civil
{
	// Token: 0x0200019F RID: 415
	public enum AnchorPointType
	{
		// Token: 0x040004B4 RID: 1204
		Start = 134263041,
		// Token: 0x040004B5 RID: 1205
		Middle,
		// Token: 0x040004B6 RID: 1206
		End,
		// Token: 0x040004B7 RID: 1207
		TopLeft,
		// Token: 0x040004B8 RID: 1208
		TopCenter,
		// Token: 0x040004B9 RID: 1209
		TopRight,
		// Token: 0x040004BA RID: 1210
		MiddleLeft,
		// Token: 0x040004BB RID: 1211
		MiddleCenter,
		// Token: 0x040004BC RID: 1212
		MiddleRight,
		// Token: 0x040004BD RID: 1213
		BottomLeft,
		// Token: 0x040004BE RID: 1214
		BottomCenter,
		// Token: 0x040004BF RID: 1215
		BottomRight,
		// Token: 0x040004C0 RID: 1216
		InsertionPoint,
		// Token: 0x040004C1 RID: 1217
		Center,
		// Token: 0x040004C2 RID: 1218
		PointOfIntersection,
		// Token: 0x040004C3 RID: 1219
		Station = 134263072,
		// Token: 0x040004C4 RID: 1220
		PI = 134263074,
		// Token: 0x040004C5 RID: 1221
		PVI = 134263088,
		// Token: 0x040004C6 RID: 1222
		CurveStart,
		// Token: 0x040004C7 RID: 1223
		CurveEnd,
		// Token: 0x040004C8 RID: 1224
		PVIDimension,
		// Token: 0x040004C9 RID: 1225
		CurveStartDimension,
		// Token: 0x040004CA RID: 1226
		CurveMidDimension,
		// Token: 0x040004CB RID: 1227
		CurveEndDimension,
		// Token: 0x040004CC RID: 1228
		CurveHighPoint,
		// Token: 0x040004CD RID: 1229
		CurveLowPoint,
		// Token: 0x040004CE RID: 1230
		TangentStart,
		// Token: 0x040004CF RID: 1231
		TangentMiddle,
		// Token: 0x040004D0 RID: 1232
		TangentEnd,
		// Token: 0x040004D1 RID: 1233
		TangentStartDimension,
		// Token: 0x040004D2 RID: 1234
		TangentMiddleDimension,
		// Token: 0x040004D3 RID: 1235
		TangentEndDimension,
		// Token: 0x040004D4 RID: 1236
		TangentInStart = 134263075,
		// Token: 0x040004D5 RID: 1237
		TangentInMiddle,
		// Token: 0x040004D6 RID: 1238
		TangentOutMiddle = 134263078,
		// Token: 0x040004D7 RID: 1239
		TangentOutEnd,
		// Token: 0x040004D8 RID: 1240
		StationExtension = 134263103,
		// Token: 0x040004D9 RID: 1241
		PVIStart = 134263120,
		// Token: 0x040004DA RID: 1242
		PVIEnd,
		// Token: 0x040004DB RID: 1243
		PVIStartDimension,
		// Token: 0x040004DC RID: 1244
		PVIEndDimension,
		// Token: 0x040004DD RID: 1245
		CurveMid = 134263128,
		// Token: 0x040004DE RID: 1246
		CurveHighPointDimension,
		// Token: 0x040004DF RID: 1247
		CurveLowPointDimension,
		// Token: 0x040004E0 RID: 1248
		CurveStartInView = 134263184,
		// Token: 0x040004E1 RID: 1249
		CurveEndInView,
		// Token: 0x040004E2 RID: 1250
		CurveStartInViewDimension,
		// Token: 0x040004E3 RID: 1251
		CurveEndInViewDimension,
		// Token: 0x040004E4 RID: 1252
		TangentStartInView,
		// Token: 0x040004E5 RID: 1253
		TangentEndInView,
		// Token: 0x040004E6 RID: 1254
		TangentStartInViewDimension,
		// Token: 0x040004E7 RID: 1255
		TangentEndInViewDimension,
		// Token: 0x040004E8 RID: 1256
		PVIStartInView,
		// Token: 0x040004E9 RID: 1257
		PVIEndInView,
		// Token: 0x040004EA RID: 1258
		PVIStartInViewDimension,
		// Token: 0x040004EB RID: 1259
		PVIEndInViewDimension,
		// Token: 0x040004EC RID: 1260
		StartExtension = 134263107,
		// Token: 0x040004ED RID: 1261
		MiddleExtension,
		// Token: 0x040004EE RID: 1262
		EndExtension,
		// Token: 0x040004EF RID: 1263
		Offset = 134263152,
		// Token: 0x040004F0 RID: 1264
		OffsetExtension,
		// Token: 0x040004F1 RID: 1265
		GradeBreak,
		// Token: 0x040004F2 RID: 1266
		GradeBreakExtension,
		// Token: 0x040004F3 RID: 1267
		Centerline,
		// Token: 0x040004F4 RID: 1268
		TopOuterDiameter,
		// Token: 0x040004F5 RID: 1269
		TopInnerDiameter,
		// Token: 0x040004F6 RID: 1270
		BottomOuterDiameter,
		// Token: 0x040004F7 RID: 1271
		BottomInnerDiameter,
		// Token: 0x040004F8 RID: 1272
		PipeDimension,
		// Token: 0x040004F9 RID: 1273
		StructureDimension,
		// Token: 0x040004FA RID: 1274
		SectionViewTop = 134263168,
		// Token: 0x040004FB RID: 1275
		SectionViewBottom,
		// Token: 0x040004FC RID: 1276
		SectionViewTopAtStart,
		// Token: 0x040004FD RID: 1277
		SectionViewBottomAtStart,
		// Token: 0x040004FE RID: 1278
		SectionViewTopAtMiddle,
		// Token: 0x040004FF RID: 1279
		SectionViewBottomAtMiddle,
		// Token: 0x04000500 RID: 1280
		SectionViewTopAtEnd,
		// Token: 0x04000501 RID: 1281
		SectionViewBottomAtEnd,
		// Token: 0x04000502 RID: 1282
		SegmentMiddleSuperelevationBand = 134264080,
		// Token: 0x04000503 RID: 1283
		Insertion = 134264184,
		// Token: 0x04000504 RID: 1284
		Dimension,
		// Token: 0x04000505 RID: 1285
		LabelLocation = 134263296,
		// Token: 0x04000506 RID: 1286
		BandTop = 134263104,
		// Token: 0x04000507 RID: 1287
		BandMiddle,
		// Token: 0x04000508 RID: 1288
		BandBottom,
		// Token: 0x04000509 RID: 1289
		PreviousStationBandTop = 134264160,
		// Token: 0x0400050A RID: 1290
		PreviousStationBandMiddle,
		// Token: 0x0400050B RID: 1291
		PreviousStationBandBottom,
		// Token: 0x0400050C RID: 1292
		LengthMidBandTop,
		// Token: 0x0400050D RID: 1293
		LengthMidBandMiddle,
		// Token: 0x0400050E RID: 1294
		LengthMidBandBottom,
		// Token: 0x0400050F RID: 1295
		NextStationBandTop,
		// Token: 0x04000510 RID: 1296
		NextStationBandMiddle,
		// Token: 0x04000511 RID: 1297
		NextStationBandBottom,
		// Token: 0x04000512 RID: 1298
		SegmentStartAndBandTop = 134264082,
		// Token: 0x04000513 RID: 1299
		SegmentStartAndBandMiddle,
		// Token: 0x04000514 RID: 1300
		SegmentStartAndBandBot,
		// Token: 0x04000515 RID: 1301
		SegmentMiddleAndBandTop,
		// Token: 0x04000516 RID: 1302
		SegmentMiddleAndBandMiddle,
		// Token: 0x04000517 RID: 1303
		SegmentMiddleAndBandBot,
		// Token: 0x04000518 RID: 1304
		SegmentEndAndBandTop,
		// Token: 0x04000519 RID: 1305
		SegmentEndAndBandMiddle,
		// Token: 0x0400051A RID: 1306
		SegmentEndAndBandBot,
		// Token: 0x0400051B RID: 1307
		SchematicLineStart,
		// Token: 0x0400051C RID: 1308
		SchematicLineMid,
		// Token: 0x0400051D RID: 1309
		SchematicLineEnd,
		// Token: 0x0400051E RID: 1310
		PreviousOffsetBandTop = 134264144,
		// Token: 0x0400051F RID: 1311
		PreviousOffsetBandMiddle,
		// Token: 0x04000520 RID: 1312
		PreviousOffsetBandBottom,
		// Token: 0x04000521 RID: 1313
		NextOffsetBandTop = 134264150,
		// Token: 0x04000522 RID: 1314
		NextOffsetBandMiddle,
		// Token: 0x04000523 RID: 1315
		NextOffsetBandBottom
	}
}
