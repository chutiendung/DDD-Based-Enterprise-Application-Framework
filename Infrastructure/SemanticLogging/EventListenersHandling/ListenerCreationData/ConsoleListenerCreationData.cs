﻿using Microsoft.Practices.EnterpriseLibrary.SemanticLogging.Formatters;

namespace Infrastructure.SemanticLogging.EventListenersHandling.ListenerCreationData
{
    public class ConsoleListenerCreationData : IListenerCreationData
    {
        public IEventTextFormatter EventTextFormatter { get; set; }

        public IConsoleColorMapper ConsoleColorMapper { get; set; }

    }
}
