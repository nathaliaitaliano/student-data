using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccess
{
    static class Database
    {
        private static SqlConnection Connect()
        {
            string connectionConfiguration;
            connectionConfiguration = @"Data Source=Localhost;Initial Catalog=Vueling;User ID=sa;Password=yourStrong(!)Password";
            return new SqlConnection(connectionConfiguration);
        }

        public static void ExecuteQuery(String sql)
        {
            SqlConnection connection = Connect();
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand query = new SqlCommand(sql, connection);

            adapter.InsertCommand = query;
            adapter.InsertCommand.ExecuteNonQuery();

            query.Dispose();
            connection.Close();
        }

        public static List<object[]> ReadData(String sql)
        {
            SqlConnection connection = Connect();
            connection.Open();

            SqlCommand query = new SqlCommand(sql, connection);
            SqlDataReader dataReader = query.ExecuteReader();

            List<object[]> studentsList = new List<object[]>();

            while (dataReader.Read())
            {
                object[] student = new object[4];
                dataReader.GetValues(student);
                studentsList.Add(student);
            }

            query.Dispose();
            connection.Close();
            return studentsList;
        }

    }
}
