using System;
using Serilog.Core;
using Serilog.Events;

namespace Autodesk.Civil.Logging
{
	// Token: 0x02000023 RID: 35
	public class ThreadIdEnricher : ILogEventEnricher
	{
		// Token: 0x06000011 RID: 17
		public virtual extern void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory);

		// Token: 0x06000012 RID: 18
		public extern ThreadIdEnricher();
	}
}
