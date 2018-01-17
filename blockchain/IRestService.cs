using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace blockchain
{
    public interface IRestService
    {
        Task<List<User>> GetUsers();
    }
}
