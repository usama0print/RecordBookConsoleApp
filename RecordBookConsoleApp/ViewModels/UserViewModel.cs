using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecordBookConsoleApp.Models;
using RecordBookConsoleApp.Commands;



namespace RecordBookConsoleApp.ViewModels
{
    public class UserViewModel
    {
        private List<User> _users;

        public UserViewModel()
        {
            _users = new List<User>();
            AddUserCommand = new RelayCommand(AddUser);
            ViewUsersCommand = new RelayCommand(ViewUsers);
            UpdateUserCommand = new RelayCommand(UpdateUser);
            DeleteUserCommand = new RelayCommand(DeleteUser);
        }

        public List<User> Users
        {
            get { return _users; }
            set { _users = value; }
        }

        public RelayCommand AddUserCommand { get; }
        public RelayCommand ViewUsersCommand { get; }
        public RelayCommand UpdateUserCommand { get; }
        public RelayCommand DeleteUserCommand { get; }

        public void AddUser(object parameter)
        {
            Console.WriteLine("Enter user name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter user email:");
            string email = Console.ReadLine();

            _users.Add(new User { Name = name, Email = email });
            Console.WriteLine("User added successfully!");
        }

        public void ViewUsers(object parameter)
        {
            if (_users.Count == 0)
            {
                Console.WriteLine("No users found.");
            }
            else
            {
                foreach (var user in _users)
                {
                    Console.WriteLine($"Name: {user.Name}, Email: {user.Email}");
                }
            }
        }

        public void UpdateUser(object parameter)
        {
            Console.WriteLine("Enter the name of the user to update:");
            string name = Console.ReadLine();
            var user = _users.Find(u => u.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (user != null)
            {
                Console.WriteLine("Enter new name:");
                user.Name = Console.ReadLine();
                Console.WriteLine("Enter new email:");
                user.Email = Console.ReadLine();
                Console.WriteLine("User updated successfully!");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        public void DeleteUser(object parameter)
        {
            Console.WriteLine("Enter the name of the user to delete:");
            string name = Console.ReadLine();
            var user = _users.Find(u => u.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (user != null)
            {
                _users.Remove(user);
                Console.WriteLine("User deleted successfully!");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }
    }
}
