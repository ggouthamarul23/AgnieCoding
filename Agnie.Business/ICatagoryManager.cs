using Agnie.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Agnie.Business
{
    public interface ICatagoryManager
    {
        Task<Catagories> GetCatagories(Token token);
    }
}
