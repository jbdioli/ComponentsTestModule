namespace ComponentsTestModule.Shared;

public static class UserTheme
{
    public static void SetTheme()
    {
        switch (SettingHandler.Theme)
        {
            //default
            case 0:
                if (Application.Current != null) Application.Current.UserAppTheme = AppTheme.Unspecified;
                break;
            //light
            case 1:
                if (Application.Current != null) Application.Current.UserAppTheme = AppTheme.Light;
                break;
            //dark
            case 2:
                if (Application.Current != null) Application.Current.UserAppTheme = AppTheme.Dark;
                break;
        }

        var e = DependencyService.Get<IEnvironments.IEnvironment>();
        if (Application.Current != null && Application.Current.RequestedTheme == AppTheme.Dark)
        {
            var navBarColor = Application.Current.Resources["NavBarBackgroundColorDark"].ToString();
            e?.SetStatusBarColor(Color.FromArgb(navBarColor), false);
        }
        else
        {
            var navBarColor = Application.Current?.Resources["NavBarBackgroundColorLight"].ToString();
            e?.SetStatusBarColor(Color.FromArgb(navBarColor), true);
            
        }


    }
}