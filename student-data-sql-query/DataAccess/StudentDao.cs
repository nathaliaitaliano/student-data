using Common;
using System;
using System.Data.SqlClient;

namespace DataAccess
{
    public class StudentDao
    {
        public void Add(Student student)
        {
            string sql = $"Insert into dbo.Students (Name, Surname, Birthday) " +
                $"values('{student.Name}', '{student.Surname}', '{student.DateOfBirth}')";
            ExecuteQuery(sql);
        }

        private  SqlConnection DatabaseConnection()
        {
            string connectionConfiguration;

            connectionConfiguration = @"Data Source=Localhost;Initial Catalog=Vueling;User ID=sa;Password=yourStrong(!)Password";
            return new SqlConnection(connectionConfiguration);
        }

        private void ExecuteQuery(String sql)
        {
            SqlConnection connection = DatabaseConnection();
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand query = new SqlCommand(sql, connection);

            adapter.InsertCommand = query;
            adapter.InsertCommand.ExecuteNonQuery();

            query.Dispose();
            connection.Close();
        }
    }
}
