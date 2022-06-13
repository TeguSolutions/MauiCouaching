namespace MauiCouaching.Pages;

public partial class AppInitializationPage : ContentPage
{
	public AppInitializationPage(AppInitializationVM vm)
	{
		InitializeComponent();

        BindingContext = vm;

        InitApp();
    }

    private async void InitApp()
    {
        await Task.Delay(3000);

        await Shell.Current.GoToAsync($"//{nameof(MainPage)}", true);
    }
}