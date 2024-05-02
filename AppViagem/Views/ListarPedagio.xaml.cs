using AppViagem.Models;
using System.Collections;
using System.Collections.ObjectModel;

namespace AppViagem.Views;

public partial class ListarPedagio : ContentPage
{
    private IEnumerable lista_pedagio;
    private object lista_peadagio;

    public ListarPedagio()
	{
		InitializeComponent();
		lst_pedagios.ItemsSource = lista_pedagio;
	}

	protected async override void OnAppearing()
    {
        if (lista_pedagio.Count == 0)
        {
            return;
        }
        List<Pedagio> tmp = await App.Db.GetAll();
        foreach (Pedagio p in tmp)
        {
            lista_pedagio.Add(p);
        }
    }
}