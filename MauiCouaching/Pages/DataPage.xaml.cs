namespace MauiCouaching.Pages;

public partial class DataPage : ContentPage
{
	public DataPage(DataVM vm)
	{
		InitializeComponent();

        BindingContext = vm;
    }
}