namespace ComponentsTestModule.Views
{
    public partial class MainPage : ContentPage
    {
        private bool _loaded;


        public MainPage()
        {
            InitializeComponent();

            switch (SettingHandler.Theme)
            {
                case 0:
                    XNameRadioButtonSystem.IsChecked = true;
                    break;
                case 1:
                    XNameRadioButtonLight.IsChecked = true;
                    break;
                case 2:
                    XNameRadioButtonDark.IsChecked = true;
                    break;
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _loaded = true;
        }

        private void OnCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (!_loaded)
                return;

            if (!e.Value)
                return;

            var val = (sender as RadioButton)?.Value as string;
            if (string.IsNullOrWhiteSpace(val))
                return;

            switch (val)
            {
                case "System":
                    SettingHandler.Theme = 0;
                    break;
                case "Light":
                    SettingHandler.Theme = 1;
                    break;
                case "Dark":
                    SettingHandler.Theme = 2;
                    break;
            }

            UserTheme.SetTheme();
        }
    }

}
