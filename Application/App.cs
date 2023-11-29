using Databaser_Labb3.Application.Database.ContactDatabaseMethods;
using Databaser_Labb3.Application.Navigation;

namespace Databaser_Labb3.Application;

internal class App
{
    private bool _isRunning = false;
    private DatabaseManager DatabaseManager { get; set; }
    private UserChoice UserChoice { get; set; }
    public App()
    {
        DatabaseManager = new();
        UserChoice = UserChoice.Invalid;
    }
    public void Run()
    {
        UserChoice = UserMenu.WelcomeMenu();
    }
}

