using Microsoft.Maui.Controls;

namespace Chatup.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
    }
}