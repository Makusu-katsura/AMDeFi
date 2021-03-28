using System;
using System.ComponentModel;

namespace AMDeFi.Helpers
{
    public class NotifyObject : INotifyPropertyChanged
    {
        #region EventHandlers
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Property Changed
        /// <summary>
        /// Property getting changed
        /// </summary>
        /// <param name="propertyName">Property name.</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
