using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200086E RID: 2158
	[Wrapper("AeccDbUserDefinedAttributeClassification")]
	public class UDPClassification
	{
		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06001068 RID: 4200
		public extern string Name { get; }

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06001069 RID: 4201
		public extern UDPCollection UDPs { get; }

		// Token: 0x0600106A RID: 4202
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool ContainsUDP(UDP udp);

		// Token: 0x0600106B RID: 4203
		public extern UDPDouble CreateUDP(AttributeTypeInfoDouble udpTypeInfo, Guid guid);

		// Token: 0x0600106C RID: 4204
		public extern UDPDouble CreateUDP(AttributeTypeInfoDouble udpTypeInfo);

		// Token: 0x0600106D RID: 4205
		public extern UDPEnumeration CreateUDP(AttributeTypeInfoEnum udpTypeInfo, Guid guid);

		// Token: 0x0600106E RID: 4206
		public extern UDPEnumeration CreateUDP(AttributeTypeInfoEnum udpTypeInfo);

		// Token: 0x0600106F RID: 4207
		public extern UDPBoolean CreateUDP(AttributeTypeInfoBool udpTypeInfo, Guid guid);

		// Token: 0x06001070 RID: 4208
		public extern UDPBoolean CreateUDP(AttributeTypeInfoBool udpTypeInfo);

		// Token: 0x06001071 RID: 4209
		public extern UDPInteger CreateUDP(AttributeTypeInfoInt udpTypeInfo, Guid guid);

		// Token: 0x06001072 RID: 4210
		public extern UDPInteger CreateUDP(AttributeTypeInfoInt udpTypeInfo);

		// Token: 0x06001073 RID: 4211
		public extern UDPString CreateUDP(AttributeTypeInfoString udpTypeInfo, Guid guid);

		// Token: 0x06001074 RID: 4212
		public extern UDPString CreateUDP(AttributeTypeInfoString udpTypeInfo);

		// Token: 0x06001075 RID: 4213
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool RemoveUDP(UDP udp);

		// Token: 0x04001274 RID: 4724
		private int <SyntheticNonEmptyStructMarker>;
	}
}
