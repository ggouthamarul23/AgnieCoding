using Agnie.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Agnie.Business
{
    interface IMagazine
    {
          Task<List<Data>> GetMagazines(Token token, Catagories catagories);
    }
}
