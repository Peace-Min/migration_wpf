using System;
using System.Collections.Generic;
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
    /// AccountRegisterView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AccountRegisterView : Page
    {
        public AccountRegisterView()
        {
            InitializeComponent();
        }

        private void AccountRegisterCommit_Click(object sender, RoutedEventArgs e)
        {
            string name = Convert.ToString(AccountRegisterName.Text);
            int password = Convert.ToInt32(AccountRegisterPassword.Text);
            //Console.WriteLine(name+password);
            //ViewModel.AccountRegisterViewModel viewModel = new ViewModel.AccountRegisterViewModel(name, password);
            NavigationService.Navigate(
               new Uri("View/InitialListView.xaml", UriKind.Relative)

           );

        }
    }
}
