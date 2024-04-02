using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TimetableManagementConsoleProject
{
    public class DatabaseHelper
    {
        public bool InsertFaculty(string jsonData, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand("spInsertFaculty", connection);

            try
            {
                command.CommandType = CommandType.StoredProcedure;
                //command.Parameters.AddWithValue("@JsonData", jsonData);

                command.Parameters.AddRange(new SqlParameter[]{
                    new SqlParameter("@JsonData", jsonData)
                });

                connection.Open();
                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }
    }
}
