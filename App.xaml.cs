using RegistroEstudiantesMVVM.Views;

namespace RegistroEstudiantesMVVM;

public partial class App : Application
{
	private readonly RegistroPage _registroPage;

	public App(RegistroPage registroPage)
	{
		InitializeComponent();
		_registroPage = registroPage;
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new NavigationPage(_registroPage));
	}
}