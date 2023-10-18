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
            InitializeComponent();
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

        public string ReadDeviceDisplay()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.AppendLine($"Pixel width: {DeviceDisplay.Current.MainDisplayInfo.Width} / Pixel Height: {DeviceDisplay.Current.MainDisplayInfo.Height}");
            sb.AppendLine($"Density: {DeviceDisplay.Current.MainDisplayInfo.Density}");
            sb.AppendLine($"Orientation: {DeviceDisplay.Current.MainDisplayInfo.Orientation}");
            sb.AppendLine($"Rotation: {DeviceDisplay.Current.MainDisplayInfo.Rotation}");
            sb.AppendLine($"Refresh Rate: {DeviceDisplay.Current.MainDisplayInfo.RefreshRate}");

            var text = sb.ToString();
            return text;
        }
    }
}