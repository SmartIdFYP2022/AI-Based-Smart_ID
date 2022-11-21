namespace Smart_ID;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new Views.DashBoardPage());
	}
}
