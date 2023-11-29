using Spectre.Console;

namespace Databaser_Labb3.Application.Navigation
{
    internal partial class UserMenu
    {
        private static UserChoice GetUserChoiceFromSelection(string selection)
        {
            string cleanSelection = Markup.Remove(selection);
            return cleanSelection switch
            {





                "Get Personal Information" => UserChoice.GetPersonal,
                "Get All Personal" => UserChoice.GetPersonalAll,
                "Get Personal By Role" => UserChoice.GetPersonalByRole,
                "Get All Teachers" => UserChoice.GetPersonalTeachersOnly,
                "Get All Administrators" => UserChoice.GetPersonalAdminsOnly,
                "Get All Education Leaders" => UserChoice.GetPersonalLeadersOnly,
                "Get Student Information" => UserChoice.GetStudent,
                "By First Name" => UserChoice.GetStudentByFirstName,
                "By Last Name" => UserChoice.GetStudentByLastName,
                "Get Class Information" => UserChoice.GetStudentsByClass,
                "Get Grade Information" => UserChoice.GetGrades,
                "1111111111111111111111111111111111111111111" => UserChoice.GetGradesLastMonth,
                "111111111111111111111111111111111111111111111" => UserChoice.GetGradesEnterDate,
                "Get Course Information" => UserChoice.GetCourse,
                "11111111111111111111111111111111111111111111111111" => UserChoice.GetAllCourses,
                "Add New Users To The Database" => UserChoice.AddUser,
                "Add New Student" => UserChoice.AddStudent,
                "Add New Personal" => UserChoice.AddPersonal,
                "Ascending" => UserChoice.SortAscending,
                "Descending" => UserChoice.SortDescending,
                "Back" => UserChoice.Back,
                "Exit" => UserChoice.Exit,
                _ => UserChoice.Invalid
            };
        }

        private static void WriteDivider(string dividerTextColor, string dividerLineColor, string text)
        {
            var rule = new Rule($"[{dividerTextColor}]{text}[/]").LeftJustified();
            rule.Style = Style.Parse(dividerLineColor);
            AnsiConsole.Write(rule);
            AnsiConsole.WriteLine();
        }

        private static List<string> GetEveryClassFromHighSchoolDB()
        {
            //List<DTO_Klasser> existingClasses =
            return default;
        }
    }
}
