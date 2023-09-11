using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project_wpf.View
{
    /// <summary>
    /// AccountListView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AccountListView : Page
    {
        List<Model.AccountModel> accountList = Model.AccountModel.accounts;
        Model.AccountModel accountModel=null;
        public AccountListView()
        {
            InitializeComponent();
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            accountList
        }
    }
}
