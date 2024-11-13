using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Styling;
using AvaloniaOne.Models;
using AvaloniaOne.ViewModels;
using Newtonsoft.Json;

namespace AvaloniaOne.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void ButtonTheme_OnClick(object? sender, RoutedEventArgs e)
    {
        if (App.Current.ActualThemeVariant == ThemeVariant.Dark)
        {
            App.Current.RequestedThemeVariant = ThemeVariant.Light;
            ButtonTheme.Content = "Dark";
        }
        else
        {
            App.Current.RequestedThemeVariant = ThemeVariant.Dark;
            ButtonTheme.Content = "Light";
        }
    }
}