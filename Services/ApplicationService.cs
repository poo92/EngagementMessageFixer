using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Repositories;

namespace Services
{
    public class ApplicationService
    {
        private ApplicationRepository _applicationRepository = new ApplicationRepository();
        public IQueryable<Application> GetAllApplications()
        {
            return _applicationRepository.GetAllApplications();
        }
    }
}
