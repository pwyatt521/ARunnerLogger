using Lab8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adventure.Repositories
{
    public interface IAdventureRepository
    {
        HealthModel Get(int id);
        Task<List<HealthModel>> GetList();
        Task<List<HealthModel>> SearchList(string searchText);
        void Save(HealthModel Adventure);
        void Delete(int id);
    }
}