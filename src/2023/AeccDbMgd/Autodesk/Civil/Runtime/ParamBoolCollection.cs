using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.Runtime
{
	// Token: 0x02001032 RID: 4146
	[DefaultMember("Item")]
	public sealed class ParamBoolCollection : ParamCollectionBase<Autodesk::Civil::Runtime::ParamBool,Autodesk::Civil::Runtime::ParamBool\u0020^>
	{
		// Token: 0x0600211A RID: 8474
		public extern ParamBool Add(string name, [MarshalAs(UnmanagedType.U1)] bool value);
	}
}
