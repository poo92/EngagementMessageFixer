using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adra.Common.IdentitySync.Contracts;

namespace Services.Contracts.Util
{
    public interface IMessageQueue : IDisposable
    {
        void InitializeQueue(string connectionString, string path);

        Task<bool> SendAsync(EntityChangeMessage entityChangeMessage);
    }
}
