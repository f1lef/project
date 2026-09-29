using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Squad404.WinUI;

public partial class App : MauiWinUIApplication
{
    public App()
    {
        InitializeComponent();
    }

    protected override MauiApp CreateMauiApp()
    {
        return Squad404.MauiProgram.CreateMauiApp();
    }
}