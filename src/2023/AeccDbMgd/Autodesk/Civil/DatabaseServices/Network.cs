using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using Autodesk.Civil.ApplicationServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000C4 RID: 196
	[Wrapper("AeccDbNetwork")]
	public sealed class Network : GeoEntity
	{
		// Token: 0x0600086D RID: 2157
		public static extern ObjectId Create(CivilDocument document, ref string networkName);

		// Token: 0x0600086E RID: 2158
		public extern ObjectIdCollection GetPipeIds();

		// Token: 0x0600086F RID: 2159
		public extern ObjectIdCollection GetStructureIds();

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000870 RID: 2160
		public extern string ModifiedPipePlanLayerName { get; }

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000871 RID: 2161
		// (set) Token: 0x06000872 RID: 2162
		public extern string PipePlanLayerName { get; set; }

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000873 RID: 2163
		// (set) Token: 0x06000874 RID: 2164
		public extern ObjectId PipePlanLayerId { get; set; }

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000875 RID: 2165
		public extern string ModifiedPipeProfileLayerName { get; }

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000876 RID: 2166
		// (set) Token: 0x06000877 RID: 2167
		public extern string PipeProfileLayerName { get; set; }

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000878 RID: 2168
		// (set) Token: 0x06000879 RID: 2169
		public extern ObjectId PipeProfileLayerId { get; set; }

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x0600087A RID: 2170
		public extern string ModifiedStructurePlanLayerName { get; }

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x0600087B RID: 2171
		// (set) Token: 0x0600087C RID: 2172
		public extern string StructurePlanLayerName { get; set; }

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x0600087D RID: 2173
		// (set) Token: 0x0600087E RID: 2174
		public extern ObjectId StructurePlanLayerId { get; set; }

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x0600087F RID: 2175
		public extern string ModifiedStructureProfileLayerName { get; }

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000880 RID: 2176
		// (set) Token: 0x06000881 RID: 2177
		public extern string StructureProfileLayerName { get; set; }

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000882 RID: 2178
		// (set) Token: 0x06000883 RID: 2179
		public extern ObjectId StructureProfileLayerId { get; set; }

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000884 RID: 2180
		public extern string ModifiedPipeNetworkSectionLayerName { get; }

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000885 RID: 2181
		// (set) Token: 0x06000886 RID: 2182
		public extern string PipeNetworkSectionLayerName { get; set; }

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000887 RID: 2183
		// (set) Token: 0x06000888 RID: 2184
		public extern ObjectId PipeNetworkSectionLayerId { get; set; }

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000889 RID: 2185
		// (set) Token: 0x0600088A RID: 2186
		public extern ObjectId PipePlanLabelStyleId { get; set; }

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x0600088B RID: 2187
		// (set) Token: 0x0600088C RID: 2188
		public extern string PipePlanLabelStyleName { get; set; }

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x0600088D RID: 2189
		// (set) Token: 0x0600088E RID: 2190
		public extern ObjectId PipeProfileLabelStyleId { get; set; }

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x0600088F RID: 2191
		// (set) Token: 0x06000890 RID: 2192
		public extern string PipeProfileLabelStyleName { get; set; }

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000891 RID: 2193
		// (set) Token: 0x06000892 RID: 2194
		public extern string PipeNameTemplate { get; set; }

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000893 RID: 2195
		// (set) Token: 0x06000894 RID: 2196
		public extern ObjectId StructurePlanLabelStyleId { get; set; }

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000895 RID: 2197
		// (set) Token: 0x06000896 RID: 2198
		public extern string StructurePlanLabelStyleName { get; set; }

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000897 RID: 2199
		// (set) Token: 0x06000898 RID: 2200
		public extern ObjectId StructureProfileLabelStyleId { get; set; }

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000899 RID: 2201
		// (set) Token: 0x0600089A RID: 2202
		public extern string StructureProfileLabelStyleName { get; set; }

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x0600089B RID: 2203
		// (set) Token: 0x0600089C RID: 2204
		public extern string StructureNameTemplate { get; set; }

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x0600089D RID: 2205
		// (set) Token: 0x0600089E RID: 2206
		public extern ObjectId ReferenceSurfaceId { get; set; }

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x0600089F RID: 2207
		// (set) Token: 0x060008A0 RID: 2208
		public extern string ReferenceSurfaceName { get; set; }

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x060008A1 RID: 2209
		// (set) Token: 0x060008A2 RID: 2210
		public extern ObjectId ReferenceAlignmentId { get; set; }

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x060008A3 RID: 2211
		// (set) Token: 0x060008A4 RID: 2212
		public extern string ReferenceAlignmentName { get; set; }

		// Token: 0x060008A5 RID: 2213
		public static extern ObjectIdCollection FindShortestNetworkPath(ObjectId startPartId, ObjectId endPartId, ref double minLength);

		// Token: 0x060008A6 RID: 2214
		public extern ObjectIdCollection GetSpanningPipePlanLabelIds();

		// Token: 0x060008A7 RID: 2215
		public extern ObjectIdCollection GetSpanningPipeProfileLabelIds();

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x060008A8 RID: 2216
		// (set) Token: 0x060008A9 RID: 2217
		public extern ObjectId PartsListId { get; set; }

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x060008AA RID: 2218
		// (set) Token: 0x060008AB RID: 2219
		public extern string PartsListName { get; set; }

		// Token: 0x060008AC RID: 2220
		public extern void BreakPipe(ObjectId pipeIdToBreak, Point3d breakPoint, ObjectId existingStructureId, ref ObjectId newPipeId);

		// Token: 0x060008AD RID: 2221
		public extern void AddLinePipe(ObjectId pipeFamilyId, ObjectId pipeSizeId, LineSegment3d line, ref ObjectId newPipeId, [MarshalAs(UnmanagedType.U1)] bool applyRules);

		// Token: 0x060008AE RID: 2222
		public extern void AddCurvePipe(ObjectId pipeFamilyId, ObjectId pipeSizeId, Curve3d curve, [MarshalAs(UnmanagedType.U1)] bool clockwise, ref ObjectId newPipeId, [MarshalAs(UnmanagedType.U1)] bool applyRules);

		// Token: 0x060008AF RID: 2223
		public extern void AddStructure(ObjectId structureFamilyId, ObjectId structureSizeId, Point3d location, double rotation, ref ObjectId newStructureId, [MarshalAs(UnmanagedType.U1)] bool applyRules);

		// Token: 0x060008B0 RID: 2224
		public extern void AddStructure(ObjectId structureId);

		// Token: 0x060008B1 RID: 2225
		public extern void MoveParts(ObjectIdCollection partIds, ObjectId dstNetworkId);
	}
}
