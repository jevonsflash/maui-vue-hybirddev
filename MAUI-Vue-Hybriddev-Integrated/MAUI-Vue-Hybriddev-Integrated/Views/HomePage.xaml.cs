using Microsoft.AspNetCore.Components.WebView.Maui;

namespace MAUI_Vue_Hybriddev_Integrated
{
    public partial class HomePage : ContentPage
    {
        public event EventHandler<EventArgs> OnPostBar;
        public HomePage()
        {
            this.Appearing+=HomePage_Appearing;
            InitializeComponent();
        }

        private void HomePage_Appearing(object sender, EventArgs e)
        {
            rootComponent.Parameters =
                new Dictionary<string, object>
                {
                    { "HomePage", this }
                };
        }

        private void PostBar_Clicked(object sender, EventArgs args)
        {
            OnPostBar?.Invoke(this, args);
        }
    }
}