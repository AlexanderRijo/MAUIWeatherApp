using WeatherAppMAUI.Views;

namespace WeatherAppMAUI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(WeatherDetailView), typeof(WeatherDetailView));
	}
}
