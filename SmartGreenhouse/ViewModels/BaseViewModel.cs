using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmartGreenhouse.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void Raise<T>(ref T field, T value, [CallerMemberName] string? name = null)
        {
            if (!Equals(field, value))
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            }
        }

        // helper
        protected void Set<T>(ref T field, T value, [CallerMemberName] string? name = null) => Raise(ref field, value, name);
    }
}
