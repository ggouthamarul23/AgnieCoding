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
    public class MagazineManager : IMagazine
    {

        readonly string Endpoint_url = ConfigurationManager.AppSettings["MagazineStore_Endpoint"];

        List<Data> magazine_info = new List<Data>();
        /// <summary>
        /// GetMagazines takes catagories as a parameter and retrives all magazines
        /// </summary>
        /// <param name="token"></param>
        /// <param name="catagories"></param>
        /// <returns></returns>
        public async Task<List<Data>> GetMagazines(Token token, Catagories catagories)
        {
            try
            {

                foreach (var item in catagories.data)
                {
                    using (var httpClient = new HttpClient())
                    {

                        using (var response = await httpClient.GetAsync(Endpoint_url + "magazines/" + token.token + "/" + item))
                        {
                            string apiResponse = await response.Content.ReadAsStringAsync();
                            var magazineList = JsonConvert.DeserializeObject<Magazine>(apiResponse);
                            magazine_info.AddRange(magazineList.data);
                        }
                    }
                }
                return magazine_info;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
