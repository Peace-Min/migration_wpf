using Project_wpf.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Project_wpf.ViewModel
{
    public class AccountListViewModel : ObservableCollection<Dictionary<string,int>>
    {
            public static ObservableCollection<Dictionary<string, int>> accountData { get; set; }

            public AccountListViewModel()
            {
                accountData = new ObservableCollection<Dictionary<string, int>>();
            accountData.Add(Model.AccountModel.accounts.name);
                    
            }
    }
}
