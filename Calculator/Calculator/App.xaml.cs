using Calculator.MVVM.Views;

namespace Calculator;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new CalculatorView();
	}
}
