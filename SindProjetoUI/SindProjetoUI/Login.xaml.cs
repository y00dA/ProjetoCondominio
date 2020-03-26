using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SindProjetoUI
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent();
		}

        private async void ButtonEntry_ClickedAsync(object sender, EventArgs e)
        {
            if (UserEntry.Text == "admin" && PasswordEntry.Text == "1234")
            {
                await Navigation.PushAsync(new SindicoPrincipal());
            }
            else
            {
                await DisplayAlert("Erro!", "Usuario ou senha incorreta.", "Tentar novamente");
            }
        }
    }
}