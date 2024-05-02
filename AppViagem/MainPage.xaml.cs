using AppViagem.Models;

namespace AppViagem
{
    public partial class MainPage : ContentPage
    {
        public static viagem vg;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btn_CalcularCusto_Clicked(object sender, EventArgs e)
        {

            if (txt_origem.Text == null)
            {
                await DisplayAlert("Erro", "Preencha o lugar de origem", "Ok");
                return;
            }

            if (txt_destino.Text == null) 
            {
                await DisplayAlert("Erro", "Preencha o destino", "Ok");
                return;
            }

            if (txt_rendimento == null) 
            {
                await DisplayAlert("Erro", "Preencha o valor do rendimento", "Ok");
                return;
            }

            if (txt_combustivel.Text == null) 
            {
                await DisplayAlert("Erro", "Preencha o valor do combustivel", "Ok");
                return;
            }

            vg = new viagem
            {
                valor_gas = Convert.ToDouble(txt_combustivel.Text),
                destino = txt_destino.Text,
                origem = txt_origem.Text,
                distancia = Convert.ToDouble(txt_distancia.Text),
                rendimento = Convert.ToDouble(txt_rendimento.Text),
            };

            await Navigation.PushAsync(new Views.CalcularViagem());
        }

        private void btn_listaPedagio_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Views.ListarPedagio());
        }

        private void bnt_CiarPedagio_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Views.CriarPedagio());
        }
    }

}
