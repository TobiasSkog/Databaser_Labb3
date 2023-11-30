using Databaser_Labb3.Application.Database.DTO;
using Spectre.Console;

namespace Databaser_Labb3.Application.Navigation
{
    internal static partial class UserCommunication
    {
        public static void PersonalInformation(List<PersonalModel> personal, bool isRoleSpecific = false, Befattning personalBefattning = Befattning.Unspecified)
        {
            var table = new Table();
            table.AddColumns(
                new TableColumn(new Markup($"{Title}Personal ID[/]")),
                new TableColumn(new Markup($"{Title}Name[/]")),
                new TableColumn(new Markup($"{Title}Role[/]"))
                );
            if (isRoleSpecific)
            {
                foreach (var employee in personal)
                {
                    if (employee.PersonalBefattning == personalBefattning)
                    {
                        table.AddRow(
                            new Markup($"{Choice}{employee.PersonalId.ToString()}[/]"),
                            new Markup($"{Choice}{employee.PersonalName}[/]"),
                            new Markup($"{Choice}{employee.PersonalBefattning.ToString()}[/]")
                            );
                    }
                }
            }
            else
            {
                foreach (var employee in personal)
                {
                    table.AddRow(
                        new Markup($"{Choice}{employee.PersonalId.ToString()}[/]"),
                        new Markup($"{Choice}{employee.PersonalName}[/]"),
                        new Markup($"{Choice}{employee.PersonalBefattning.ToString()}[/]")
                        );
                }
            }
            table.Border(TableBorder.Rounded);
            table.BorderColor(TableBorderColor);
            AnsiConsole.Write(table);
            Console.ReadKey();
        }
        public static void ExitScreen()
        {
            AnsiConsole.MarkupLine($"{Title}Bye bye![/]");
            Console.ReadKey();
        }
        public static void StudentInformation(Queue<StudentModel> students)
        {
            //          StudentId
            //          StudentNamn
            //          StudentSSN
            //          StudentFirstName
            //          StudentLastName
            var table = new Table();
            table.AddColumns(
                new TableColumn(new Markup($"{Title}Student ID[/]")),
                new TableColumn(new Markup($"{Title}First Name[/]")),
                new TableColumn(new Markup($"{Title}Last Name[/]")),
                new TableColumn(new Markup($"{Title}Social Security Number[/]"))
                );
            while (students.Count > 0)
            {
                var student = students.Dequeue();
                table.AddRow(
                    new Markup($"{Choice}{student.StudentId}[/]"),
                    new Markup($"{Choice}{student.StudentFirstName}[/]"),
                    new Markup($"{Choice}{student.StudentLastName}[/]"),
                    new Markup($"{Choice}{student.StudentSSN}[/]")
                    );
            }
            table.Border(TableBorder.Rounded);
            table.BorderColor(TableBorderColor);
            AnsiConsole.Write(table);
            Console.ReadKey();
        }
        public static void ClassInformation(List<KlassModel> klass)
        {
            AnsiConsole.MarkupLine($"{Title}Not implemented yet[/]");
            Console.ReadKey();

            //var table = new Table();
            //table.AddColumns(
            //    new TableColumn(new Markup($"{Title}Personal ID[/]")),
            //    new TableColumn(new Markup($"{Title}Name[/]")),
            //    new TableColumn(new Markup($"{Title}Role[/]"))
            //    );
            //foreach (var employee in klass)
            //{
            //    table.AddRow(
            //        new Markup($"{Choice}{employee.PersonalId.ToString()}[/]"),
            //        new Markup($"{Choice}{employee.PersonalName}[/]"),
            //        new Markup($"{Choice}{employee.PersonalBefattning.ToString()}[/]")
            //        );
            //}
            //table.Border(TableBorder.Rounded);
            //table.BorderColor(TableBorderColor);
            //AnsiConsole.Write(table);
        }
        public static void GradeInformation(List<BetygModel> betyg)
        {
            AnsiConsole.MarkupLine($"{Title}Not implemented yet[/]");
            Console.ReadKey();
            //var table = new Table();
            //table.AddColumns(
            //    new TableColumn(new Markup($"{Title}Personal ID[/]")),
            //    new TableColumn(new Markup($"{Title}Name[/]")),
            //    new TableColumn(new Markup($"{Title}Role[/]"))
            //    );
            //foreach (var employee in betyg)
            //{
            //    table.AddRow(
            //        new Markup($"{Choice}{employee.PersonalId.ToString()}[/]"),
            //        new Markup($"{Choice}{employee.PersonalName}[/]"),
            //        new Markup($"{Choice}{employee.PersonalBefattning.ToString()}[/]")
            //        );
            //}
            //table.Border(TableBorder.Rounded);
            //table.BorderColor(TableBorderColor);
            //AnsiConsole.Write(table);
        }
        // Not added
        public static void CourseInformation(List<KlassModel> course)
        {
            AnsiConsole.MarkupLine($"{Title}Not implemented yet[/]");
            Console.ReadKey();
        }
    }
}
