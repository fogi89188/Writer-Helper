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
using Writer_Helper.Models;

namespace Writer_Helper.Views
{
    /// <summary>
    /// Interaction logic for SuggestionsView.xaml
    /// </summary>
    public partial class SuggestionsView : Page
    {
        public SuggestionsView()
        {
            InitializeComponent();
            DatabaseModel.Instance.SetNumberOfSuggestedNames();
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
        /// adds a name to the sugegstions table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Suggestion(object sender, RoutedEventArgs e)
        {
            if (Name.Text != null || Race.Text != null || Sex.Text != null)
            {
                DatabaseModel.Instance.Suggest(Name.Text, Race.Text, Sex.Text);
                Race.Text = null;
                Name.Text = null;
                Sex.Text = null;
                Error.Text = "Your name was suggested correctly!";
            }
            else
            {
                Error.Text = "Make sure everything is filled out correctly.";
            }
        }
    }
}