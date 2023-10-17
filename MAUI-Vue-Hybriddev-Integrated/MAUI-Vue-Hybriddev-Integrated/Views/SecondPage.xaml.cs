using Microsoft.AspNetCore.Components.WebView.Maui;

namespace MAUI_Vue_Hybriddev_Integrated
{
    public partial class SecondPage : ContentPage
    {
        public event EventHandler<EventArgs> OnPostBar;
        public SecondPage()
        {
            this.Appearing+=SecondPage_Appearing;
            InitializeComponent();
        }

        private void SecondPage_Appearing(object sender, EventArgs e)
        {
            rootComponent.Parameters =
                new Dictionary<string, object>
                {
                    { "SecondPage", this }
                };
        }

        private void PostBar_Clicked(object sender, EventArgs args)
        {
            OnPostBar?.Invoke(this, args);
        }
    }
}