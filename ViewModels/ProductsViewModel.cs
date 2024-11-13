using AvaloniaOne.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaOne.ViewModels;

public partial class ProductsViewModel : ViewModelBase
{
    private readonly Products _products;
    
    public ProductsViewModel(Products product)
    {
        _products = product;
    }
    
    public int Id => _products.Id;
    public string Title => _products.Title;
    public string Description => _products.Description;
    public string Image => _products.Image;
    public decimal Price => _products.Price;


}