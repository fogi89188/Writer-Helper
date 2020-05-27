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

namespace Writer_Helper.Views
{
    /// <summary>
    /// Interaction logic for Account.xaml
    /// </summary>
    public partial class Account : Page
    {
        public Account()
        {
            InitializeComponent();
        }

        /// <summary>
        /// return to the login page, essentially Logging Out
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoToLogin(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Views/LoginView.xaml", UriKind.Relative));
        }
        /// <summary>
        /// go to the favourites page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoToFavourites(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Views/FavouritesView.xaml", UriKind.Relative));
        }

        /// <summary>
        /// go to the suggestions page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoToSuggestions(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Views/SuggestionsView.xaml", UriKind.Relative));
        }

        /// <summary>
        /// go to the random name generation page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoToNameGeneration(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Views/ControlView.xaml", UriKind.Relative));
        }

        /// <summary>
        /// go to the change email page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeEmail(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Views/ChangeEmailView.xaml", UriKind.Relative));
        }

        /// <summary>
        /// go to the change password page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangePassword(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Views/ChangePasswordView.xaml", UriKind.Relative));
        }

        /// <summary>
        /// go to the delete account page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteAccount(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Views/DeleteAccountView.xaml", UriKind.Relative));
        }
    }
}
