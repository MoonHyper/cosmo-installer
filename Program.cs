using Avalonia;
using Avalonia.ReactiveUI;
using System;

namespace CosmoInstaller
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // Initialize and start the application
            BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
        }

        // Configure the Avalonia application
        static AppBuilder BuildAvaloniaApp()
        {
            return AppBuilder.Configure<App>()
                .LogToTrace()
                .UsePlatformDetect()
                .UseReactiveUI();
        }
    }
}
