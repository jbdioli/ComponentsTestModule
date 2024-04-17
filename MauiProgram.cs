using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace ComponentsTestModule
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

                    fonts.AddFont("fa-brands-400.ttf", "FA-BRANDS");
                    fonts.AddFont("fa-brands-regular-400.otf", "FA-BRANDS-R");
                    fonts.AddFont("fa-regular-400.ttf", "FA-R");
                    fonts.AddFont("fa-solid-900.ttf", "FA-S");
                    fonts.AddFont("fa-duotone-solid-900.otf", "FA-DUOTONE-S");

                    fonts.AddFont("fa-pro-Light-300.otf", "FA-PRO-L");
                    fonts.AddFont("fa-pro-regular-400.otf", "FA-PRO-R");
                    fonts.AddFont("fa-pro-solid-900.otf", "FA-PRO-S");
                    fonts.AddFont("fa-pro-thin-100.otf", "FA-PRO-T");
                    fonts.AddFont("fa-sharp-light-300.otf", "FA-SHARP-L");
                    fonts.AddFont("fa-sharp-regular-400.otf", "FA-SHARP-R");
                    fonts.AddFont("fa-sharp-solid-900.otf", "FA-SHARP-S");
                    fonts.AddFont("fa-sharp-thin-100.otf", "FA-SHARP-T");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
