using System;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms.Xaml;

namespace Dialogs
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPopup : PopupPage
    {
		public LoginPopup ()
		{
			InitializeComponent ();
		}

        private async void LoginClicked(object sender, EventArgs e)
        {
            await Navigation.PopPopupAsync();
        }
    }
}