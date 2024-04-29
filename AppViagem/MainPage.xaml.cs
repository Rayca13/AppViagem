using AppViagem.Models;

namespace AppViagem
{
    public partial class MainPage : ContentPage
    {
        public static Viagem vg;

        public MainPage()
        {
            InitializeComponent();
        }

        private void bnt_VerPedagios_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_CalcularCusto_Clicked(object sender, EventArgs e)
        {
            vg = new Viagem
            {
                
            };
        }

    
    }

}
