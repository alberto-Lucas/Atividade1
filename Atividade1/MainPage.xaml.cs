using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Atividade1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnEntrar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Cadastro", "Nome: " + txtNome.Text +
                                     "\nIdade: " + txtIdade.Text +
                                     "\nSexo: " + txtSexo.Text +
                                     "\nTelefone: " + txtTelefone.Text,
                                     "Ok");
        }

        private void btnLimpar_Clicked(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtIdade.Text = "";
            txtSexo.Text = "";
            txtTelefone.Text = "";
        }
    }
}
