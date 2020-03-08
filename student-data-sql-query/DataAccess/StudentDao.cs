using Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class StudentDao : IStudentDao
    {
        public void ConnectionDatabase()
        {
            string connectionConfiguration;
            SqlConnection connection;

            connectionConfiguration = @"Data Source=Localhost;Initial Catalog=Vueling;User ID=sa;Password=yourStrong(!)Password";
            connection = new SqlConnection(connectionConfiguration);

            connection.Open();
            connection.Close();
        }

        public void Add(Student student);
    }
}
