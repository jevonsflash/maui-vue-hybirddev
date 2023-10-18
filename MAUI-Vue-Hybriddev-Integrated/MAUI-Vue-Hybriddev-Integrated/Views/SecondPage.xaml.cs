using Microsoft.AspNetCore.Components.WebView.Maui;

namespace MAUI_Vue_Hybriddev_Integrated
{

    public class OnPostEventArgs : EventArgs
    {
        public OnPostEventArgs(string content)
        {
            this.Content = content;
        }
        public string Content { get; set; }
    }

    public partial class SecondPage : ContentPage
    {
        public event EventHandler<OnPostEventArgs> OnPost;
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

        private void Post_Clicked(object sender, EventArgs args)
        {
            OnPost?.Invoke(this, new OnPostEventArgs(this.PostContentEntry.Text));
        }
    }
}