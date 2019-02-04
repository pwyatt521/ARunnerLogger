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

namespace Rehab.Repositories
{
    public class RehabDBRepository : IRehabRepository
    {
        private IConfiguration Configuration;
        private string conString;
        public RehabDBRepository( IConfiguration config)
        {
            Configuration = config;
            
            var sbuilder = new SqlConnectionStringBuilder (
                config.GetConnectionString("DefaultConnection"));
            sbuilder.Password = config["DBPassword"];
            conString = sbuilder.ConnectionString;
        }
        
        public virtual RehabModel Get(int id)
        {
            RehabModel rehab = null;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("Rehab_Get", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            rehab = new RehabModel();
                            rehab.ID = (int) reader["ID"];
                            rehab.Name = reader["Name"].ToString();
                            rehab.Description =  reader["Description"].ToString();
                            rehab.timesUsed = (int) reader["TimesUsed"];
                        }
                    }
                }

            }
            return rehab;
        }

// Make precedure in database
        /* public virtual async Task<List<RehabModel>> SearchList(string searchText)
        {
            List<HealthModel> AdventureList = (await GetList()).Where(a => a.AName.ToLower().Contains(searchText.ToLower())).ToList();
            return AdventureList;
        }*/
        public virtual async Task<List<RehabModel>> GetList()
        {
            List<RehabModel> rehabList = new List<RehabModel>();
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("Rehab_GetList", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    await connection.OpenAsync();
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (reader.Read())
                        {
                            RehabModel rehab = new RehabModel();
                            rehab.ID = (int) reader["ID"];
                            rehab.Name = reader["Name"].ToString();
                            rehab.Description =  reader["Description"].ToString();
                            rehab.timesUsed = (int) reader["TimesUsed"];
                            rehabList.Add(rehab);
                        }
                    }
                }

            }
            return rehabList;
        }


        public virtual void Save(RehabModel rehab)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("Rehab_Insert", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    command.Parameters.AddWithValue("@Name", rehab.Name);
                    command.Parameters.AddWithValue("@Description", rehab.Description);
                    command.Parameters.AddWithValue("@TimesUsed", rehab.timesUsed);
                    int rows = command.ExecuteNonQuery();
                    if (rows <= 0)
                    {
                        Console.Error.WriteLine("Error posting Rehab Option database");
                    }
                }
            }
        }
        public virtual void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("Rehab_Delete", connection))
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