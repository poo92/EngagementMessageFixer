using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adra.Common.IdentitySync.Contracts;
using Services.Contracts.Util;


namespace Services.Util
{
    public class IntegrationService : IIntegrationService, IDisposable
    {

        private readonly IMessageQueue _taskManagerMessageQueue;

        public IntegrationService()
        {
            _taskManagerMessageQueue = new MessageQueueCloudService();
            _taskManagerMessageQueue.InitializeQueue(ConfigurationManager.AppSettings["TaskManagerServiceBusEndPoint"], ConfigurationManager.AppSettings["TaskManagerServiceBusPath"]);

        }

        public void NotifyApplications(EntityChangeMessage entityChangeMessage)
        {
            _taskManagerMessageQueue.SendAsync(entityChangeMessage);
        }

        public void Dispose()
        {
            _taskManagerMessageQueue?.Dispose();
        }
    }
}
