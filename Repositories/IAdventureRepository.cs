using Lab8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adventure.Repositories
{
    public interface IAdventureRepository
    {
        AdventureModel Get(int id);
        Task<List<AdventureModel>> GetList();
        Task<List<AdventureModel>> SearchList(string searchText);
        void Save(AdventureModel Adventure);
        void Delete(int id);
    }
}