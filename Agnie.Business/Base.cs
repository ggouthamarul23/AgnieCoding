using Agnie.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Agnie.Business
{
    public class Base
    {        
        public static Token token;
        static Base()
        {
            try
            {
               
                using (var client = new WebClient()) //WebClient  
                {
                    client.Headers.Add("Content-Type:application/json"); //Content-Type  
                    client.Headers.Add("Accept:application/json");
                    var result = client.DownloadString(ConfigurationManager.AppSettings["MagazineStore_Endpoint"] + "token"); //URI  
                    token = JsonConvert.DeserializeObject<Token>(result);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
