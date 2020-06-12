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
        // the sex of the last name that was generated. 0 -> male, 1 -> female
        public int lastNameGenerated = 0;
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
            lastNameGenerated = 0;

            Button1.Content = "Add";
            Name1.Text = GetRandomMaleName();
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name1.Text, lastNameGenerated))
            {
                Button1.Content = "Favourite!";
            }

            Button2.Content = "Add";
            Name2.Text = GetRandomMaleName();
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name2.Text, lastNameGenerated))
            {
                Button2.Content = "Favourite!";
            }

            Button3.Content = "Add";
            Name3.Text = GetRandomMaleName();
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name3.Text, lastNameGenerated))
            {
                Button3.Content = "Favourite!";
            }

            Button4.Content = "Add";
            Name4.Text = GetRandomMaleName();
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name4.Text, lastNameGenerated))
            {
                Button4.Content = "Favourite!";
            }

            Button5.Content = "Add";
            Name5.Text = GetRandomMaleName();
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name5.Text, lastNameGenerated))
            {
                Button5.Content = "Favourite!";
            }

            Button6.Content = "Add";
            Name6.Text = GetRandomMaleName();
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name6.Text, lastNameGenerated))
            {
                Button6.Content = "Favourite!";
            }

            Button7.Content = "Add";
            Name7.Text = GetRandomMaleName();
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name7.Text, lastNameGenerated))
            {
                Button7.Content = "Favourite!";
            }

            Button8.Content = "Add";
            Name8.Text = GetRandomMaleName();
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name8.Text, lastNameGenerated))
            {
                Button8.Content = "Favourite!";
            }

            Button9.Content = "Add";
            Name9.Text = GetRandomMaleName();
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name9.Text, lastNameGenerated))
            {
                Button9.Content = "Favourite!";
            }

            Button10.Content = "Add";
            Name10.Text = GetRandomMaleName();
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name10.Text, lastNameGenerated))
            {
                Button10.Content = "Favourite!";
            }

            Button11.Content = "Add";
            Name11.Text = GetRandomMaleName();
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name11.Text, lastNameGenerated))
            {
                Button11.Content = "Favourite!";
            }

            Button12.Content = "Add";
            Name12.Text = GetRandomMaleName();
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name12.Text, lastNameGenerated))
            {
                Button12.Content = "Favourite!";
            }

            Button13.Content = "Add";
            Name13.Text = GetRandomMaleName();
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name13.Text, lastNameGenerated))
            {
                Button13.Content = "Favourite!";
            }

            Button14.Content = "Add";
            Name14.Text = GetRandomMaleName();
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name14.Text, lastNameGenerated))
            {
                Button14.Content = "Favourite!";
            }
        }

        /// <summary>
        /// sets the names to random ones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetFemaleName(object sender, RoutedEventArgs e)
        { 
            lastNameGenerated = 1;

            Button1.Content = "Add";
            Name1.Text = GetRandomFemaleName();
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name1.Text, lastNameGenerated))
            {
                Button1.Content = "Favourite!";
            }

            Button2.Content = "Add";
            Name2.Text = GetRandomFemaleName();
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name2.Text, lastNameGenerated))
            {
                Button2.Content = "Favourite!";
            }

            Button3.Content = "Add";
            Name3.Text = GetRandomFemaleName();
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name3.Text, lastNameGenerated))
            {
                Button3.Content = "Favourite!";
            }

            Button4.Content = "Add";
            Name4.Text = GetRandomFemaleName();
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name4.Text, lastNameGenerated))
            {
                Button4.Content = "Favourite!";
            }

            Button5.Content = "Add";
            Name5.Text = GetRandomFemaleName();
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name5.Text, lastNameGenerated))
            {
                Button5.Content = "Favourite!";
            }

            Button6.Content = "Add";
            Name6.Text = GetRandomFemaleName();
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name6.Text, lastNameGenerated))
            {
                Button6.Content = "Favourite!";
            }

            Button7.Content = "Add";
            Name7.Text = GetRandomFemaleName();
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name7.Text, lastNameGenerated))
            {
                Button7.Content = "Favourite!";
            }

            Button8.Content = "Add";
            Name8.Text = GetRandomFemaleName();
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name8.Text, lastNameGenerated))
            {
                Button8.Content = "Favourite!";
            }

            Button9.Content = "Add";
            Name9.Text = GetRandomFemaleName();
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name9.Text, lastNameGenerated))
            {
                Button9.Content = "Favourite!";
            }

            Button10.Content = "Add";
            Name10.Text = GetRandomFemaleName();
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name10.Text, lastNameGenerated))
            {
                Button10.Content = "Favourite!";
            }

            Button11.Content = "Add";
            Name11.Text = GetRandomFemaleName();
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name11.Text, lastNameGenerated))
            {
                Button11.Content = "Favourite!";
            }

            Button12.Content = "Add";
            Name12.Text = GetRandomFemaleName();
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name12.Text, lastNameGenerated))
            {
                Button12.Content = "Favourite!";
            }

            Button13.Content = "Add";
            Name13.Text = GetRandomFemaleName();
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name13.Text, lastNameGenerated))
            {
                Button13.Content = "Favourite!";
            }

            Button14.Content = "Add";
            Name14.Text = GetRandomFemaleName();
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name14.Text, lastNameGenerated))
            {
                Button14.Content = "Favourite!";
            }
        }

        /// <summary>
        /// here are the button favourite functions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region Favourite Buttons
        private void FavouriteName1(object sender, RoutedEventArgs e)
        {
            string sex = "male";
            if(lastNameGenerated == 1)
            {
                sex = "female";
            }
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name1.Text, lastNameGenerated))
            {
                Button1.Content = "Favourite!";
                return;
            }
            DatabaseModel.Instance.AddNameToFavourites(Name1.Text, ComboBox.Text, sex);
            Button1.Content = "Added!";
            return;
        }
        private void FavouriteName2(object sender, RoutedEventArgs e)
        {
            string sex = "male";
            if (lastNameGenerated == 1)
            {
                sex = "female";
            }
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name2.Text, lastNameGenerated))
            {
                Button2.Content = "Favourite!";
                return;
            }
            DatabaseModel.Instance.AddNameToFavourites(Name2.Text, ComboBox.Text, sex);
            Button2.Content = "Added!";
            return;
        }
        private void FavouriteName3(object sender, RoutedEventArgs e)
        {
            string sex = "male";
            if (lastNameGenerated == 1)
            {
                sex = "female";
            }
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name3.Text, lastNameGenerated))
            {
                Button3.Content = "Favourite!";
                return;
            }
            DatabaseModel.Instance.AddNameToFavourites(Name3.Text, ComboBox.Text, sex);
            Button3.Content = "Added!";
            return;
        }
        private void FavouriteName4(object sender, RoutedEventArgs e)
        {
            string sex = "male";
            if (lastNameGenerated == 1)
            {
                sex = "female";
            }
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name4.Text, lastNameGenerated))
            {
                Button4.Content = "Favourite!";
                return;
            }
            DatabaseModel.Instance.AddNameToFavourites(Name4.Text, ComboBox.Text, sex);
            Button4.Content = "Added!";
            return;
        }
        private void FavouriteName5(object sender, RoutedEventArgs e)
        {
            string sex = "male";
            if (lastNameGenerated == 1)
            {
                sex = "female";
            }
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name5.Text, lastNameGenerated))
            {
                Button5.Content = "Favourite!";
                return;
            }
            DatabaseModel.Instance.AddNameToFavourites(Name5.Text, ComboBox.Text, sex);
            Button5.Content = "Added!";
            return;
        }
        private void FavouriteName6(object sender, RoutedEventArgs e)
        {
            string sex = "male";
            if (lastNameGenerated == 1)
            {
                sex = "female";
            }
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name6.Text, lastNameGenerated))
            {
                Button6.Content = "Favourite!";
                return;
            }
            DatabaseModel.Instance.AddNameToFavourites(Name6.Text, ComboBox.Text, sex);
            Button6.Content = "Added!";
            return;
        }
        private void FavouriteName7(object sender, RoutedEventArgs e)
        {
            string sex = "male";
            if (lastNameGenerated == 1)
            {
                sex = "female";
            }
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name7.Text, lastNameGenerated))
            {
                Button7.Content = "Favourite!";
                return;
            }
            DatabaseModel.Instance.AddNameToFavourites(Name7.Text, ComboBox.Text, sex);
            Button7.Content = "Added!";
            return;
        }
        private void FavouriteName8(object sender, RoutedEventArgs e)
        {
            string sex = "male";
            if (lastNameGenerated == 1)
            {
                sex = "female";
            }
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name8.Text, lastNameGenerated))
            {
                Button8.Content = "Favourite!";
                return;
            }
            DatabaseModel.Instance.AddNameToFavourites(Name8.Text, ComboBox.Text, sex);
            Button8.Content = "Added!";
            return;
        }
        private void FavouriteName9(object sender, RoutedEventArgs e)
        {
            string sex = "male";
            if (lastNameGenerated == 1)
            {
                sex = "female";
            }
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name9.Text, lastNameGenerated))
            {
                Button9.Content = "Favourite!";
                return;
            }
            DatabaseModel.Instance.AddNameToFavourites(Name9.Text, ComboBox.Text, sex);
            Button9.Content = "Added!";
            return;
        }
        private void FavouriteName10(object sender, RoutedEventArgs e)
        {
            string sex = "male";
            if (lastNameGenerated == 1)
            {
                sex = "female";
            }
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name10.Text, lastNameGenerated))
            {
                Button10.Content = "Favourite!";
                return;
            }
            DatabaseModel.Instance.AddNameToFavourites(Name10.Text, ComboBox.Text, sex);
            Button10.Content = "Added!";
            return;
        }
        private void FavouriteName11(object sender, RoutedEventArgs e)
        {
            string sex = "male";
            if (lastNameGenerated == 1)
            {
                sex = "female";
            }
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name11.Text, lastNameGenerated))
            {
                Button11.Content = "Favourite!";
                return;
            }
            DatabaseModel.Instance.AddNameToFavourites(Name11.Text, ComboBox.Text, sex);
            Button11.Content = "Added!";
            return;
        }
        private void FavouriteName12(object sender, RoutedEventArgs e)
        {
            string sex = "male";
            if (lastNameGenerated == 1)
            {
                sex = "female";
            }
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name12.Text, lastNameGenerated))
            {
                Button12.Content = "Favourite!";
                return;
            }
            DatabaseModel.Instance.AddNameToFavourites(Name12.Text, ComboBox.Text, sex);
            Button12.Content = "Added!";
            return;
        }
        private void FavouriteName13(object sender, RoutedEventArgs e)
        {
            string sex = "male";
            if (lastNameGenerated == 1)
            {
                sex = "female";
            }
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name13.Text, lastNameGenerated))
            {
                Button13.Content = "Favourite!";
                return;
            }
            DatabaseModel.Instance.AddNameToFavourites(Name13.Text, ComboBox.Text, sex);
            Button13.Content = "Added!";
            return;
        }
        private void FavouriteName14(object sender, RoutedEventArgs e)
        {
            string sex = "male";
            if (lastNameGenerated == 1)
            {
                sex = "female";
            }
            if (DatabaseModel.Instance.CheckIfAlreadyAdded(Name14.Text, lastNameGenerated))
            {
                Button14.Content = "Favourite!";
                return;
            }
            DatabaseModel.Instance.AddNameToFavourites(Name14.Text, ComboBox.Text, sex);
            Button14.Content = "Added!";
            return;
        }

        #endregion

    }
}
