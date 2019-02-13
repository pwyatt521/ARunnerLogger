using Lab8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coach.Repositories
{
    public interface ICoachRepository
    {
        NewsModel Get(int id);
        Task<List<NewsModel>> GetList();
        /*Need to implement in database */
        //  Task<List<CoachModel>> SearchList(string searchText);
        void Save(NewsModel Coach);
        void Delete(int id);
    }
}