using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace InteretSwapVanille.Helpers
{


    public abstract class ObservableObject : INotifyPropertyChanged
    {
        /// <summary>
        /// Raised when a property on this object has a new value.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises this object's PropertyChanged event.
        /// </summary>
        /// <param name="propertyName">The property that has a new value.</param>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public EventHandler Close;

        public virtual void Onclose()
        {
            Close?.Invoke(this, EventArgs.Empty);
        }


    }
}