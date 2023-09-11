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
            List<Model.AccountModel> accountModels;
            public AccountListViewModel()
            {
                accountModels = Model.AccountModel.accounts; 
                    
            }
    }
}
