﻿using System;
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
    /// InitialListView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class InitialListView : Page
    {
        public InitialListView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) //계좌 생성
        {
            NavigationService.Navigate(
                new Uri("/View/AccountRegisterView.xaml", UriKind.Relative)

            );
        }

        private void AccountListVM(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/View/AccountListView.xaml", UriKind.Relative)

            );
        }
    }
}
