using Microsoft.AspNetCore.Components.WebView.Maui;

namespace MAUI_Vue_Hybriddev_Integrated
{



    public partial class ThirdPage : ContentPage
    {
        public event EventHandler<OnPostEventArgs> OnPost;
        public ThirdPage()
        {
            InitializeComponent();
            rootComponent.Parameters =
               new Dictionary<string, object>
               {
                            { "ThirdPage", this }
               };
        }

    }
}