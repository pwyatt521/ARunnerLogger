using Lab8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkOut.Repositories
{
    public interface IWorkOutRepository
    {
        WorkOutModel Get(int id);
        Task<List<WorkOutModel>> GetList();
        Task<List<WorkOutModel>> SearchList(string searchText);
        void Save(WorkOutModel WorkOut);
        void Delete(int id);
    }
}