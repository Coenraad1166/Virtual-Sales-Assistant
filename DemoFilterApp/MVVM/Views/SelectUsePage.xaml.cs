using DemoFilterApp.MVVM.Model;
using DemoFilterApp.MVVM.ViewModel;

namespace DemoFilterApp.MVVM.Views;

public partial class SelectUsePage : ContentPage
{
	private List<ProductModel> products;
	private FilterPageViewModel viewModel = new FilterPageViewModel();
	public SelectUsePage(List<ProductModel> productModels)
	{
		InitializeComponent();
		products = productModels;
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		Button button = (Button)sender;
		var primaryUseList = await viewModel.FilterByPrimaryUse(button, products);
		await Navigation.PushAsync(new SelectBrandsPage(primaryUseList));
    }
}