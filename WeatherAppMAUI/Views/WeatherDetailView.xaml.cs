using WeatherAppMAUI.ViewModels;

namespace WeatherAppMAUI.Views;

public partial class WeatherDetailView : ContentPage
{
	public WeatherDetailView(WeatherDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}