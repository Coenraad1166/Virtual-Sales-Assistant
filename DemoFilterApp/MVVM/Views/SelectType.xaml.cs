using DemoFilterApp.MVVM.Model;
using DemoFilterApp.MVVM.ViewModel;
using Microsoft.Maui.ApplicationModel;
using PropertyChanged;

namespace DemoFilterApp.MVVM.Views;
[AddINotifyPropertyChangedInterface]
public partial class SelectType : ContentPage
{
	
	private List<string> selectedTypes = new List<string>();
	private FilterPageViewModel viewModel= new FilterPageViewModel();
	public SelectType()
    {
		InitializeComponent();
		Application.Current.UserAppTheme = AppTheme.Light;
		
    }

	private async void TypeButton_Clicked(object sender, EventArgs e)
	{
		Button button = (Button)sender;
		string type = button.Text;
		if (selectedTypes.Contains(type))
		{
			selectedTypes.Remove(type);
			button.Background = Colors.White;
		}
		else
		{
			selectedTypes.Add(type);
			button.Background = Colors.Green;
		}
	}

    private async void NextButton_Clicked(object sender, EventArgs e)
    {
		var jsonData = await viewModel.FilterByDevice();
		if(selectedTypes.Count != 0)
		{
			await Navigation.PushAsync(new SelectUsePage(jsonData));
		}
		else
		{
			await DisplayAlert("Error", "Please select an option to continue", "OK");
		}
    }
}