using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class EngagementApplicationRepository : BaseRepository<EngagementApplication>
    {
        public List<EngagementApplication> GetApplicationofEngagementByGuid(Guid engagementGuid)
        {
            Expression<Func<EngagementApplication, bool>> myFilter = x => x.EngagementGuid == engagementGuid;
            var result = FindBy(myFilter);
            return result.ToList();
        }
    }
}
