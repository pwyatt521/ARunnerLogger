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

namespace Repositories.Group
{
    public class GroupDBRepository : IGroupRepository
    {
        private IConfiguration Configuration;
        private string conString;
        public GroupDBRepository( IConfiguration config)
        {
            Configuration = config;
            
            var sbuilder = new SqlConnectionStringBuilder (
                config.GetConnectionString("DefaultConnection"));
            sbuilder.Password = config["DBPassword"];
            conString = sbuilder.ConnectionString;
        }
        
        public virtual GroupModel Get(int id)
        {
            GroupModel Group = null;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("Group_Get", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Group = new GroupModel();
                            Group.ID = (int) reader["ID"];
                            Group.Name = reader["Name"].ToString();
                            Group.Description =  reader["Description"].ToString();
                            Group.DateCreated = (DateTime) reader["DateCreated"];
                            Group.Type = reader["Type"].ToString();
                            Group.NumberOfMembers = (int)reader["NumberOfMembers"];
                        }
                    }
                }

            }
            return Group;
        }

// Make precedure in database
        /* public virtual async Task<List<GroupModel>> SearchList(string searchText)
        {
            List<HealthModel> AdventureList = (await GetList()).Where(a => a.AName.ToLower().Contains(searchText.ToLower())).ToList();
            return AdventureList;
        }*/
        public virtual async Task<List<GroupModel>> GetList()
        {
            List<GroupModel> GroupList = new List<GroupModel>();
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("Group_GetList", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    await connection.OpenAsync();
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (reader.Read())
                        {
                            GroupModel Group = new GroupModel();
                            Group.ID = (int) reader["ID"];
                            Group.Name = reader["Name"].ToString();
                            Group.Description =  reader["Description"].ToString();
                            Group.DateCreated = (DateTime) reader["DateCreated"];
                            Group.Type = reader["Type"].ToString();
                            Group.NumberOfMembers = (int)reader["NumberOfMembers"];
                            GroupList.Add(Group);
                        }
                    }
                }

            }
            return GroupList;
        }


        public virtual void Save(GroupModel Group)
        {
            if (Group.DateCreated == DateTime.MinValue)
                Group.DateCreated = DateTime.Now;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("Group_Insert", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    command.Parameters.AddWithValue("@Name", Group.Name);
                    command.Parameters.AddWithValue("@Description", Group.Description);
                    command.Parameters.AddWithValue("@DateCreated", Group.DateCreated);
                    command.Parameters.AddWithValue("@Type", Group.Type);
                    command.Parameters.AddWithValue("@NumberOfMembers", Group.NumberOfMembers);
 
                    int rows = command.ExecuteNonQuery();
                    if (rows <= 0)
                    {
                        Console.Error.WriteLine("Error posting Group Option database");
                    }
                }
            }
        }

        public virtual void Update(GroupModel Group)
        {
            if (Group.DateCreated == DateTime.MinValue)
                Group.DateCreated = DateTime.Now;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("Group_Update", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    command.Parameters.AddWithValue("@Name", Group.Name);
                    command.Parameters.AddWithValue("@Description", Group.Description);
                    command.Parameters.AddWithValue("@Type", Group.Type); 
                    int rows = command.ExecuteNonQuery();
                    if (rows <= 0)
                    {
                        Console.Error.WriteLine("Error posting Group Option database");
                    }
                }
            }
        }
        public virtual void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("Group_Delete", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    
                    command.Parameters.AddWithValue("@ID", id);
                    
                    command.ExecuteNonQuery();
                }
            }
        }
        public virtual void AddMember(int id)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand("Add_Group_Member", connection))
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