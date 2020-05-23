using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Writer_Helper.ViewModels
{
    /// <summary>
    /// A base view model that fires PropertyChanged events
    /// </summary>
    [AddINotifyPropertyChangedInterface]
    public class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// When any child property changes its value, this event is fired
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (IChannelSender, e) => { };

        /// <summary>
        /// Call this to fire a Property Changed event
        /// </summary>
        public void OnPropertyChanged(string name)
        {

        }
    }
}
