using System;
using System.Threading;
using System.Threading.Tasks;
using Adra.Common.IdentitySync.Contracts;
using Services.Contracts.Util;
using Microsoft.ServiceBus.Messaging;
using Microsoft.Practices.TransientFaultHandling;
using Microsoft.Practices.EnterpriseLibrary.WindowsAzure.TransientFaultHandling.ServiceBus;
using System.Diagnostics;

namespace Services.Util
{
    public class MessageQueueCloudService : IMessageQueue
    {
        private QueueClient _queueClient;
        private Microsoft.Practices.TransientFaultHandling.RetryPolicy _retryPolicy;
        private readonly ManualResetEvent _completedEvent = new ManualResetEvent(false);
        public void InitializeQueue(string connectionString, string path)
        {
            _queueClient = QueueClient.CreateFromConnectionString(connectionString, path);           
            var retryStrategy = new FixedInterval(4, TimeSpan.FromSeconds(1));
            _retryPolicy = new RetryPolicy<ServiceBusTransientErrorDetectionStrategy>(retryStrategy);
            //Get notifications from retries from Transient Fault Handling Application Block code

            _retryPolicy.Retrying += (sender, args) =>
            {
                // Log details of the retry.

                //Logging the notification details to the application trace.
            };
        }
        public async Task<bool> SendAsync(EntityChangeMessage entityChangeMessage)
        {
#if DEBUG
            if (_queueClient == null)
            {
                throw new Exception("Queue is not yet initialized. Call InitializeQueue before calling send");
            }
            var message = new BrokeredMessage(entityChangeMessage.ToJsonStream(), true);            
            _retryPolicy.ExecuteAction(() =>
            {
                _queueClient.Send(message);
            });
#endif

            return await Task.FromResult(true);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            _completedEvent.Dispose();
            _queueClient.Close();
            _completedEvent.Set();
        }
    }
}
