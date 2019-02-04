using Lab8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Injury.Repositories
{
    public interface IInjuryRepository
    {
        InjuryModel Get(int id);
        Task<List<InjuryModel>> GetList();
        Task<List<InjuryModel>> SearchList(string searchText);
        void Save(InjuryModel Injury);
        void Delete(int id);
    }
}