using System;

namespace TimetableManagementConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            JsonHelper jsonHelper = new JsonHelper();

            //string connectionString = "Data Source=DESKTOP-R2U6UDB\\SQLEXPRESS;Integrated Security=True;Persist Security Info=False;Pooling=False;Connect Timeout=60;Encrypt=False;";
            string connectionString = "Data Source=DESKTOP-R2U6UDB\\SQLEXPRESS;Initial Catalog=TimetableManagementDatabase;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=True;TrustServerCertificate=True;";

            var faculty = new Faculty
            {
                FacultyGlobalIdentity = new Guid(),
                FacultyName = "Information Technology"
            };

            string jsonData = jsonHelper.SerializeFacultyToJson(faculty);

            bool status = databaseHelper.InsertFaculty(jsonData, connectionString);

            if (status)
            {
                Console.WriteLine("Faculty details inserted successfully.");
            }
            else
            {
                Console.WriteLine("Faculty details not inserted.");
            }

        }
    }

}
