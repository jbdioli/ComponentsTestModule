namespace ComponentsTestModule
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            UserTheme.SetTheme();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            UserTheme.SetTheme();
            RequestedThemeChanged += App_RequestedThemeChanged;
        }

        protected override void OnSleep()
        {
            UserTheme.SetTheme();
            RequestedThemeChanged += App_RequestedThemeChanged;
        }

        protected override void OnResume()
        {
            UserTheme.SetTheme();
            RequestedThemeChanged += App_RequestedThemeChanged;
        }

        private static void App_RequestedThemeChanged(object? sender, AppThemeChangedEventArgs e)
        {
            MainThread.BeginInvokeOnMainThread(UserTheme.SetTheme);
        }
    }
}
