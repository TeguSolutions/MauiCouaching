namespace MauiCouaching.Helper;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    //[NotifyPropertyChangedFor(nameof(IsNotBusy))]
    [AlsoNotifyChangeFor(nameof(IsNotBusy))]
    private bool isBusy;

    public bool IsNotBusy => !IsBusy;

    [ObservableProperty]
    private string title;
}