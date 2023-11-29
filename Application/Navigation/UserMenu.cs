using Spectre.Console;

namespace Databaser_Labb3.Application.Navigation
{
    internal partial class UserMenu
    {
        private static readonly Style Labb3Style = new Style(Color.Green3_1, default, Decoration.Underline);
        private static readonly string Title = "[green3]";
        private static readonly string Choice = "[green3_1]";
        private static readonly string Back = "[cyan2]";
        private static readonly string Exit = "[mediumvioletred]";
        private static readonly string DividerTextColor = "springgreen2_1";
        private static readonly string DividerLineColor = "springgreen1";


        public static UserChoice WelcomeMenu()
        {
            WriteDivider(DividerTextColor, DividerLineColor, "Edugrade High School");


            string selectionString = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title($"{Title}Welcome Menu[/]")
                    .HighlightStyle(Labb3Style)
                    .AddChoices(new[]
                    {
                        $"{Choice}Get Personal Information[/]",
                        $"{Choice}Get Student Information[/]",
                        $"{Choice}Get Class Information[/]",
                        $"{Choice}Get Grade Information[/]",
                        $"{Choice}Get Course Information[/]",
                        $"{Choice}Add New Users To The Database[/]",
                        $"{Exit}Exit[/]"
                    }
                ));

            return GetUserChoiceFromSelection(selectionString);
        }

        public static UserChoice GetPersonalMenu()
        {
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
        public static UserChoice GetPersonalByRoleMenu()
        {
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

            return GetUserChoiceFromSelection(selectionString);
        }
        public static UserChoice GetStudentMenu()
        {
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
        public static UserChoice GetSortByNameOptionsMenu(string userType)
        {
            WriteDivider(DividerTextColor, DividerLineColor, $"Edugrade High School | {userType} Information"); ;

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

            return GetUserChoiceFromSelection(selectionString);
        }
        public static UserChoice GetSortByAscendingOrDescendingOptionsMenu(string userType)
        {
            WriteDivider(DividerTextColor, DividerLineColor, $"Edugrade High School | {userType} Information"); ;

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

            return GetUserChoiceFromSelection(selectionString);
        }

        //public static UserChoice GetStudentsFromClassMenu()
        //{
        //    // Get Class Names From DB
        //}

        //public static UserChoice GetGradesMenu()
        //{

        //}

        //public static UserChoice GetCoursesMenu()
        //{

        //}

        public static UserChoice AddUsersMenu()
        {
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

        //}
        //public static UserChoice AddPersonalMenu()
        //{

        //}
        public static string GetConnectionStringFromUser()
        {
            return AnsiConsole.Ask<string>($"{Title}Please enter a valid Connection String to the database:[/]");
        }

    }
}
