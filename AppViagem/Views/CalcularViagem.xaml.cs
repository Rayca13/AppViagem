using AppViagem.Models;

namespace AppViagem.Views;

public partial class CalcularViagem : ContentPage
{

    double total = 0;
    double valor_pedagio = 0;
    public CalcularViagem()
    {
        InitializeComponent();

       
        lbl_destino.Text = "Destino" + MainPage.vg.origem;
    }

    private void btn_novaViagem_Clicked(object sender, EventArgs e)
    {

    }

    private void btn_somar_Clicked(object sender, EventArgs e)
    {

    }
}