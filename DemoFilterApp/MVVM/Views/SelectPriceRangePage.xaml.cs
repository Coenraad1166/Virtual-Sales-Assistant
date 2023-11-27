using DemoFilterApp.MVVM.Model;
using DemoFilterApp.MVVM.ViewModel;

namespace DemoFilterApp.MVVM.Views;

public partial class SelectPriceRangePage : ContentPage
{
	private FilterPageViewModel viewModel = new FilterPageViewModel();
	private List<ProductModel> products = new List<ProductModel>();
	public SelectPriceRangePage(List<ProductModel> productModels)
	{
		InitializeComponent();
		products = productModels;
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		Button button = (Button)sender;
		var filteredPrice = await viewModel.FilterByPrice(button, products);
		if (filteredPrice.Count != 0) {
			await Navigation.PushAsync(new SuggestionPage(filteredPrice));
		}
		else await Navigation.PushAsync(new NoItemsPage());
    }
}