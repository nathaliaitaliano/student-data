using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccess
{
    static class Database
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(StudentDao));
        private static SqlConnection Connect()
        {
            string connectionConfiguration;
            connectionConfiguration = @"Data Source=Localhost;Initial Catalog=Vueling;User ID=sa;Password=yourStrong(!)Password";
            return new SqlConnection(connectionConfiguration);
        }

        public static void ExecuteQuery(String sql)
        {
            try
            {
                using (SqlConnection connection = Connect())
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlCommand query = new SqlCommand(sql, connection);

                    adapter.InsertCommand = query;
                    adapter.InsertCommand.ExecuteNonQuery();
                }
            }
            catch(InvalidOperationException exception)
            {
                log.Error("Invalid operation exception!", exception);
                throw;
            }
            catch(SqlException exception)
            {
                log.Error("Sql exception!", exception);
                throw;
            }
            catch(InvalidCastException exception)
            {
                log.Error("Invalid cast exception", exception);
                throw;
            }
        }

        public static List<object[]> ReadData(String sql)
        {
            try
            {
                using (SqlConnection connection = Connect())
                {
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
                    return studentsList;
                }
            }
            catch (InvalidOperationException exception)
            {
                log.Error("Invalid operation exception!", exception);
                throw;
            }
            catch (SqlException exception)
            {
                log.Error("Sql exception!", exception);
                throw;
            }
            catch (InvalidCastException exception)
            {
                log.Error("Invalid cast exception", exception);
                throw;
            }
        }
    }
}
