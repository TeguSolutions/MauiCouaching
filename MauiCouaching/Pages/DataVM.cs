using MauiCouaching.Helper;
using MauiCouaching.Services;

namespace MauiCouaching.Pages;

public partial class DataVM : BaseViewModel
{
    private DatabaseService _db;

    #region Lifecycle

    public DataVM(DatabaseService db)
    {
        _db = db;
    }

    #endregion


}