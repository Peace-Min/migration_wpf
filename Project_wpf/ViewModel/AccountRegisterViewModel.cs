using Project_wpf.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_wpf.ViewModel
{
    public class AccountRegisterViewModel : Notifier
    {
        public static string name;
        public static int password;

        public AccountRegisterViewModel() { }
        public Command accountRegisterCommand = new Command(AccountRegisterCommand, AccountBool);
        public AccountRegisterViewModel(AccountRegisterViewModel v)
        {
            //AccountRegisterViewModel vv = new AccountRegisterViewModel(v.Name, v.Password);
            //Model.AccountModel.accounts.Add(v);
            Model.AccountModel vv = new Model.AccountModel(v.Name, v.Password);
            Model.AccountModel.accounts.Add(vv);
        }

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
        public static void AccountRegisterCommand(object v)
        {
            ViewModel.AccountRegisterViewModel vv = new ViewModel.AccountRegisterViewModel((ViewModel.AccountRegisterViewModel)v);
        }
        public static bool AccountBool(object parameter)
        {
            return true;
        }
    }
}