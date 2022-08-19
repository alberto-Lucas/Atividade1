using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Atividade1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Clicked(object sender, EventArgs e)
        {
            if (ValidarLogin(txtlogin.Text, txtSenha.Text))
            {
                var usuarioLogado = UsuarioLogado.Instancia;
                usuarioLogado.Login = txtlogin.Text;

                Navigation.PushModalAsync(new Principal());
            }
            else
                DisplayAlert("Atenção",
                            "Login ou Senha inválidos!",
                            "Ok");
        }

        bool ValidarLogin(string login, string senha)
        {
            return (login == "admin" && senha == "admin");
        }
    }
}