using MinhaOnboardingPage.ViewModel;

namespace MinhaOnboardingPage.Views;

public partial class OnboardingPage : ContentPage
{
	public OnboardingPage(OnboudingViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}