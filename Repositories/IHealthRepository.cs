using Lab8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Health.Repositories
{
    public interface IHealthRepository
    {
        HealthModel Get(int id);
        Task<List<HealthModel>> GetList();
        Task<List<HealthModel>> SearchList(string searchText);
        void Save(HealthModel Health);
        void Delete(int id);
    }
}