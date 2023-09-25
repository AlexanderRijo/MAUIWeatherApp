using WeatherAppMAUI.ViewModels;

namespace WeatherAppMAUI;

public partial class WeatherView : ContentPage
{
    public WeatherView(WeatherViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}

