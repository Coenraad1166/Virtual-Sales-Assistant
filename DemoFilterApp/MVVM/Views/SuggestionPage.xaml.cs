using DemoFilterApp.MVVM.Model;

namespace DemoFilterApp.MVVM.Views;

public partial class SuggestionPage : ContentPage
{
	public SuggestionPage(List<ProductModel> suggestionList)
	{
		InitializeComponent();
		listView.ItemsSource = suggestionList;
	}

  
    private void Button_Clicked(object sender, EventArgs e)
    {
        
        Button button = (Button)sender;
        var selectedItem = button.BindingContext as ProductModel;
        if (selectedItem != null)
        {
           
            Navigation.PushAsync(new DetailsPage(selectedItem));
        }
    }
}