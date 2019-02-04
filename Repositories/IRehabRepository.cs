using Lab8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rehab.Repositories
{
    public interface IRehabRepository
    {
        RehabModel Get(int id);
        Task<List<RehabModel>> GetList();
        /*Need to implement in database */
        //  Task<List<RehabModel>> SearchList(string searchText);
        void Save(RehabModel rehab);
        void Delete(int id);
    }
}