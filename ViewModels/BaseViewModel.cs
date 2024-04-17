
namespace ComponentsTestModule.ViewModels;

[QueryProperty(nameof(Dto), nameof(Dto))]
public partial class BaseViewModel : ObservableObject
{

    [ObservableProperty]
    private bool _isBusy = false;

    [ObservableProperty]
    private object _dto = new();

    [RelayCommand]
    private async Task GoBack()
    {
        await Shell.Current.GoToAsync($"..");
    }

}