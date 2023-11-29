using Databaser_Labb3.Application.Navigation;

namespace Databaser_Labb3.Application.Database.ContactDatabaseMethods
{
    internal class DatabaseManager
    {
        private readonly string _connectionString;

        public DatabaseManager()
        {
            if (File.Exists("EdugradeHighSchoolDBConnectionString.txt"))
            {
                string connectionString = File.ReadAllText("EdugradeHighSchoolDBConnectionString.txt");
                if (string.IsNullOrEmpty(connectionString))
                {
                    _connectionString = UserMenu.GetConnectionStringFromUser();
                    File.WriteAllText("EdugradeHighSchoolDBConnectionString.txt", _connectionString);
                }
            }
            else
            {
                _connectionString = UserMenu.GetConnectionStringFromUser();
                File.WriteAllText("EdugradeHighSchoolDBConnectionString.txt", _connectionString);

            }
        }
    }
}
