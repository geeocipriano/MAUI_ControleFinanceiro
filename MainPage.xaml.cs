using MAUI_ControleFinanceiro.ViewModels;

namespace MAUI_ControleFinanceiro;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        BindingContext = new HomeViewModel();
    }
}

