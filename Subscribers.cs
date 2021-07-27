using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Agnie.Domain;
using System.Linq;
using System.Configuration;
using Agnie.Business;
using ConsoleTables;

namespace Agnie
{
    public class Subscribers : Base
    {

        SubssriberManager subssriberManager = new SubssriberManager();

        /// <summary>
        /// GetSubscriberlist - Computes and returns set of subscribers
        /// </summary>
        /// <returns>SubscriberInfo Model</returns>
        public async Task GetSubscriberlist()

        {
            var Subscriberlist = await subssriberManager.GetSubscribers(token);
            ConsoleTable.From<SubscriberInfo>(Subscriberlist).Write();

        }

    }
}
