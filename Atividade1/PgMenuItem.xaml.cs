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
    public partial class PgMenuItem : ContentPage
    {
        public PgMenuItem()
        {
            InitializeComponent();
        }

        private void btnTeste_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Login());
        }
    }
}