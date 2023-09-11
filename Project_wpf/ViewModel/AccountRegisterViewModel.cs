using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_wpf.ViewModel
{
    public class AccountRegisterViewModel : Notifier
    {
        public static string name { get; set; }
        public static int password { get; set; }

        public Command accountRegisterCommand = new Command(AccountRegisterCommand, AccountBool);
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("name");
            }
        }
        public int Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("password");
            }
        }
        public static void AccountRegisterCommand(object parameter)
        {
            Model.AccountModel accountModel = new Model.AccountModel(name, password);
            Model.AccountModel.accounts.Add(accountModel);
        }
        public static bool AccountBool(object parameter)
        {
            return true;
        }
    }
}