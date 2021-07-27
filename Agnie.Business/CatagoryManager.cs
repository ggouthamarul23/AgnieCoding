using Agnie.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks; 

namespace Agnie.Business
{
    public class CatagoryManager : ICatagoryManager
    {

        readonly string Endpoint_url = ConfigurationManager.AppSettings["MagazineStore_Endpoint"];
        /// <summary>
        /// GetCatagories - gets all the catagories
        /// </summary>
        /// <param name="token"></param>
        /// <returns>Catagories</returns>
        public async Task<Catagories> GetCatagories(Token token)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    //Catagories catagories = new Catagories();
                    using (var response = await httpClient.GetAsync(Endpoint_url + "categories/" + token.token))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        Catagories catagories = JsonConvert.DeserializeObject<Catagories>(apiResponse);
                        return catagories;
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
