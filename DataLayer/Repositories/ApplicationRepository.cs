using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Contracts;

namespace DataLayer.Repositories
{
    public class ApplicationRepository : BaseRepository<Application>, IApplicationRepository
    {      

        public IQueryable<Application> GetAllApplications()
        {
            return GetAll();
        }
    }
}
