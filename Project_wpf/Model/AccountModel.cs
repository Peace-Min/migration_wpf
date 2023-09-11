using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Project_wpf.Model
{
    internal class AccountModel : Notifier
    {
        public static List<AccountModel> accounts = new List<AccountModel>();
        private double rate { get { return rate; } set { rate = 1.04; } } // 이율 
        public string name { get { return name; } set { name = value; OnPropertyChanged("name"); } }
        public int password { get { return password; } set { password = value; OnPropertyChanged("password"); } }
        public int money { get { return money; } set { money = value; OnPropertyChanged("money"); } }
        
        public static AccountModel currentAccount { get { return currentAccount; } set { currentAccount = value; } }
        //클래스,메서드,인터페이스,네임스페이스,상수=> 파스칼  변수,인수=>카멜

        public List<AccountModel> Accounts { get { return accounts; } set { accounts = value; OnPropertyChanged("accounts"); } }

        public AccountModel() { }
        public AccountModel(string name, int password)
        {
            this.name = name;
            this.password = password;
            this.money = 0;
            //currentAccount = this;
        }
        public AccountModel FindAccountByName(string name)
        {
            // 이름으로 계정 검색 로직
            return accounts.Find(a => a.name == name);
        }
    }
}
