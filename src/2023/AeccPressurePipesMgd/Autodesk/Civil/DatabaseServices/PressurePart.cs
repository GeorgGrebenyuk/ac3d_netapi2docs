using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using Autodesk.Civil.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000005 RID: 5
	[Wrapper("AeccDbPressurePart")]
	public abstract class PressurePart : GeoEntity
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600007E RID: 126
		// (set) Token: 0x0600007F RID: 127
		public virtual extern Point3d Position { get; set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000080 RID: 128
		[DeprecatedVersion(CivilVersion.Civil2021)]
		[Obsolete("Useless property", true)]
		public virtual extern ParamBoolCollection ParamsBool { get; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000081 RID: 129
		[Obsolete("Useless property", true)]
		[DeprecatedVersion(CivilVersion.Civil2021)]
		public virtual extern ParamDoubleCollection ParamsDouble { get; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000082 RID: 130
		[Obsolete("Useless property", true)]
		[DeprecatedVersion(CivilVersion.Civil2021)]
		public virtual extern ParamLongCollection ParamsLong { get; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000083 RID: 131
		[DeprecatedVersion(CivilVersion.Civil2021)]
		[Obsolete("Useless property", true)]
		public virtual extern ParamStringCollection ParamsString { get; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000084 RID: 132
		public override extern string Name { get; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000085 RID: 133
		public extern PressurePartType PartType { get; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000086 RID: 134
		public virtual extern PressurePartDomainType PartDomain { get; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000087 RID: 135
		// (set) Token: 0x06000088 RID: 136
		public virtual extern string PartDescription { get; [Obsolete("Cannot set PartDescription.", true)] [DeprecatedVersion(CivilVersion.Civil2021)] set; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000089 RID: 137
		public extern string PartFamilyName { get; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600008A RID: 138
		public extern ObjectId NetworkId { get; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600008B RID: 139
		public extern string NetworkName { get; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600008C RID: 140
		// (set) Token: 0x0600008D RID: 141
		public extern ObjectId ReferenceSurfaceId { get; set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600008E RID: 142
		public extern string ReferenceSurfaceName { get; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600008F RID: 143
		// (set) Token: 0x06000090 RID: 144
		public extern ObjectId ReferenceAlignmentId { get; set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000091 RID: 145
		public extern string ReferenceAlignmentName { get; }

		// Token: 0x06000092 RID: 146
		public extern void AddToProfileView(ObjectId profileViewId);

		// Token: 0x06000093 RID: 147
		public extern void RemoveFromAllProfileViews();

		// Token: 0x06000094 RID: 148
		public extern void RemoveFromProfileView(ObjectId profileViewId);

		// Token: 0x06000095 RID: 149
		public extern ObjectIdCollection GetProfileViewsDisplayingMe();

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000096 RID: 150
		public extern ObjectId ProfileViewPartId { get; }

		// Token: 0x06000097 RID: 151
		public extern Solid3d Get3dBody();

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000098 RID: 152
		public extern PressureNetworkPartData PartData { get; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000099 RID: 153
		public extern int ConnectionCount { get; }

		// Token: 0x0600009A RID: 154
		public extern PressurePartConnection GetConnectionAt(int index);

		// Token: 0x0600009B RID: 155
		public extern void DisconnectAt(int index);

		// Token: 0x0600009C RID: 156
		[HandleProcessCorruptedStateExceptions]
		protected override extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x04000067 RID: 103
		private int <SyntheticNonEmptyStructMarker>;
	}
}
