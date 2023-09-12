using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Project_wpf.Model
{
    public class AccountModel : Notifier
    {
        /*private List<Model.AccountModel> accounts;
        public List<Model.AccountModel> Accounts { 
            get { return accounts; }
            set { accounts = value; OnPropertyChanged(nameof(Accounts)); }
        }*/
        private ObservableCollection<Model.AccountModel> accounts;
        public ObservableCollection<Model.AccountModel> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(nameof(name)); }
        }

        private int money;
        public int Money
        {
            get { return money; }
            set { money = value; OnPropertyChanged(nameof(money)); }
        }

        private int password;
        public int Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged(nameof(password)); }
        }

        public AccountModel() { }
    }
}
