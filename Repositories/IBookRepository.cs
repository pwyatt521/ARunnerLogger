using Lab8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book.Repositories
{
    public interface IBookRepository
    {
        InjuryModel Get(int id);
        Task<List<InjuryModel>> GetList();
        Task<List<InjuryModel>> SearchList(string searchText);
        void Save(InjuryModel Book);
        void Delete(int id);
    }
}