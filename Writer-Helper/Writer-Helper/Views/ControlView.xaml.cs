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
    /// Interaction logic for ControlPage.xaml
    /// </summary>
    public partial class ControlPage : Page
    {
        public ControlPage()
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


        private void SetAllNames(string randomName)
        {
            Name1.Text = Name2.Text = Name3.Text = Name4.Text = Name5.Text = Name6.Text = Name7.Text = randomName;
        }

        /// <summary>
        /// gets random male name and returns it
        /// </summary>
        /// <returns></returns>
        private string GetRandomMaleName()
        {
            string name = DatabaseModel.Instance.GetRandomName(ComboBox.Text, "male");
            return name;
        }

        /// <summary>
        /// gets a random female name and returns it
        /// </summary>
        /// <returns></returns>
        private string GetRandomFemaleName()
        {
            string name = DatabaseModel.Instance.GetRandomName(ComboBox.Text, "female");
            return name;
        }

        /// <summary>
        /// sets the names to random ones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetMaleName(object sender, RoutedEventArgs e)
        {
            Name1.Text = GetRandomMaleName();
            Name2.Text = GetRandomMaleName();
            Name3.Text = GetRandomMaleName();
            Name4.Text = GetRandomMaleName();
            Name5.Text = GetRandomMaleName();
            Name6.Text = GetRandomMaleName();
            Name7.Text = GetRandomMaleName();
            Name8.Text = GetRandomMaleName();
            Name9.Text = GetRandomMaleName();
            Name10.Text = GetRandomMaleName();
            Name11.Text = GetRandomMaleName();
            Name12.Text = GetRandomMaleName();
            Name13.Text = GetRandomMaleName();
            Name14.Text = GetRandomMaleName();
        }
        /// <summary>
        /// sets the names to random ones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetFemaleName(object sender, RoutedEventArgs e)
        {
            Name1.Text = GetRandomFemaleName();
            Name2.Text = GetRandomFemaleName();
            Name3.Text = GetRandomFemaleName();
            Name4.Text = GetRandomFemaleName();
            Name5.Text = GetRandomFemaleName();
            Name6.Text = GetRandomFemaleName();
            Name7.Text = GetRandomFemaleName();
            Name8.Text = GetRandomFemaleName();
            Name9.Text = GetRandomFemaleName();
            Name10.Text = GetRandomFemaleName();
            Name11.Text = GetRandomFemaleName();
            Name12.Text = GetRandomFemaleName();
            Name13.Text = GetRandomFemaleName();
            Name14.Text = GetRandomFemaleName();
        }
    }
}
