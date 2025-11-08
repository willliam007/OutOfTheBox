using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace OutOfTheBox
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
                    fonts.AddFont("Poppins-Regular.ttf", "PoppinsRegular");
                    fonts.AddFont("Poppins-Bold.ttf", "PoppinsBold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddTransient<Pages.LoginPage>();
            builder.Services.AddTransient<ViewModels.LoginViewModel>();

            builder.Services.AddTransient<Pages.RegisterPage>();
            builder.Services.AddTransient<ViewModels.RegisterViewModel>();

            builder.Services.AddSingleton<Pages.MainPage>(); 
            builder.Services.AddSingleton<ViewModels.HomeViewModel>();
            


            return builder.Build();
        }
    }
}
