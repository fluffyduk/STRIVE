using Microsoft.Extensions.Logging;

namespace STRIVE
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
					fonts.AddFont("EBGaramond-Bold.ttf", "Garamond700");
					fonts.AddFont("EBGaramond-Regular.ttf", "Garamond400");
					fonts.AddFont("EBGaramond-Italic.ttf", "GaramondItalic");
				});

#if DEBUG
			builder.Logging.AddDebug();
#endif

			return builder.Build();
		}
	}
}
