using System;
using Plugin.Toasts;
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

	    private async void ShowToastsFormsPlugin(object s, EventArgs e)
	    {
	        var notificator = DependencyService.Get<IToastNotificator>();

	        var options = new NotificationOptions
	        {
	            Title = "Toasts.Forms.Plugin",
	            Description = "Description",
	        };

	        var o = new NotificationOptions
	        {
	            Title = "Toasts.Forms.Plugin",
	            Description = "Description",
                IsClickable = false,
	            WindowsOptions = new WindowsOptions { LogoUri = "icon.png" },
	            ClearFromHistory = false,
	            AllowTapInNotificationCenter = false,
	            AndroidOptions = new AndroidOptions
	            {
	                HexColor = "#F99D1C",
	                ForceOpenAppOnNotificationTap = true
	            }
	        };

	        await notificator.Notify(options);
	    }
	}
}
