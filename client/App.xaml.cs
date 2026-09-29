using Squad404.Pages;
using Microsoft.Maui.Controls;

namespace Squad404;

public partial class App : Microsoft.Maui.Controls.Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new LoginPage());
    }
}