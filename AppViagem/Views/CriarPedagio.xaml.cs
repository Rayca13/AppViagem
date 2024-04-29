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
			Pedagio p = new Pedagio();
			p.local = txt_local.Text;
			p.valor = Convert.ToDouble(txt_valor.Text);

			await App.Db.Insert(p);
			await DisplayAlert("Sucesso!", "Pedagio foi adicionado", "Ok");
		}
		catch (Exception ex) 
		{
		
		}
    }
}