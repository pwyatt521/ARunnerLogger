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

namespace Health.Repositories
{
    public class HealthDBRepository : IHealthRepository
    {
        private IConfiguration Configuration;
        private string conString;
        public HealthDBRepository( IConfiguration config)
        {
            Configuration = config;
            
            var sbuilder = new SqlConnectionStringBuilder (
                config.GetConnectionString("DefaultConnection"));
            sbuilder.Password = config["DBPassword"];
            conString = sbuilder.ConnectionString;
        }
        
        public virtual HealthModel Get(int id)
        {
            HealthModel Health = null;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("Adventure_Get", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Health = new HealthModel();
                            Health.ID = (int) reader["ID"];
                            Health.AName = reader["AName"].ToString();
                            Health.ADescription =  reader["ADescription"].ToString();
                            Health.ARating = (int) reader["ARating"];
                            Health.PostedBy =  reader["PostedBy"].ToString();
                        }
                    }
                }

            }
            return Health;
        }


        public virtual async Task<List<HealthModel>> SearchList(string searchText)
        {
            List<HealthModel> HealthList = (await GetList()).Where(a => a.AName.ToLower().Contains(searchText.ToLower())).ToList();
            return HealthList;
        }
        public virtual async Task<List<HealthModel>> GetList()
        {
            List<HealthModel> HealthList = new List<HealthModel>();
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("Adventure_GetList", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    await connection.OpenAsync();
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (reader.Read())
                        {
                            HealthModel Health = new HealthModel();
                            Health.ID = (int) reader["ID"];
                            Health.AName = reader["AName"].ToString();
                            Health.ADescription =  reader["ADescription"].ToString();
                            Health.ARating = (int) reader["ARating"];
                            Health.PostedBy =  reader["PostedBy"].ToString();
                        
                            HealthList.Add(Health);
                        }
                    }
                }

            }
            return HealthList;
        }


        public virtual void Save(HealthModel Health)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("Adventure_InsertUpdate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    command.Parameters.AddWithValue("@ID", Health.ID);
                    command.Parameters.AddWithValue("@AName", Health.AName);
                    command.Parameters.AddWithValue("@ADescription", Health.ADescription);
                    command.Parameters.AddWithValue("@ARating", Health.ARating);
                    command.Parameters.AddWithValue("@PostedBy", Health.PostedBy);
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
                using (SqlCommand command = new SqlCommand("Adventure_Delete", connection))
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