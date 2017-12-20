using System;
using Xamarin.Forms;

namespace Dialogs
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    private async void ShowDisplayAlert(object s, EventArgs e)
	    {
	        await DisplayAlert("DisplayAlert", "This an DisplayAlert from Xamarin Forms", "Ok", "Cancel");
	    }

	    private async void ShowActionSheet(object s, EventArgs e)
	    {
	        await DisplayActionSheet("DisplayActionSheet", "Cancel", "Ok", "Copy", "Edit", "Delete");
	    }
    }
}
