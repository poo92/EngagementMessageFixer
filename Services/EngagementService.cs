using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataLayer;
using DataLayer.Repositories;
using SharedModels;

namespace Services
{
    public class EngagementService
    {
        private readonly EngagementRepository _engagementRepository = new EngagementRepository();
        private readonly EngagementApplicationRepository _engagementApplicationRepository = new EngagementApplicationRepository();



        public Engagement GetEngagementByGuid(Guid engagementGuid)
        {
           return _engagementRepository.GetEngagementByGuid(engagementGuid);
        }

        public int[] GetApplicationofEngagementByGuid(Guid engagementGuid)
        {
            
            List<EngagementApplication> applications = _engagementApplicationRepository.GetApplicationofEngagementByGuid(engagementGuid);
            int[] result = new int[applications.Count] ;
            for (int i = 0; i < applications.Count; i++)
            {
                result[i] = applications[i].ApplicationId;
            }
            return result;
        }

    }
}
