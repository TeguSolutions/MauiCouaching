using MauiCouaching.Helper;

namespace MauiCouaching.Pages;

public partial class MainVM : BaseViewModel
{
    int count = 0;

    [ICommand]
    private void OnCounterClicked()
    {
        count++;

        if (count == 1)
            CountText = $"Clicked {count} time";
        else
            CountText = $"Clicked {count} times";

        //SemanticScreenReader.Announce(CounterBtn.Text);
    }

    [ObservableProperty]
    private string countText;
}