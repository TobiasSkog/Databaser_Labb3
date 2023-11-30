using Databaser_Labb3.Application.Database.ContactDatabaseMethods;
using Databaser_Labb3.Application.Database.DTO;
using Databaser_Labb3.Application.Database.Model;
using Databaser_Labb3.Application.Navigation;
using Microsoft.Extensions.Configuration;

namespace Databaser_Labb3.Application;

internal class App
{
    private bool _isAppRunning = true;
    private DatabaseManager DatabaseManager { get; set; }
    private UserChoice UserChoice { get; set; }
    private IConfiguration _configuration;

    public App()
    {
        GetAppSettingsFile();
        DatabaseManager = new(_configuration);
        UserChoice = UserChoice.Invalid;
    }
    private void GetAppSettingsFile()
    {
        var builder = new ConfigurationBuilder()
                             .SetBasePath(Directory.GetCurrentDirectory())
                             .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        _configuration = builder.Build();
    }

    public void Run()
    {
        UserChoice = UserCommunication.WelcomeMenu();
        var personal = new List<PersonalModel>();
        var students = new Queue<StudentModel>();
        var classes = new List<KlassModel>();
        Befattning personalBefattning = Befattning.Unspecified;
        SortOption nameSort = SortOption.Unspecified;
        SortOption ascOrDescSort = SortOption.Unspecified;

        while (_isAppRunning)
        {
            switch (UserChoice)
            {
                case UserChoice.WelcomeMenu:
                    UserChoice = UserCommunication.WelcomeMenu();
                    break;
                case UserChoice.GetPersonal:
                    //"Get Personal Information"
                    UserChoice = UserCommunication.GetPersonalMenu();
                    break;

                case UserChoice.GetPersonalAll:
                    //"Get All Personal"
                    personal = DatabaseManager.GetAllPersonalFromDB();
                    UserCommunication.PersonalInformation(personal);
                    UserChoice = UserChoice.WelcomeMenu;
                    break;

                case UserChoice.GetPersonalByRole:
                    //"Get Personal By Role"
                    personalBefattning = UserCommunication.GetPersonalByRoleMenu();
                    personal = DatabaseManager.GetAllPersonalFromDB();
                    UserCommunication.PersonalInformation(personal, true, personalBefattning);
                    UserChoice = UserChoice.WelcomeMenu;
                    break;

                case UserChoice.GetStudents:
                    //"Get Student Information"
                    UserChoice = UserCommunication.GetStudentsMenu();
                    break;

                case UserChoice.GetStudentsAll:
                    nameSort = UserCommunication.GetSortByNameOptionsMenu();
                    ascOrDescSort = UserCommunication.GetSortByAscendingOrDescendingOptionsMenu();
                    students = DatabaseManager.GetAllStudents(nameSort, ascOrDescSort);
                    UserCommunication.StudentInformation(students);
                    UserChoice = UserChoice.WelcomeMenu;
                    break;

                case UserChoice.GetStudentsByClass:
                    //"Get Class Information"
                    classes = DatabaseManager.GetAllClassesFromDB();
                    var className = UserCommunication.GetStudentsFromClassMenu(classes);
                    //students = DatabaseManager.GetAllStudentsInClass(className);
                    UserCommunication.StudentInformation(students);
                    UserChoice = UserChoice.WelcomeMenu;
                    break;

                case UserChoice.GetGrades:
                    //"Get Grade Information"
                    break;

                case UserChoice.GetGradesLastMonth:
                    break;

                case UserChoice.GetGradesEnterDate:
                    break;

                case UserChoice.GetCourse:
                    //    "Get Course Information"
                    break;

                case UserChoice.GetAllCourses:
                    break;

                case UserChoice.AddUser:
                    // "Add New Users To The Database"
                    break;

                case UserChoice.AddStudent:
                    // "Add New Student"
                    break;

                case UserChoice.AddPersonal:
                    // "Add New Personal"
                    break;

                case UserChoice.Back:
                    // "Back"
                    break;

                case UserChoice.Exit:
                    // "Exit"
                    Exit();
                    break;

                default:
                    UserChoice = UserCommunication.WelcomeMenu();
                    break;
            }
        }
    }
    public void Exit()
    {
        _isAppRunning = false;
        UserChoice = UserChoice.Exit;
        UserCommunication.ExitScreen();
    }
}

