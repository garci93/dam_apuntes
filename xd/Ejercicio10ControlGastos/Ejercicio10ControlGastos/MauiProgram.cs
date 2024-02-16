using Ejercicio10ControlGastos.MVVM.Model;
using Ejercicio10ControlGastos.Repository;
using Microsoft.Extensions.Logging;

namespace Ejercicio10ControlGastos
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<BaseRepository<Cliente>>();
            builder.Services.AddSingleton<BaseRepository<Transaccion>>();

            return builder.Build();
        }
    }
}
