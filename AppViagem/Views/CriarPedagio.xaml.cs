using AppViagem.Models;

namespace AppViagem.Views;

public partial class CriarPedagio : ContentPage
{
	public CriarPedagio()
	{
		InitializeComponent();
	}

    private async void btn_enviar_Clicked(object sender, EventArgs e)
    {
		try
		{
			Pedagio p = new Pedagio() { 
				local = txt_local.Text,
				valor = Convert.ToDouble(txt_valor.Text)
            };

            await App.Db.Insert(p);
			await DisplayAlert("Sucesso!", "Pedagio foi adicionado", "Ok");
		}
		catch (Exception ex) 
		{
			await DisplayAlert("Erro", ex.Message, "OK");
		}
    }
}