using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Lab8.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Lab8;

namespace Coach.Repositories
{
    public class CoachDBRepository : ICoachRepository
    {
        private IConfiguration Configuration;
        private string conString;
        public CoachDBRepository( IConfiguration config)
        {
            Configuration = config;
            
            var sbuilder = new SqlConnectionStringBuilder (
                config.GetConnectionString("DefaultConnection"));
            sbuilder.Password = config["DBPassword"];
            conString = sbuilder.ConnectionString;
        }
        
        public virtual NewsModel Get(int id)
        {
            NewsModel news = null;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("News_Get", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            news = new NewsModel();
                            news.ID = (int) reader["ID"];
                            news.Title = reader["Title"].ToString();
                            news.Message =  reader["Message"].ToString();
                            news.Date = (DateTime) reader["Date"];
                        }
                    }
                }

            }
            return news;
        }

// Make precedure in database
        /* public virtual async Task<List<NewsModel>> SearchList(string searchText)
        {
            List<HealthModel> AdventureList = (await GetList()).Where(a => a.AName.ToLower().Contains(searchText.ToLower())).ToList();
            return AdventureList;
        }*/
        public virtual async Task<List<NewsModel>> GetList()
        {
            List<NewsModel> newsList = new List<NewsModel>();
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("News_GetList", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    await connection.OpenAsync();
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (reader.Read())
                        {
                            NewsModel news = new NewsModel();
                            news.ID = (int) reader["ID"];
                            news.Title = reader["Title"].ToString();
                            news.Message =  reader["Message"].ToString();
                            news.Date = (DateTime) reader["Date"];
                            newsList.Add(news);
                        }
                    }
                }

            }
            return newsList;
        }


        public virtual void Save(NewsModel news)
        {
            if (news.Date == DateTime.MinValue)
                news.Date = DateTime.Now;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("News_Insert", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    command.Parameters.AddWithValue("@Title", news.Title);
                    command.Parameters.AddWithValue("@Message", news.Message);
                    command.Parameters.AddWithValue("@Date", news.Date);
                    int rows = command.ExecuteNonQuery();
                    if (rows <= 0)
                    {
                        Console.Error.WriteLine("Error posting News Option database");
                    }
                }
            }
        }
        public virtual void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("News_Delete", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    
                    command.Parameters.AddWithValue("@ID", id);
                    
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}