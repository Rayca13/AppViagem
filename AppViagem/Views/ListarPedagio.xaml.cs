using AppViagem.Models;
using System.Collections;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace AppViagem.Views;

public partial class ListarPedagio : ContentPage
{
    ObservableCollection <Pedagio> lista_pedagios = new ObservableCollection<Pedagio> ();    

    public ListarPedagio()
	{
		InitializeComponent();
		lst_pedagios.ItemsSource = lista_pedagios;
	}

	protected async override void OnAppearing()
    {
       
        List<Pedagio> tmp = await App.Db.GetAll();
        foreach (Pedagio p in tmp)
        {
            lista_pedagios.Add(p);
        }


        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine(lista_pedagios.Count);
    }
}