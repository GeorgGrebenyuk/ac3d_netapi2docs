using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020008A7 RID: 2215
	[Wrapper("AeccDbPointsNode")]
	public sealed class CogoPointCollection : IEnumerable<ObjectId>
	{
		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x060010FD RID: 4349
		public extern uint Count { get; }

		// Token: 0x060010FE RID: 4350
		public extern ObjectId GetPointByPointNumber(uint pointNumber);

		// Token: 0x060010FF RID: 4351
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Contains(uint pointNumber);

		// Token: 0x06001100 RID: 4352
		public extern ObjectIdCollection Add(Point3dCollection locations, string desc, [MarshalAs(UnmanagedType.U1)] bool useDescriptionKey, [MarshalAs(UnmanagedType.U1)] bool matchOnParams, [MarshalAs(UnmanagedType.U1)] bool useNextPointNumSetting);

		// Token: 0x06001101 RID: 4353
		public extern ObjectIdCollection Add(Point3dCollection locations, string desc, [MarshalAs(UnmanagedType.U1)] bool useNextPointNumSetting);

		// Token: 0x06001102 RID: 4354
		public extern ObjectIdCollection Add(Point3dCollection locations, [MarshalAs(UnmanagedType.U1)] bool useNextPointNumSetting);

		// Token: 0x06001103 RID: 4355
		public extern ObjectId Add(Point3d location, string desc, [MarshalAs(UnmanagedType.U1)] bool useDescriptionKey, [MarshalAs(UnmanagedType.U1)] bool matchOnParams, [MarshalAs(UnmanagedType.U1)] bool useNextPointNumSetting);

		// Token: 0x06001104 RID: 4356
		public extern ObjectId Add(Point3d location, string desc, [MarshalAs(UnmanagedType.U1)] bool useNextPointNumSetting);

		// Token: 0x06001105 RID: 4357
		public extern ObjectId Add(Point3d location, [MarshalAs(UnmanagedType.U1)] bool useNextPointNumSetting);

		// Token: 0x06001106 RID: 4358
		public extern void Remove(ObjectId pointId);

		// Token: 0x06001107 RID: 4359
		public extern void Remove(uint pointNumber);

		// Token: 0x06001108 RID: 4360
		public extern void Clear();

		// Token: 0x06001109 RID: 4361
		public extern ObjectIdCollection SetPointNumber(IEnumerable<ObjectId> pointIds, int additiveFactor);

		// Token: 0x0600110A RID: 4362
		public extern ObjectId SetPointNumber(ObjectId pointId, uint pointNumber);

		// Token: 0x0600110B RID: 4363
		public extern ObjectIdCollection SetElevation(IEnumerable<ObjectId> pointIds, IEnumerable<double> elevations);

		// Token: 0x0600110C RID: 4364
		public extern ObjectIdCollection SetElevation(IEnumerable<ObjectId> pointIds, double elevation);

		// Token: 0x0600110D RID: 4365
		public extern ObjectId SetElevation(ObjectId pointId, double elevation);

		// Token: 0x0600110E RID: 4366
		public extern ObjectIdCollection SetElevationByOffset(IEnumerable<ObjectId> pointIds, IEnumerable<double> offsets);

		// Token: 0x0600110F RID: 4367
		public extern ObjectIdCollection SetElevationByOffset(IEnumerable<ObjectId> pointIds, double offset);

		// Token: 0x06001110 RID: 4368
		public extern ObjectId SetElevationByOffset(ObjectId pointId, double offset);

		// Token: 0x06001111 RID: 4369
		public extern ObjectIdCollection SetElevationBySurface(IEnumerable<ObjectId> pointIds, ObjectId surfaceId);

		// Token: 0x06001112 RID: 4370
		public extern ObjectId SetElevationBySurface(ObjectId pointId, ObjectId surfaceId);

		// Token: 0x06001113 RID: 4371
		public extern ObjectIdCollection SetRawDescription(IEnumerable<ObjectId> pointIds, IEnumerable<string> rawDescs);

		// Token: 0x06001114 RID: 4372
		public extern ObjectIdCollection SetRawDescription(IEnumerable<ObjectId> pointIds, string rawDesc);

		// Token: 0x06001115 RID: 4373
		public extern ObjectId SetRawDescription(ObjectId pointId, string rawDesc);

		// Token: 0x06001116 RID: 4374
		public extern ObjectIdCollection SetStyleId(IEnumerable<ObjectId> pointIds, IEnumerable<ObjectId> styleIds);

		// Token: 0x06001117 RID: 4375
		public extern ObjectIdCollection SetStyleId(IEnumerable<ObjectId> pointIds, ObjectId styleId);

		// Token: 0x06001118 RID: 4376
		public extern ObjectId SetStyleId(ObjectId pointId, ObjectId styleId);

		// Token: 0x06001119 RID: 4377
		public extern ObjectIdCollection SetLabelStyleId(IEnumerable<ObjectId> pointIds, IEnumerable<ObjectId> styleIds);

		// Token: 0x0600111A RID: 4378
		public extern ObjectIdCollection SetLabelStyleId(IEnumerable<ObjectId> pointIds, ObjectId styleId);

		// Token: 0x0600111B RID: 4379
		public extern ObjectId SetLabelStyleId(ObjectId pointId, ObjectId styleId);

		// Token: 0x0600111C RID: 4380
		public extern ObjectIdCollection SetIsLocked(IEnumerable<ObjectId> pointIds, IEnumerable<bool> values);

		// Token: 0x0600111D RID: 4381
		public extern ObjectIdCollection SetIsLocked(IEnumerable<ObjectId> pointIds, [MarshalAs(UnmanagedType.U1)] bool isLocked);

		// Token: 0x0600111E RID: 4382
		public extern ObjectId SetIsLocked(ObjectId pointId, [MarshalAs(UnmanagedType.U1)] bool isLocked);

		// Token: 0x0600111F RID: 4383
		public extern ObjectIdCollection SetShowTooltips(IEnumerable<ObjectId> pointIds, IEnumerable<bool> values);

		// Token: 0x06001120 RID: 4384
		public extern ObjectIdCollection SetShowTooltips(IEnumerable<ObjectId> pointIds, [MarshalAs(UnmanagedType.U1)] bool showTooltips);

		// Token: 0x06001121 RID: 4385
		public extern ObjectId SetShowTooltips(ObjectId pointId, [MarshalAs(UnmanagedType.U1)] bool showTooltips);

		// Token: 0x06001122 RID: 4386
		public extern ObjectIdCollection SetMarkerRotation(IEnumerable<ObjectId> pointIds, IEnumerable<double> values);

		// Token: 0x06001123 RID: 4387
		public extern ObjectIdCollection SetMarkerRotation(IEnumerable<ObjectId> pointIds, double rotation);

		// Token: 0x06001124 RID: 4388
		public extern ObjectId SetMarkerRotation(ObjectId pointId, double rotation);

		// Token: 0x06001125 RID: 4389
		public extern ObjectIdCollection SetLabelRotation(IEnumerable<ObjectId> pointIds, IEnumerable<double> values);

		// Token: 0x06001126 RID: 4390
		public extern ObjectIdCollection SetLabelRotation(IEnumerable<ObjectId> pointIds, double rotation);

		// Token: 0x06001127 RID: 4391
		public extern ObjectId SetLabelRotation(ObjectId pointId, double rotation);

		// Token: 0x06001128 RID: 4392
		public extern ObjectIdCollection SetDescriptionFormat(IEnumerable<ObjectId> pointIds, IEnumerable<string> values);

		// Token: 0x06001129 RID: 4393
		public extern ObjectIdCollection SetDescriptionFormat(IEnumerable<ObjectId> pointIds, string descFormat);

		// Token: 0x0600112A RID: 4394
		public extern ObjectId SetDescriptionFormat(ObjectId pointId, string descFormat);

		// Token: 0x0600112B RID: 4395
		public extern ObjectIdCollection SetPointName(IEnumerable<ObjectId> pointIds, IEnumerable<string> values);

		// Token: 0x0600112C RID: 4396
		public extern ObjectId SetPointName(ObjectId pointId, string name);

		// Token: 0x0600112D RID: 4397
		public extern ObjectIdCollection SetEasting(IEnumerable<ObjectId> pointIds, IEnumerable<double> values);

		// Token: 0x0600112E RID: 4398
		public extern ObjectIdCollection SetEasting(IEnumerable<ObjectId> pointIds, double easting);

		// Token: 0x0600112F RID: 4399
		public extern ObjectId SetEasting(ObjectId pointId, double easting);

		// Token: 0x06001130 RID: 4400
		public extern ObjectIdCollection SetNorthing(IEnumerable<ObjectId> pointIds, IEnumerable<double> values);

		// Token: 0x06001131 RID: 4401
		public extern ObjectIdCollection SetNorthing(IEnumerable<ObjectId> pointIds, double northing);

		// Token: 0x06001132 RID: 4402
		public extern ObjectId SetNorthing(ObjectId pointId, double northing);

		// Token: 0x06001133 RID: 4403
		public extern ObjectIdCollection SetScaleXY(IEnumerable<ObjectId> pointIds, IEnumerable<double> values);

		// Token: 0x06001134 RID: 4404
		public extern ObjectIdCollection SetScaleXY(IEnumerable<ObjectId> pointIds, double scale);

		// Token: 0x06001135 RID: 4405
		public extern ObjectId SetScaleXY(ObjectId pointId, double scale);

		// Token: 0x06001136 RID: 4406
		public extern ObjectIdCollection SetScaleZ(IEnumerable<ObjectId> pointIds, IEnumerable<double> values);

		// Token: 0x06001137 RID: 4407
		public extern ObjectIdCollection SetScaleZ(IEnumerable<ObjectId> pointIds, double scale);

		// Token: 0x06001138 RID: 4408
		public extern ObjectId SetScaleZ(ObjectId pointId, double scale);

		// Token: 0x06001139 RID: 4409
		public extern IEnumerator<ObjectId> GetEnumerator();

		// Token: 0x0600113A RID: 4410
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x0600113B RID: 4411
		public static extern CogoPointCollection GetCogoPoints(Database pDatabase);

		// Token: 0x0600113C RID: 4412
		public static extern uint ImportPoints(string pointFileFullName, PointFileFormat fileFormat, [MarshalAs(UnmanagedType.U1)] bool useAdjustedElevation, [MarshalAs(UnmanagedType.U1)] bool shouldTransformCoordinate, [MarshalAs(UnmanagedType.U1)] bool shouldExpandCoordinateData, ObjectId pointGroupId);

		// Token: 0x0600113D RID: 4413
		public static extern uint ImportPoints(string pointFileFullName, PointFileFormat fileFormat, [MarshalAs(UnmanagedType.U1)] bool useAdjustedElevation, [MarshalAs(UnmanagedType.U1)] bool shouldTransformCoordinate, [MarshalAs(UnmanagedType.U1)] bool shouldExpandCoordinateData);

		// Token: 0x0600113E RID: 4414
		public static extern uint ImportPoints(string pointFileFullName, PointFileFormat fileFormat, ObjectId pointGroupId);

		// Token: 0x0600113F RID: 4415
		public static extern uint ImportPoints(string pointFileFullName, PointFileFormat fileFormat);

		// Token: 0x06001140 RID: 4416
		public static extern uint ExportPoints(string pointFileFullName, PointFileFormat fileFormat, [MarshalAs(UnmanagedType.U1)] bool useAdjustedElevation, [MarshalAs(UnmanagedType.U1)] bool shouldTransformCoordinate, [MarshalAs(UnmanagedType.U1)] bool shouldExpandCoordinateData, ObjectId pointGroupId);

		// Token: 0x06001141 RID: 4417
		public static extern uint ExportPoints(string pointFileFullName, PointFileFormat fileFormat, [MarshalAs(UnmanagedType.U1)] bool useAdjustedElevation, [MarshalAs(UnmanagedType.U1)] bool shouldTransformCoordinate, [MarshalAs(UnmanagedType.U1)] bool shouldExpandCoordinateData);

		// Token: 0x06001142 RID: 4418
		public static extern uint ExportPoints(string pointFileFullName, PointFileFormat fileFormat, ObjectId pointGroupId);

		// Token: 0x06001143 RID: 4419
		public static extern uint ExportPoints(string pointFileFullName, PointFileFormat fileFormat);

		// Token: 0x040012BB RID: 4795
		private int <SyntheticNonEmptyStructMarker>;
	}
}
