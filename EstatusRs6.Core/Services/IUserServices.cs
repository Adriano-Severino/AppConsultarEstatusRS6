using EstatusRs6.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace EstatusRs6.Core.Services
{
    public interface IUserServices
    {
        Task<Root> GetUser(string name);
        Task<List<Root>> GetUsers();
    }
}
