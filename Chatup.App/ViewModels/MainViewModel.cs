using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Essentials;

namespace Chatup.App.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _statusMessage;

        public string StatusMessage
        {
            get => _statusMessage;
            set
            {
                if (_statusMessage != value)
                {
                    _statusMessage = value;
                    OnPropertyChanged(nameof(StatusMessage));
                }
            }
        }

        public ICommand StartBluetoothCommand { get; }

        public MainViewModel()
        {
            StartBluetoothCommand = new Command(OnStartBluetooth);
            StatusMessage = "Ready to connect.";
        }

        private async void OnStartBluetooth()
        {
            // Implement Bluetooth Low Energy fast pairing logic here
            StatusMessage = "Bluetooth pairing initiated...";
            // Example: await BluetoothService.StartPairingAsync();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}