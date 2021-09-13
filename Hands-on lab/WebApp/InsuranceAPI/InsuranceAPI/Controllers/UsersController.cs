using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Web;
using System.Web.Http;
using InsuranceAPI.Models;

namespace InsuranceAPI.Controllers
{
    public class UsersController : ApiController
    {
        private readonly string connectionString = ConfigurationManager.AppSettings["SqlConnectionString"];
        //private readonly string connectionString = Util.EncryptSecret;

        // Get: api/users
        public string Get()
        {
            List<User> users = new List<User>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = conn;
                command.CommandText = "SELECT * FROM [dbo].[User]";
                command.CommandType = System.Data.CommandType.Text;

                conn.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var user = new User
                    {
                        UserId = reader.GetGuid(0),
                        FirstName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        LastName = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        Address = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        City = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        State = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        Zip = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                        Dob = reader.IsDBNull(7) ? (DateTime?)null : (DateTime?)reader.GetDateTime(7),
                        SSN = reader.GetString(8),
                        Gender = reader.IsDBNull(9) ? string.Empty : reader.GetString(9),
                        Email = reader.IsDBNull(10) ? string.Empty : reader.GetString(10)
                    };

                    users.Add(user);
                }
            }

            string jsonString = JsonSerializer.Serialize(users);

            return jsonString;
        }

        // Get: api/users/5
        public string Get(string id)
        {
            List<User> users = new List<User>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = conn;
                command.CommandText = "SELECT * FROM [dbo].[User] WHERE UserId = @UserId";
                command.CommandType = System.Data.CommandType.Text;

                SqlParameter parameter = new SqlParameter("@UserId", id);
                parameter.SqlDbType = System.Data.SqlDbType.NVarChar;

                command.Parameters.Add(parameter);

                conn.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var user = new User
                    {
                        UserId = reader.GetGuid(0),
                        FirstName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        LastName = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        Address = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        City = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        State = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        Zip = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                        Dob = reader.IsDBNull(7) ? (DateTime?)null : (DateTime?)reader.GetDateTime(7),
                        SSN = reader.GetString(8),
                        Gender = reader.IsDBNull(9) ? string.Empty : reader.GetString(9),
                        Email = reader.IsDBNull(10) ? string.Empty : reader.GetString(10)
                    };

                    users.Add(user);
                }
            }

            string jsonString = JsonSerializer.Serialize(users);

            return jsonString;
        }
    }
}