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
    /// Interaction logic for SuggestionsAdminView.xaml
    /// </summary>
    public partial class SuggestionsAdminView : Page
    {
        public SuggestionsAdminView()
        {
            InitializeComponent();
            DatabaseModel.Instance.SetNumberOfSuggestedNames();
            LoadSuggestedName();
        }

        /// <summary>
        /// when opening the page, loads the current suggested name
        /// </summary>
        private void LoadSuggestedName()
        {
            if (DatabaseModel.numberOfSuggestedNames > 0)
            {
                Name.Text = DatabaseModel.Instance.SuggestedMostRecentName();
                Race.Text = DatabaseModel.Instance.SuggestedMostRecentRace();
                Sex.Text = DatabaseModel.Instance.SuggestedMostRecentSex();
            }
            else
            {
                Name.Text = null;
                Race.Text = null;
                Sex.Text = null;
            }
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
        /// go to the account settings page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoToAccount(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Views/AccountView.xaml", UriKind.Relative));
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
        /// adds a suggested name to the names table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add(object sender, RoutedEventArgs e)
        {
            if (Name.Text != null || Race.Text != null || Sex.Text != null)
            {
                DatabaseModel.Instance.AddSuggestedName(Name.Text, Race.Text, Sex.Text.ToLower());
                Error.Text = "Name successfully added!";
            }
            if(DatabaseModel.numberOfSuggestedNames > 0)
            {
                LoadSuggestedName();
            }
            else
            {
                Name.Text = null;
                Race.Text = null;
                Sex.Text = null;
                Error.Text = "No more suggested names! Good job!";
            }
        }

        /// <summary>
        /// removes a suggested name from the suggeestions table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Remove(object sender, RoutedEventArgs e)
        {
            DatabaseModel.Instance.RemoveSuggestedName();
            Error.Text = "Name successfully removed!";
            if (DatabaseModel.numberOfSuggestedNames > 0)
            {
                LoadSuggestedName();
            }
            else
            {
                Name.Text = null;
                Race.Text = null;
                Sex.Text = null;
                Error.Text = "No more suggested names! Good job!";
            }
        }
    }
}
