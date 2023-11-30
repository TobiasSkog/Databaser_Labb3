using Databaser_Labb3.Application.Database.DTO;
using Databaser_Labb3.Application.Database.Model;
using Spectre.Console;

namespace Databaser_Labb3.Application.Navigation
{
    internal static partial class UserCommunication
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
                "Get Student Information" => UserChoice.GetStudents,
                "Get All Students" => UserChoice.GetStudentsAll,
                "Get Class Information" => UserChoice.GetStudentsByClass,
                "Get Students By Class" => UserChoice.GetStudentsByClass,
                "Get Grade Information" => UserChoice.GetGrades,
                "1111111111111111111111111111111111111111111" => UserChoice.GetGradesLastMonth,
                "111111111111111111111111111111111111111111111" => UserChoice.GetGradesEnterDate,
                "Get Course Information" => UserChoice.GetCourse,
                "11111111111111111111111111111111111111111111111111" => UserChoice.GetAllCourses,
                "Add New Users To The Database" => UserChoice.AddUser,
                "Add New Student" => UserChoice.AddStudent,
                "Add New Personal" => UserChoice.AddPersonal,
                "Back" => UserChoice.Back,
                "Exit" => UserChoice.Exit,
                _ => UserChoice.Invalid
            };
        }
        private static Befattning GetBefattningFromSelection(string selection)
        {
            string cleanSelection = Markup.Remove(selection);
            return cleanSelection switch
            {
                "Get All Teachers" => Befattning.Lärare,
                "Get All Administrators" => Befattning.Administratör,
                "Get All Education Leaders" => Befattning.UtbildningsLedare,
                _ => Befattning.Unspecified
            };
        }

        private static SortOption GetSortOptionFromSelection(string selection)
        {
            string cleanSelection = Markup.Remove(selection);
            return cleanSelection switch
            {
                "By First Name" => SortOption.ByFirstName,
                "By Last Name" => SortOption.ByLastName,
                "Sort Ascending" => SortOption.Ascending,
                "Sort Descending" => SortOption.Descending,
                _ => SortOption.Unspecified
            };
        }



        private static void WriteDivider(string dividerTextColor, string dividerLineColor, string text)
        {
            var rule = new Rule($"[{dividerTextColor}]{text}[/]").LeftJustified();
            rule.Style = Style.Parse(dividerLineColor);
            AnsiConsole.Write(rule);
            AnsiConsole.WriteLine();
        }

        private static List<string> GetEveryClassFromHighSchoolDB(List<KlassModel> existingClasses)
        {
            var klassNameList = new List<string>();
            foreach (var klass in existingClasses)
            {
                klassNameList.Add($"{Choice}{klass.KlassNamn}[/]");
            }
            return klassNameList;
        }
    }
}
