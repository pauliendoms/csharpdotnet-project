using parkingapp.Services;

namespace parkingapp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		DependencyService.Register<ApiDataStore>();

		MainPage = new MainPage();
	}
}
