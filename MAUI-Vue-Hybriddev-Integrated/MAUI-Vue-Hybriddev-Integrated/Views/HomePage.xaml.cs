using Microsoft.AspNetCore.Components.WebView.Maui;

namespace MAUI_Vue_Hybriddev_Integrated
{
    public partial class HomePage : ContentPage
    {
        public event EventHandler<EventArgs> OnPostBar;
        public HomePage()
        {
            InitializeComponent();
        }

        private void PostBar_Clicked(object sender, EventArgs args)
        {
            OnPostBar?.Invoke(this, args);
        }
    }
}