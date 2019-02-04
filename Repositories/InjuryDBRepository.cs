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

namespace Injury.Repositories
{
    public class InjuryDBRepository : IInjuryRepository
    {
        private IConfiguration configuration;
        private string conString;
        public InjuryDBRepository(IConfiguration config)
        {
            configuration = config;

            var sbuilder = new SqlConnectionStringBuilder (
                config.GetConnectionString("DefaultConnection"));
            sbuilder.Password = config["DBPassword"];
            conString = sbuilder.ConnectionString;
        }
        
        public virtual InjuryModel Get(int id)
        {
            
            InjuryModel Injury = null;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("Book_Get", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Injury = new InjuryModel();
                            Injury.ID = (int) reader["ID"];
                            Injury.BTitle = reader["BTitle"].ToString();
                            Injury.BAuthor = reader["BAuthor"].ToString();
                            Injury.BSummary =  reader["BSummary"].ToString();
                            Injury.BRating = (int) reader["BRating"];
                            Injury.BLength = (int) reader["BLength"];
                            Injury.PostedBy =  reader["PostedBy"].ToString();
                        }
                    }
                }

            }
            return Injury;
        }


        public virtual async Task<List<InjuryModel>> SearchList(string searchText)
        {
            List<InjuryModel> InjuryList = (await GetList()).Where(a => a.BTitle.ToLower().Contains(searchText.ToLower())).ToList();
            return InjuryList;
        }
        public virtual async Task<List<InjuryModel>> GetList()
        {
            List<InjuryModel> InjuryList = new List<InjuryModel>();
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("Book_GetList", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    await connection.OpenAsync();
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (reader.Read())
                        {
                            InjuryModel Injury = new InjuryModel();
                            Injury.ID = (int) reader["ID"];
                            Injury.BTitle = reader["BTitle"].ToString();
                            Injury.BAuthor = reader["BAuthor"].ToString();
                            Injury.BSummary =  reader["BSummary"].ToString();
                            Injury.BRating = (int) reader["BRating"];
                            Injury.BLength = (int) reader["BLength"];
                            Injury.PostedBy =  reader["PostedBy"].ToString();
                            InjuryList.Add(Injury);
                        }
                    }
                }

            }
            return InjuryList;
        }


        public virtual void Save(InjuryModel Injury)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("Book_InsertUpdate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    command.Parameters.AddWithValue("@ID", Injury.ID);
                    command.Parameters.AddWithValue("@BTitle", Injury.BTitle);
                    command.Parameters.AddWithValue("@BAuthor", Injury.BAuthor);
                    command.Parameters.AddWithValue("@BSummary", Injury.BSummary);
                    command.Parameters.AddWithValue("@BRating", Injury.BRating);
                    command.Parameters.AddWithValue("@BLength", Injury.BLength);
                    command.Parameters.AddWithValue("@PostedBy", Injury.PostedBy);
                    int rows = command.ExecuteNonQuery();
                    if (rows <= 0)
                    {
                        Console.Error.WriteLine("Didn't Work");
                    }
                }
            }
        }
        public virtual void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("Book_Delete", connection))
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