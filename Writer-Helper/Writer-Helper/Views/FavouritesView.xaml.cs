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

namespace Writer_Helper.Views
{
    /// <summary>
    /// Interaction logic for FavouritesView.xaml
    /// </summary>
    public partial class FavouritesView : Page
    {
        public FavouritesView()
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
            DatabaseModel.Instance.Logout();
            this.NavigationService.Navigate(new Uri("Views/LoginView.xaml", UriKind.Relative));
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
        /// go to the suggestions page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoToSuggestions(object sender, RoutedEventArgs e)
        {
            if (DatabaseModel.IsAdmin)
            {
                this.NavigationService.Navigate(new Uri("Views/SuggestionsAdminView.xaml", UriKind.Relative));
            }
            else
            {
                this.NavigationService.Navigate(new Uri("Views/SuggestionsView.xaml", UriKind.Relative));
            }
        }

        /// <summary>
        /// go to the account settings page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoToAccount(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Views/AccountView.xaml", UriKind.Relative));
        }
    }
}