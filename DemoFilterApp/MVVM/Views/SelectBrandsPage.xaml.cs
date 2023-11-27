using DemoFilterApp.MVVM.Model;
using DemoFilterApp.MVVM.ViewModel;

namespace DemoFilterApp.MVVM.Views;

public partial class SelectBrandsPage : ContentPage
{
	private List<ProductModel> products;
    private List<string> selectedBrands = new List<string>();
    private List<ProductModel> filteredList = new List<ProductModel>();
    private FilterPageViewModel viewModel = new FilterPageViewModel();
	public SelectBrandsPage(List<ProductModel> productModel)
	{
		InitializeComponent();
		products = productModel;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string type = button.Text;
        if (selectedBrands.Contains(type))
        {
            selectedBrands.Remove(type);
            button.Background = Colors.White;
        }
        else
        {
            selectedBrands.Add(type);
            button.Background = Colors.Green;
        }
    }
    private async void NextButton_Clicked(object sender, EventArgs e)
    {
        if (selectedBrands.Contains("None"))
        {
            await Navigation.PushAsync(new SelectPriceRangePage(products));
        }
        else {
            var filterBrands = await viewModel.FilterByBrand(selectedBrands, products);
            await Navigation.PushAsync(new SelectPriceRangePage(filterBrands)); }

        
    }
}