using MauiCouaching.Pages;

namespace MauiCouaching;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();


        Routing.RegisterRoute(nameof(AppInitializationPage), typeof(AppInitializationPage));
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
    }
}
