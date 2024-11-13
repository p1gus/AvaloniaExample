using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Reactive.Linq;
using AvaloniaOne.Models;
using AvaloniaOne.Views;
using DynamicData;
using Newtonsoft.Json;
using ReactiveUI;

namespace AvaloniaOne.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<Products> Products { get; set; }
    public ObservableCollection<Products> SearchProducts { get; set; } = new ObservableCollection<Products>();
    
    public MainWindowViewModel()
    {
        using (var httpClient = new HttpClient())
        {
            using (var request = new HttpRequestMessage(new HttpMethod("GET"), "https://fakestoreapi.com/products"))
            {
                var response = httpClient.SendAsync(request).Result;

                if (response.IsSuccessStatusCode)
                {
                    ObservableCollection<Products> products = JsonConvert.DeserializeObject<ObservableCollection<Products>>(response.Content.ReadAsStringAsync().Result);
                    
                    Products = JsonConvert.DeserializeObject<ObservableCollection<Products>>(response.Content.ReadAsStringAsync().Result);
                    SearchProducts.AddRange(Products);
                }
            }
        }
    }

    private string? _searchText;


    private void DoSearch(string? searchText)
    {
        
    }
    
    public string? SearchText
    {
        get => _searchText;
        set => this.RaiseAndSetIfChanged(ref _searchText, value);
    }
    
}
