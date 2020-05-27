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
using Writer_Helper.Models;
using Writer_Helper.ViewModels;

namespace Writer_Helper
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginView : Page
    {
        public LoginView()
        {
            InitializeComponent();
        }
        private void GoToRegistration(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Views/RegisterView.xaml", UriKind.Relative));
        }
        private void Login(object sender, RoutedEventArgs e)
        {
            string email = $"{EmailTextBox.Text}";
            string password = $"{PasswordTextBox.Password}";
            if (DatabaseModel.Instance.Login(email, password) == true)
            {
                this.NavigationService.Navigate(new Uri("Views/ControlView.xaml", UriKind.Relative));
            }
            else
            {
                WrongPasswordTextBlock.Text = "Invalid email or password.";
            }
        }
    }
}
