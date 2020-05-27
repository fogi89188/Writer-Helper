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
    /// Interaction logic for ChangeEmail.xaml
    /// </summary>
    public partial class ChangeEmail : Page
    {
        public ChangeEmail()
        {
            InitializeComponent();
        }

        /// <summary>
        /// return to account page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Views/AccountView.xaml", UriKind.Relative));
        }
    }
}
