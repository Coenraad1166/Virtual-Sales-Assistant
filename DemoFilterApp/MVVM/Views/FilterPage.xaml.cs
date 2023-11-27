using DemoFilterApp.MVVM.ViewModel;

namespace DemoFilterApp.MVVM.Views;

public partial class FilterPage : ContentPage
{
    private FilterPageViewModel viewModel = new FilterPageViewModel();
	public FilterPage()
	{
		InitializeComponent();
        
	}

    private void LaptopPicker_Focused(object sender, FocusEventArgs e)
    {
		LapOrPcFrame.BorderColor = Colors.Blue;
    }

    private void LaptopPicker_UnFocused(object sender, FocusEventArgs e)
    {
        LapOrPcFrame.BorderColor = Colors.Gray;
    }
    private void PrimaryUsePicker_Focused(object sender, FocusEventArgs e)
    {
        primaryUseFrame.BorderColor = Colors.Blue;
    }

    private void PrimaryUsePicker_UnFocused(object sender, FocusEventArgs e)
    {
        primaryUseFrame.BorderColor = Colors.Gray;
    }
    private void BrandPreferencePicker_Focused(object sender, FocusEventArgs e)
    {
        BrandPreferenceFrame.BorderColor = Colors.Blue;
    }

    private void BrandPreferencePicker_UnFocused(object sender, FocusEventArgs e)
    {
        BrandPreferenceFrame.BorderColor = Colors.Gray;
    }
    private void PriceRangePicker_Focused(object sender, FocusEventArgs e)
    {
        priceRangeFrame.BorderColor = Colors.Blue;
    }

    private void PriceRangePicker_UnFocused(object sender, FocusEventArgs e)
    {
        priceRangeFrame.BorderColor = Colors.Gray;
    }

    //private async void Button_Clicked(object sender, EventArgs e)
    //{
    //    var getDevice = await viewModel.FilterByDevice(devicePicker);
    //    var getUse = await viewModel.FilterByPrimaryUse(primaryUsePicker, getDevice);
    //    var getBrand = await viewModel.FilterByBrand(BrandPicker, getUse);
    //    var getPrice = await viewModel.FilterByPrice(pricePicker, getBrand);
    //    var finishedFilter = getPrice;
    //    if (finishedFilter.Count != 0)
    //    {
    //        await Navigation.PushAsync(new SuggestionPage(finishedFilter));
    //    }
    //    else
    //    {
    //        await Navigation.PushAsync(new NoItemsPage());
    //    }
    //}
}