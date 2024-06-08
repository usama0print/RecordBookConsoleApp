using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecordBookConsoleApp.ViewModels;

namespace RecordBookConsoleApp.Views
{
    public class MainView
    {
        private UserViewModel _userViewModel;

        public MainView(UserViewModel userViewModel)
        {
            _userViewModel = userViewModel;
        }

        public void Show()
        {
            string command;

            do
            {
                Console.WriteLine("Choose an action: [Add, View, Update, Delete, Exit]");
                command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "add":
                        _userViewModel.AddUserCommand.Execute(null);
                        break;
                    case "view":
                        _userViewModel.ViewUsersCommand.Execute(null);
                        break;
                    case "update":
                        _userViewModel.UpdateUserCommand.Execute(null);
                        break;
                    case "delete":
                        _userViewModel.DeleteUserCommand.Execute(null);
                        break;
                    case "exit":
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid command. Try again.");
                        break;
                }
            } while (command != "exit");
        }
    }
}
