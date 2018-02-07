using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Adra.Common.IdentitySync.Contracts;
using Services;
using Services.Util;
using SharedModels;

namespace EngagementMessageFixer
{
    class EngagementMessageFixerController
    {

        private static EngagementService _engagementService = new EngagementService();
        private static IntegrationService _integrationService = new IntegrationService();


        static void Main(string[] args)
        {
            // read the text file which contains missing guids
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\poornimak\source\repos\EngagementMessageFixer\MissingGUIDs.txt");
            Debug.WriteLine(lines.Length); // number of guids in the file
            // Display the file contents by using a foreach loop.           
            foreach (string line in lines)
            {
                Guid engGuid = new Guid(WebUtility.UrlDecode(line));    // create the guids
                SendMessageToQueue(engGuid);
            }
        }

        private static void SendMessageToQueue(Guid engGuid)
        {
            // get the engagement by guid
            var engagement = _engagementService.GetEngagementByGuid(engGuid);
            // get the applications of the engagement
            int[] applicationList = _engagementService.GetApplicationofEngagementByGuid(engGuid);

            // generate the app list
            var appList = new List<Enums.Application>();
            foreach (var app in applicationList)
            {
                if (app == (int)EnumsShared.AppId.Balancer)
                {
                    appList.Add(Enums.Application.Balancer);
                }

                if (app == (int)EnumsShared.AppId.TaskManager)
                {
                    appList.Add(Enums.Application.TaskManager);
                }
            }

            // generate the message object
            var engagementDto = new Adra.Common.IdentitySync.Contracts.Engagement
            {
                CustomerId = engagement.CustomerId,
                EngagementGuid = engagement.EngagementGuid,
                EngagementName = engagement.EngagementName,
                ActiveStatus = engagement.Active,
                Applications = appList
            };         

            // send the message
            NotifyApplication(ChangeType.EngagementAdded, engagementDto);
        }

        private static void NotifyApplication(ChangeType changeType, Engagement engagementDto)
        {
            var entityChangeMessage = new EntityChangeMessage
            {
                ChangeType = changeType,
                EntityType = EntityType.Engagement,
                JsonData = Json.Serialize(engagementDto)
            };

            _integrationService.NotifyApplications(entityChangeMessage);
        }


    }
}
