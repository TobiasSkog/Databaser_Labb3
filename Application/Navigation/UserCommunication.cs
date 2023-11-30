using Databaser_Labb3.Application.Database.DTO;
using Databaser_Labb3.Application.Database.Model;
using Spectre.Console;

namespace Databaser_Labb3.Application.Navigation
{
    internal partial class UserCommunication
    {
        private static readonly Style Labb3Style = new Style(Color.Green3_1, default, Decoration.Underline);
        private static readonly string Title = "[green3]";
        private static readonly string Choice = "[green3_1]";
        private static readonly string Back = "[cyan2]";
        private static readonly string Exit = "[mediumvioletred]";
        private static readonly string DividerTextColor = "springgreen2_1";
        private static readonly string DividerLineColor = "springgreen1";
        private static readonly Color TableBorderColor = Color.SpringGreen1;



        public static UserChoice WelcomeMenu()
        {
            AnsiConsole.Clear();
            WriteDivider(DividerTextColor, DividerLineColor, "Edugrade High School");


            string selectionString = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title($"{Title}Welcome Menu[/]")
                    .HighlightStyle(Labb3Style)
                    .AddChoices(new[]
                    {
                        $"{Choice}Get Personal Information[/]",
                        $"{Choice}Get Student Information[/]",
                        $"{Choice}Get Grade Information[/]",
                        $"{Choice}Get Course Information[/]",
                        $"{Choice}Add New Users To The Database[/]",
                        $"{Exit}Exit[/]"
                    }
                ));

            //  $"{Choice}Get Grade Information[/]",
            //  $"{Choice}Get Course Information[/]",


            return GetUserChoiceFromSelection(selectionString);
        }

        public static UserChoice GetPersonalMenu()
        {
            AnsiConsole.Clear();
            WriteDivider(DividerTextColor, DividerLineColor, "Edugrade High School | Personal Information");

            string selectionString = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title($"{Title}Get Personal Menu[/]")
                    .HighlightStyle(Labb3Style)
                    .AddChoices(new[]
                    {
                        $"{Choice}Get All Personal[/]",
                        $"{Choice}Get Personal By Role[/]",
                        $"{Back}Back[/]"
                    }
                ));

            return GetUserChoiceFromSelection(selectionString);
        }
        public static Befattning GetPersonalByRoleMenu()
        {
            AnsiConsole.Clear();
            WriteDivider(DividerTextColor, DividerLineColor, "Edugrade High School | Personal Information");

            string selectionString = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title($"{Title}Get Personal Menu[/]")
                    .HighlightStyle(Labb3Style)
                    .AddChoices(new[]
                    {
                        $"{Choice}Get All Teachers[/]",
                        $"{Choice}Get All Administrators[/]",
                        $"{Choice}Get All Education Leaders[/]",
                        $"{Back}Back[/]"
                    }
                ));

            return GetBefattningFromSelection(selectionString);
        }
        public static UserChoice GetStudentsMenu()
        {
            AnsiConsole.Clear();
            WriteDivider(DividerTextColor, DividerLineColor, "Edugrade High School | Student Information");

            string selectionString = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title($"{Title}Get Student Menu[/]")
                    .HighlightStyle(Labb3Style)
                    .AddChoices(new[]
                    {
                        $"{Choice}Get All Students[/]",
                        $"{Choice}Get Students By Class[/]",
                        $"{Choice}Get All Education Leaders[/]",
                        $"{Back}Back[/]"
                    }
                ));

            return GetUserChoiceFromSelection(selectionString);
        }

        public static SortOption GetSortByNameOptionsMenu()
        {
            AnsiConsole.Clear();
            WriteDivider(DividerTextColor, DividerLineColor, $"Edugrade High School | How To Display Your Information"); ;

            string selectionString = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title($"{Title}How Would You Like To Sort The Information?[/]")
                    .HighlightStyle(Labb3Style)
                    .AddChoices(new[]
                    {
                        $"{Choice}By First Name[/]",
                        $"{Choice}By Last Name[/]",

                        $"{Back}Back[/]"
                    }
                ));

            return GetSortOptionFromSelection(selectionString);
        }

        public static SortOption GetSortByAscendingOrDescendingOptionsMenu()
        {
            AnsiConsole.Clear();
            WriteDivider(DividerTextColor, DividerLineColor, $"Edugrade High School | How To Display Your Information");

            string selectionString = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title($"{Title}How Would You Like To Sort The Information?[/]")
                    .HighlightStyle(Labb3Style)
                    .AddChoices(new[]
                    {
                        $"{Choice}Sort Ascending[/]",
                        $"{Choice}Sort Descending[/]",

                        $"{Back}Back[/]"
                    }
                ));

            return GetSortOptionFromSelection(selectionString);
        }


        public static string GetStudentsFromClassMenu(List<KlassModel> existingClasses)
        {
            AnsiConsole.Clear();

            WriteDivider(DividerTextColor, DividerLineColor, $"Edugrade High School | Student Information");

            var choices = GetEveryClassFromHighSchoolDB(existingClasses);

            string selectionString = AnsiConsole.Prompt(
                 new SelectionPrompt<string>()
                     .Title($"{Title}From What Class?[/]")
                     .HighlightStyle(Labb3Style)
                     .AddChoices(choices)
                     );

            return Markup.Remove(selectionString);
        }

        //public static UserChoice GetGradesMenu()
        //{
        // AnsiConsole.Clear();

        //}

        //public static UserChoice GetCoursesMenu()
        //{
        //AnsiConsole.Clear();
        //}

        public static UserChoice AddUsersMenu()
        {
            AnsiConsole.Clear();
            WriteDivider(DividerTextColor, DividerLineColor, "Edugrade High School | Add Users");

            string selectionString = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title($"{Title}Add User Menu[/]")
                    .HighlightStyle(Labb3Style)
                    .AddChoices(new[]
                    {
                        $"{Choice}Add New Student[/]",
                        $"{Choice}Add New Personal[/]",
                        $"{Back}Back[/]"
                    }
                ));

            return GetUserChoiceFromSelection(selectionString);

        }
        //public static UserChoice AddStudentMenu()
        //{
        //  AnsiConsole.Clear();
        //}
        //public static UserChoice AddPersonalMenu()
        //{
        //  AnsiConsole.Clear();
        //}

    }
}
