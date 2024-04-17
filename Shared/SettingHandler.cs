
namespace ComponentsTestModule.Shared;

public static class SettingHandler
{
    // 0 = default, 1 = light, 2 = dark
    private const int _theme = 0;
    
    public static int Theme
    {
        get => Preferences.Get(nameof(Theme), _theme);
        set => Preferences.Set(nameof(Theme), value);
    }

}