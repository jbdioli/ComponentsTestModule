using Color = Microsoft.Maui.Graphics.Color;

namespace ComponentsTestModule.Interfaces;

public interface IEnvironments
{
    public interface IEnvironment
    {
        void SetStatusBarColor(Color color, bool darkStatusBarTint);
    }
}