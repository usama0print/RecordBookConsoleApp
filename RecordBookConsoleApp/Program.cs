using RecordBookConsoleApp.ViewModels;
using RecordBookConsoleApp.Views;

namespace RecordBookConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserViewModel userViewModel = new UserViewModel();
            MainView mainView = new MainView(userViewModel);
            mainView.Show();
        }
    }
}
