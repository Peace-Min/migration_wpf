using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace Project_wpf.ViewModel
{
    public class AccountRegisterViewModel : Notifier
    {
        private Model.AccountModel account;
        //public List<Model.AccountModel> _accounts;
        public Model.AccountModel TargetAccount
        {
            get { return account; }
            set { account = value; OnPropertyChanged(nameof(account)); }
        }
        private ObservableCollection<Model.AccountModel> accounts;
        public ObservableCollection<Model.AccountModel> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }
        public Command btn_cmd {  get; set; }
        public void AddAccount(object obj)
        {
            Accounts.Add(TargetAccount); //Add it to thecollection
            //accounts.Add(TargetAccount);
            //_accounts.Add(TargetAccount);
            //TargetAccount.Accounts = _accounts;
            TargetAccount = new Model.AccountModel(); //resetting it.
        }
        private bool CanExecute_func(object parameter)
        {
            return true;
        }
        public AccountRegisterViewModel()
        {
            Accounts = new ObservableCollection<Model.AccountModel>();
            //Model.AccountModel m = new Model.AccountModel();
            //accounts = m.Accounts;
            TargetAccount = new Model.AccountModel();
            btn_cmd = new Command(AddAccount,CanExecute_func);
        }
    }
}