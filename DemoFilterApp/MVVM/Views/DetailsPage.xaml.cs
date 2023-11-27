using DemoFilterApp.MVVM.Model;

namespace DemoFilterApp.MVVM.Views;

public partial class DetailsPage : ContentPage
{
	private ProductModel _product;
	public DetailsPage(ProductModel product)
	{
		InitializeComponent();
		BindingContext = product;
		_product = product;
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		Uri uri = new Uri(_product.Url);
		await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
    }
}