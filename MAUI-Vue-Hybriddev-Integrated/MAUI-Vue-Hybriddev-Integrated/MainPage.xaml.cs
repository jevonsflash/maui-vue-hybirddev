namespace MAUI_Vue_Hybriddev_Integrated
{
    public partial class MainPage : Shell
    {
        public MainPage()
        {
            InitializeComponent();
            this.Init();

        }

        private void Init()
        {
           
            this.HomePageContent.Content = new HomePage();
            this.SecondPageContent.Content = new SecondPage();

          
        }
    }
}