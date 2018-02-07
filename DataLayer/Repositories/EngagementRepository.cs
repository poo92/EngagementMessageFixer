using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Contracts;



namespace DataLayer.Repositories
{
    public class EngagementRepository : BaseRepository<Engagement>, IEngagementRepository
    { 
        public Engagement GetEngagementByGuid(Guid engagementGuid)
        {
            Expression<Func<Engagement, bool>> myFilter = x => x.EngagementGuid == engagementGuid;
            var result = FindBy(myFilter);
            return result.Single();
        }

        

    }
}
